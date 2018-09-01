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
    public partial class formPurchaseOrder : Form
    {
        // Variables 
        public MySqlConnection conn;
        public MySqlCommand command;
        public MySqlDataAdapter adapter;
        public DataTable dataTable;

        string query;

        int suppID, po_stat, latestPO_id;
        string suppName, suppAddr, suppContactNum, suppFaxNum;
        string docDate, orderDate;
        
        public Form refviewItems { get; set; }
        public Form refWhse { get; set; }

        public List<classItems> itemValues { get; set; }

        int po_ID; // for reference of the purchase order

        bool modeChecker;

        public formPurchaseOrder()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost; Database=rillan_trading; Uid=root; Pwd=root;");
        }

        private void formPurchaseOrder_Load(object sender, EventArgs e)
        {
            tbox_supplier.Enabled = false;
            btn_itemView.Enabled = false;
            btn_removeItem.Enabled = false;
            dtp_docDate.Enabled = false;
            dtp_orderDate.Enabled = false;
            tbox_notes.Enabled = false;

            resetSupplierFields();

            // Searching for available supplier
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT supp_name FROM supplier", conn);
                MySqlDataReader read = comm.ExecuteReader();
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                while (read.Read())
                {
                    col.Add(read.GetString(0));
                }
                tbox_supplier.AutoCompleteCustomSource = col;
                conn.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
                conn.Close();
            }

            //get latest PO ID
            try
            {
                command = new MySqlCommand("SELECT po_id FROM purchase_order ORDER BY po_id DESC LIMIT 1", conn);
                conn.Open();
                adapter = new MySqlDataAdapter(command);
                dataTable = new DataTable();
                adapter.Fill(dataTable);

                latestPO_id = int.Parse(dataTable.Rows[0]["po_id"].ToString()) + 1;
                
                conn.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }


        }

        private void resetSupplierFields()
        {
            tbox_supplier.Text = "";
            tbox_notes.Text = "";
            lbl_suppAddress.Text = "";
            lbl_suppContactNum.Text = "";
            lbl_suppFaxNum.Text = "";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgv_orderLine_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        #region Buttons

        private void btn_itemView_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            formWarehouseMgt fWhse = new formWarehouseMgt();
            fWhse.refPO = this;
            fWhse.Show();
            this.Close();
        }

        private void btn_findMode_Click(object sender, EventArgs e)
        {
            dgv_orderLine.Rows.Clear();
            findMode();

        }


        private void btn_find_Click(object sender, EventArgs e)
        {
            viewFormPOList fPO_List = new viewFormPOList();
            fPO_List.refSuppName = tbox_supplier.Text;
            DialogResult dr = fPO_List.ShowDialog(this);

            if (dr == DialogResult.Cancel)
            {
                fPO_List.Close();
            }
            else if (dr == DialogResult.OK)
            {
                fPO_List.refSuppName = tbox_supplier.Text;
                po_ID = fPO_List.refPOID;
                fPO_List.Close();

                dgv_orderLine.Rows.Clear();
                PODetailsLoad();
            }
        }

        private void btn_orderMode_Click(object sender, EventArgs e)
        {
            dgv_orderLine.Rows.Clear();
            orderMode();
        }

        private void btn_addOrder_Click(object sender, EventArgs e)
        {
            addPurchaseOrder();
            addPurchaseLine();
        }
        
        #endregion


        private void tbox_supplier_TextChanged(object sender, EventArgs e)
        {
            if (modeChecker == true) // assignment mode
            {
                if (tbox_supplier.Text != null)
                {
                    btn_itemView.Enabled = true;
                    btn_removeItem.Enabled = true;
                    dtp_docDate.Enabled = true;
                    dtp_orderDate.Enabled = true;
                    tbox_notes.Enabled = true;
                }

                try
                {
                    conn.Open();
                    MySqlCommand comm = new MySqlCommand("SELECT supp_id, supp_name, supp_address, supp_contactNum, supp_faxNum FROM supplier WHERE supp_name = '" + tbox_supplier.Text + "'", conn);
                    MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);

                    if (dt.Rows.Count == 1)
                    {
                        suppID = int.Parse(dt.Rows[0]["supp_id"].ToString());
                        suppName = dt.Rows[0]["supp_name"].ToString();
                        suppAddr = dt.Rows[0]["supp_address"].ToString();
                        suppContactNum = dt.Rows[0]["supp_contactNum"].ToString();
                        suppFaxNum = dt.Rows[0]["supp_faxNum"].ToString();

                    }

                    conn.Close();

                    lbl_suppAddress.Text = suppAddr;
                    lbl_suppContactNum.Text = suppContactNum;
                    lbl_suppFaxNum.Text = suppFaxNum;
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                    conn.Close();
                }
            }
        }

        // - -  Add data to DGV from another form -- 
        
        
        #region Order Mode Functions

        public void orderMode ()
        {
            tbox_supplier.Enabled = true;
            tbox_notes.Enabled = true;
            lbl_status.Text = "";
            dtp_docDate.Enabled = true;
            dtp_orderDate.Enabled = true;
            dgv_orderLine.Enabled = true;
            btn_itemView.Enabled = true;
            btn_removeItem.Enabled = true;
            btn_addOrder.Visible = true;
            btn_find.Visible = false;
            modeChecker = true;
        }

        private void addPurchaseLine()//adds purchase order line
        {
            try
            {
                if (dgv_orderLine.RowCount > 1)
                {
                    for (int i = 0; i <= (dgv_orderLine.RowCount - 1); i++)
                    {
                        int item_id = int.Parse(dgv_orderLine.Rows[i].Cells[0].Value.ToString());
                        String item_desc = dgv_orderLine.Rows[i].Cells[1].Value.ToString();
                        int quantity = int.Parse(dgv_orderLine.Rows[i].Cells[2].Value.ToString());
                        String unit = dgv_orderLine.Rows[i].Cells[3].Value.ToString();
                        float price = float.Parse(dgv_orderLine.Rows[i].Cells[4].Value.ToString());

                        try
                        {
                            conn.Open();
                            //Inserting  values to MySql Emp table
                            command = conn.CreateCommand();
                            command.CommandText = "INSERT INTO purchase_order_line (po_id_fk, item_id_fk, item_desc, item_quantity, item_unit, item_price) VALUES " +
                                                    "('" + latestPO_id + "' , '" + item_id + "' , '" + item_desc + "', '" + quantity + "', '" + unit + "', '" + price + "' )";

                            command.ExecuteNonQuery();
                            MessageBox.Show("Successfully added an purchase line");
                            conn.Close();
                            conn.Dispose();

                        }
                        catch (Exception x)
                        {
                            MessageBox.Show(x.ToString());
                        }
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void addPurchaseOrder()//Adds purchase order
        {
            try
            {
                conn.Open();

                //Inserting  values to MySql Emp table
                command = conn.CreateCommand();
                command.CommandText = "INSERT INTO purchase_order (supp_id_fk, emp_id_fk, po_docDate, po_orderDate, po_status) VALUES " +
                    "                  ('" + getSuppFk() + "' , 4, NOW(), NOW(), 1 )";
                //Add employee confirmation
                if (MessageBox.Show("Are you sure you want to add this purchase order?", "Add Purchase Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    command.ExecuteNonQuery();
                    conn.Close();
                    conn.Dispose();

                    MessageBox.Show("Successfully added purchase order");
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private int getSuppFk()//This function will get the id of the supplier for the create function
        {
            try
            {
                // Get data from DB
                MySqlCommand comm = new MySqlCommand("SELECT supp_id FROM supplier WHERE supp_name = '" + tbox_supplier.Text + "' ", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    suppID = int.Parse(dt.Rows[0]["supp_id"].ToString());
                }

                return suppID;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
                return suppID;
            }
        }




        #endregion

        #region Find Mode Functions

        public void findMode ()
        {
            // User must be able to search for specific purchase orders
            // Once user will be able to search for specific supplier, a dialog box will show
            // User will select specific order
            // Purchase Order data will be passed back to the purchase order form

            tbox_supplier.Enabled = true;
            tbox_notes.Enabled = false;
            lbl_status.Text = "";
            dtp_docDate.Enabled = false;
            dtp_orderDate.Enabled = false;
            btn_itemView.Enabled = false;
            btn_removeItem.Enabled = false;
            dgv_orderLine.Enabled = false;
            btn_addOrder.Visible = false;
            btn_find.Visible = true;
            modeChecker = false;

        }

        public void PODetailsLoad ()
        {
            try
            {
                conn.Open();
                // -- Supplier Details & Dates
                MySqlCommand comm = new MySqlCommand("SELECT supp_name, supp_address, supp_contactNum, supp_faxNum, po_docDate, po_orderDate, po_status, po_notes " +
                            "FROM purchase_order " +
                            "INNER JOIN supplier on supp_id_fk = supp_id " +
                            "WHERE po_id = '" + po_ID + "'", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    suppName = dt.Rows[0]["supp_name"].ToString();
                    suppAddr = dt.Rows[0]["supp_address"].ToString();
                    suppContactNum = dt.Rows[0]["supp_contactNum"].ToString();
                    suppFaxNum = dt.Rows[0]["supp_faxNum"].ToString();
                    
                    docDate = dt.Rows[0]["po_docDate"].ToString();
                    orderDate = dt.Rows[0]["po_orderDate"].ToString();

                    po_stat = int.Parse(dt.Rows[0]["po_status"].ToString());

                    tbox_notes.Text = dt.Rows[0]["po_notes"].ToString();
                }

                tbox_supplier.Text = suppName;
                lbl_suppAddress.Text = suppAddr;
                lbl_suppContactNum.Text = suppContactNum;
                lbl_suppFaxNum.Text = suppFaxNum;
                dtp_docDate.Text = docDate;
                dtp_orderDate.Text = orderDate;
               
                if (po_stat == 0)
                {
                    lbl_status.Text = "Closed";
                }
                else if (po_stat == 1)
                {
                    lbl_status.Text = "Open";
                }

                // Datagridview Orderline
                adapter = new MySqlDataAdapter("SELECT ITEM_CODE, ITEM_DESC, PO_LINE_UNIT, PO_LINE_QUANTITY, PO_LINE_PRICE " +
                            "FROM PURCHASE_ORDER_LINE " +
                            "INNER JOIN ITEM ON ITEM_ID_FK = ITEM_ID " +
                            "WHERE PO_ID = '"+ po_ID +"'", conn);
                dataTable = new DataTable();
                adapter.Fill(dataTable);

                foreach (DataRow item in dataTable.Rows)
                {
                    int n = dgv_orderLine.Rows.Add();
                    dgv_orderLine.Rows[n].Cells[0].Value = item[0].ToString(); // PO ID
                    dgv_orderLine.Rows[n].Cells[1].Value = item[1].ToString(); // Item Code
                    dgv_orderLine.Rows[n].Cells[2].Value = item[2].ToString(); // Item Desc
                    dgv_orderLine.Rows[n].Cells[3].Value = item[3].ToString(); // Unit
                    dgv_orderLine.Rows[n].Cells[4].Value = item[4].ToString(); // Qty
                    dgv_orderLine.Rows[n].Cells[5].Value = item[5].ToString(); // Price
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

        
    }
}
