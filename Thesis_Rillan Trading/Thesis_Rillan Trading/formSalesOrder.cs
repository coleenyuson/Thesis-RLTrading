using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Thesis_Rillan_Trading
{
    public partial class formSalesOrder : Form
    {
        //Variable
        public MySqlConnection conn;
        public MySqlCommand command;
        public MySqlDataAdapter adapter;
        public DataTable dataTable;

        bool modeChecker;

        int so_ID, soStat;

        string docDate, ordDate;

        public Form refSalesMgt { get; set; }

        public formSalesOrder()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost; Database=rillan_trading; Uid=root; Pwd=root;");
        }

        private void formSalesOrder_Load(object sender, EventArgs e)
        {
            btn_itemView.Enabled = false;
            btn_removeItem.Enabled = false;
            dtp_docDate.Enabled = false;
            dtp_orderDate.Enabled = false;
            tbox_notes.Enabled = false;

            resetDetails();

            // Automatic Search for Customer
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT cust_name FROM customer", conn);
                MySqlDataReader read = comm.ExecuteReader();
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                while (read.Read())
                {
                    col.Add(read.GetString(0));
                }
                tbox_customer.AutoCompleteCustomSource = col;
                conn.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
                conn.Close();
            }
        }

        #region Buttons

        private void btn_findMode_Click(object sender, EventArgs e)
        {
            dgv_salesOrderLine.Rows.Clear();
            findMode();
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            viewFormSOList fSO_List = new viewFormSOList();
            fSO_List.refCustName = tbox_customer.Text;
            DialogResult dr = fSO_List.ShowDialog(this);

            if (dr == DialogResult.Cancel)
            {
                fSO_List.Close();
            }
            else if (dr == DialogResult.OK)
            {
                fSO_List.refCustName = tbox_customer.Text;
                so_ID = fSO_List.refSOID;
                fSO_List.Close();

                dgv_salesOrderLine.Rows.Clear();
                SODetailsLoad();
            }
        }

        private void btn_orderMode_Click(object sender, EventArgs e)
        {
            dgv_salesOrderLine.Rows.Clear();
            orderMode();
        }

        #endregion

        #region Find Mode 

        private void findMode()
        {
            tbox_customer.Enabled = true;
            tbox_notes.Enabled = false;
            lbl_status.Text = "";
            dtp_docDate.Enabled = false;
            dtp_orderDate.Enabled = false;
            btn_itemView.Enabled = false;
            btn_removeItem.Enabled = false;
            dgv_salesOrderLine.Enabled = false;
            btn_addOrder.Visible = false;
            btn_find.Visible = true;
            modeChecker = false;
        }

       

        private void SODetailsLoad()
        {
           try
            {
                conn.Open();
                // -- Supplier Details & Dates
                MySqlCommand comm = new MySqlCommand("SELECT cust_name, cust_contactPerson, cust_contactNum, cust_faxNum, so_docDate, so_orderDate, so_status, so_notes " +
                            "FROM sales_order " +
                            "INNER JOIN customer on cust_id_fk = cust_id " +
                            "WHERE so_id = '" + so_ID + "'", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    tbox_customer.Text = dt.Rows[0]["cust_name"].ToString();
                    lbl_contactPerson.Text = dt.Rows[0]["cust_contactPerson"].ToString();
                    lbl_ContactNum.Text = dt.Rows[0]["cust_contactNum"].ToString();
                    lbl_FaxNum.Text = dt.Rows[0]["cust_faxNum"].ToString();

                    docDate = dt.Rows[0]["so_docDate"].ToString();
                    ordDate = dt.Rows[0]["so_orderDate"].ToString();

                    soStat = int.Parse(dt.Rows[0]["so_status"].ToString());

                    tbox_notes.Text = dt.Rows[0]["so_notes"].ToString();
                }

                if (soStat == 0)
                {
                    lbl_status.Text = "Closed";
                }
                else if (soStat == 1)
                {
                    lbl_status.Text = "Open";
                }

                // Datagridview Orderline
                adapter = new MySqlDataAdapter("SELECT ITEM_CODE, ITEM_DESC, PO_LINE_UNIT, PO_LINE_QUANTITY, PO_LINE_PRICE " +
                            "FROM SALES_ORDER_LINE " +
                            "INNER JOIN ITEM ON ITEM_ID_FK = ITEM_ID " +
                            "WHERE SO_ID = '" + so_ID + "'", conn);
                dataTable = new DataTable();
                adapter.Fill(dataTable);

                foreach (DataRow item in dataTable.Rows)
                {
                    int n = dgv_salesOrderLine.Rows.Add();
                    dgv_salesOrderLine.Rows[n].Cells[0].Value = item[0].ToString(); // PO ID
                    dgv_salesOrderLine.Rows[n].Cells[1].Value = item[1].ToString(); // Item Code
                    dgv_salesOrderLine.Rows[n].Cells[2].Value = item[2].ToString(); // Item Desc
                    dgv_salesOrderLine.Rows[n].Cells[3].Value = item[3].ToString(); // Unit
                    dgv_salesOrderLine.Rows[n].Cells[4].Value = item[4].ToString(); // Qty
                    dgv_salesOrderLine.Rows[n].Cells[5].Value = item[5].ToString(); // Price
                }

                conn.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
                conn.Close();
            }
        }

        #endregion

        #region Order Mode

        private void orderMode()
        {
            tbox_customer.Enabled = true;
            tbox_notes.Enabled = true;
            lbl_status.Text = "";
            dtp_docDate.Enabled = true;
            dtp_orderDate.Enabled = true;
            dgv_salesOrderLine.Enabled = true;
            btn_itemView.Enabled = true;
            btn_removeItem.Enabled = true;
            btn_addOrder.Visible = true;
            btn_find.Visible = false;
            modeChecker = true;
        }

        #endregion

        private void btn_Back_Click(object sender, EventArgs e)
        {
            formSalesMgt fSalesMgt = new formSalesMgt();
            fSalesMgt.refSO = this;
            fSalesMgt.Show();
            this.Close();
        }

        private void btn_itemView_Click(object sender, EventArgs e)
        {

        }

        private void resetDetails()
        {
            tbox_customer.Text = "";
            lbl_contactPerson.Text = "";
            lbl_custAddress.Text = "";
            lbl_ContactNum.Text = "";
            lbl_status.Text = "";
            lbl_FaxNum.Text = "";
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

       
    }
}
