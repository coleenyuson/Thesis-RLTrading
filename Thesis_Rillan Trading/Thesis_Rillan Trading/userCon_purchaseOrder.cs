using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Thesis_Rillan_Trading
{
    public partial class userCon_purchaseOrder : UserControl
    {
        // Variables 
        public MySqlConnection conn;
        public MySqlCommand command;
        public MySqlDataAdapter adapter;
        public DataTable dataTable;

        string query;


        public userCon_purchaseOrder()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost; Database=rillan_trading; Uid=root; Pwd=root;");
        }

        private void purchaseOrder_Load(object sender, EventArgs e)
        {
            //AddToGrid(itemValues);
        }

        #region Button Functions

        private void btn_addItem_Click_1(object sender, EventArgs e)
        {
            viewForm_PO_items fviewItems = new viewForm_PO_items();
            fviewItems.Show();
        }

        #endregion

        #region Purchase Order Functions

        private void addPurchaseOrder()
        {
            try
            {
                conn.Open ();

                //Inserting  values to MySql Emp table
                command = conn.CreateCommand();
                command.CommandText = "INSERT INTO purchase_order (supp_id_fk, emp_id_fk, po_date, po_status) VALUES " +
                    "                  ('" + getSuppFk() + "' , 4, NOW(), 1 )";
                //Add employee confirmation
                if (MessageBox.Show ("Are you sure you want to add this employee profile?", "Add Purchase Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    command.ExecuteNonQuery();
                    conn.Close();
                    conn.Dispose();

                    MessageBox.Show ("Successfully added purchase order");
                }
            }
            catch (Exception x)
            {
                MessageBox.Show (x.ToString());
            }
        }

        private void addPurchaseLine()
        {
            try
            {
                if (dgv_orderLine.RowCount > 1)
                {
                    for (int i = 0; i <= (dgv_orderLine.RowCount - 1); i++)
                    {
                        int item_id = int.Parse(dgv_orderLine.Rows[i].Cells[5].Value.ToString());
                        String item_desc = dgv_orderLine.Rows[i].Cells[1].Value.ToString();
                        int quantity = int.Parse(dgv_orderLine.Rows[i].Cells[2].Value.ToString());
                        String unit = dgv_orderLine.Rows[i].Cells[3].Value.ToString();
                        float price = float.Parse(dgv_orderLine.Rows[i].Cells[4].Value.ToString());

                        try
                        {
                           conn.Open ();
                            //Inserting  values to MySql Emp table
                            command = conn.CreateCommand();
                            command.CommandText = "INSERT INTO purchase_order_line (po_id_fk, item_id_fk, item_desc, item_quantity, item_unit, item_price) VALUES " +
                                                    "(4 , '" + item_id + "' , '" + item_desc + "', '" + quantity + "', '" + unit + "', '" + price + "' )";

                            command.ExecuteNonQuery();
                            MessageBox.Show ("Successfully added an purchase line");
                            conn.Close();
                            conn.Dispose();

                        }
                        catch (Exception x)
                        {
                            MessageBox.Show (x.ToString());
                        }
                    }
                }
            }
            catch (Exception x)
            {
               MessageBox.Show (x.ToString());
            }
        }

        int supp_id;
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
                    supp_id = int.Parse(dt.Rows[0]["supp_id"].ToString());
                }

                return supp_id;
            }
            catch (Exception x)
            {
                MessageBox.Show (x.ToString());
                return supp_id;
            }
        }


        #endregion

        #region Defined Functions

        public void AddToGrid(List<classItems> val)
        {

            if (val != null)
            {
                foreach (classItems item in val)
                {
                    int n = dgv_orderLine.Rows.Add();
                    dgv_orderLine.Rows[n].Cells[0].Value = item.itemCode;
                    dgv_orderLine.Rows[n].Cells[1].Value = item.itemDesc;
                }
            }
        }

        #endregion

    }
}
