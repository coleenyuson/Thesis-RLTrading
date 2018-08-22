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

        int suppID;
        string suppName, suppAddr, suppContactNum, suppFaxNum;
        
        public Form refInventory { get; set; }
        public Form refviewItems { get; set; }

        public List<classItems> itemValues { get; set; }

        public formPurchaseOrder()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost; Database=rillan_trading; Uid=root; Pwd=root;");
        }

        private void formPurchaseOrder_Load(object sender, EventArgs e)
        {
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
            
        }

       
        private void btn_itemView_Click(object sender, EventArgs e)
        {
            viewForm_PO_items fviewItems = new viewForm_PO_items();
            DialogResult dr = fviewItems.ShowDialog(this);

            if (dr == DialogResult.Cancel)
            {
                fviewItems.Close();
            }
            else if (dr == DialogResult.OK)
            {
                itemValues = fviewItems.getItems();
                AddToGrid(itemValues);
                fviewItems.Close();
            }
            
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            formInventoryMgt fInv = new formInventoryMgt();
            fInv.refPO = this;
            fInv.Show();
            this.Close();
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

        private void tbox_supplier_TextChanged(object sender, EventArgs e)
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
                MySqlCommand comm = new MySqlCommand("SELECT supp_id, supp_name, supp_address, supp_contactNum, supp_faxNum FROM supplier WHERE supp_name = '"+ tbox_supplier.Text +"'", conn);
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

        // - -  Add data to DGV from another form -- 
        public void AddToGrid(List<classItems> val)
        {
            if (val != null)
            {
                foreach (classItems item in val)
                {
                    int n = dgv_orderLine.Rows.Add();
                    dgv_orderLine.Rows[n].Cells[0].Value = item.itemID;
                    dgv_orderLine.Rows[n].Cells[1].Value = item.itemCode;
                    dgv_orderLine.Rows[n].Cells[2].Value = item.itemDesc;
                }
            }
        }

        
    }
}
