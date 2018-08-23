using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input; // for shortcut key 
using MySql.Data.MySqlClient;

namespace Thesis_Rillan_Trading
{
    public partial class userCon_supplierItem : UserControl
    {
        //Variables
        public MySqlConnection conn;
        public MySqlCommand command;
        public MySqlDataAdapter adapter;
        public DataTable dataTable;

        string query;
        int supp_id;

        List<int> itemIDs = new List<int> { };

        bool modeChecker = false;

        public userCon_supplierItem()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost; Database=rillan_trading; Uid=root; Pwd=root;");
        }

        private void supplierItem_Load(object sender, EventArgs e)
        {
            reset();
            
        }

        #region Button Functions

        private void btn_suppSearch_Click(object sender, EventArgs e)
        {
            
                try
                {
                    conn.Open();
                    adapter = new MySqlDataAdapter("SELECT supp_name FROM supplier" +
                        " WHERE supp_name LIKE '" + tbox_suppSearch.Text + "%' ", conn);
                    dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgv_supplierList.DataSource = dataTable;
                    conn.Close();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
            
        }



        #endregion
        
        #region Data Grid View Functions

        // Load table for supply
        private void supplierTableLoad()
        {
            try
            {
                conn.Open();
                adapter = new MySqlDataAdapter("(SELECT supp_id, supp_name FROM supplier)", conn);
                dataTable = new DataTable();
                adapter.Fill(dataTable);

                foreach (DataRow item in dataTable.Rows)
                {
                    int n = dgv_supplierList.Rows.Add();
                    dgv_supplierList.Rows[n].Cells[0].Value = item[0].ToString(); // supplier ID
                    dgv_supplierList.Rows[n].Cells[1].Value = item[1].ToString(); // supplier Name
                }

                conn.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }

        }

        private void productTableLoad()
        {
            if (modeChecker == true) // assignment mode
            {
                try
                {
                    conn.Open();
                    adapter = new MySqlDataAdapter("SELECT i.item_id, i.item_code, i.item_desc, b.item_brand, c.item_category " +
                        "FROM item i INNER JOIN item_brand b ON i.item_brand_fk = b.item_brand_id " +
                        "INNER JOIN item_category c ON i.item_category_fk = c.item_categ_id", conn);
                    dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    foreach (DataRow item in dataTable.Rows)
                    {
                        int n = dgv_itemList.Rows.Add();
                        dgv_itemList.Columns[0].Visible = true;
                        dgv_itemList.Rows[n].Cells[0].Value = false;
                        dgv_itemList.Rows[n].Cells[1].Value = item[0].ToString(); // item ID
                        dgv_itemList.Rows[n].Cells[2].Value = item[1].ToString(); // item Code
                        dgv_itemList.Rows[n].Cells[3].Value = item[2].ToString(); // item desc
                        dgv_itemList.Rows[n].Cells[4].Value = item[3].ToString(); // item brand
                        dgv_itemList.Rows[n].Cells[5].Value = item[4].ToString(); // item category
                    }

                    conn.Close();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
            }
        }

        private void dgv_supplierList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_supplierList.SelectedCells.Count > 0)
            {
                supp_id = int.Parse(dgv_supplierList.SelectedCells[0].Value.ToString());
            }
            
            if (modeChecker == false) // find mode; meaning the user wants to check all list items of the specified supplier
            {
                dgv_itemList.Rows.Clear();
                try
                {
                    conn.Open();
                    adapter = new MySqlDataAdapter("SELECT ITEM_ID, ITEM_CODE, ITEM_DESC, ITEM_BRAND, ITEM_CATEGORY FROM ITEM " +
                        "INNER JOIN ITEM_SUPPLIER ON ITEM_ID_FK = ITEM_ID " +
                        "INNER JOIN SUPPLIER ON SUPP_ID = SUPP_ID_FK  " +
                        "INNER JOIN ITEM_BRAND ON ITEM_BRAND_ID = ITEM_BRAND_FK " +
                        "INNER JOIN ITEM_CATEGORY ON ITEM_CATEG_ID = ITEM_CATEGORY_FK WHERE SUPP_ID = '" + supp_id + "'", conn);
                    dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    foreach (DataRow item in dataTable.Rows)
                    {
                        int n = dgv_itemList.Rows.Add();
                        dgv_itemList.Columns[0].Visible = false;
                        dgv_itemList.Rows[n].Cells[0].Value = false;
                        dgv_itemList.Rows[n].Cells[1].Value = item[0].ToString(); // item ID
                        dgv_itemList.Rows[n].Cells[2].Value = item[1].ToString(); // item Code
                        dgv_itemList.Rows[n].Cells[3].Value = item[2].ToString(); // item desc
                        dgv_itemList.Rows[n].Cells[4].Value = item[3].ToString(); // item brand
                        dgv_itemList.Rows[n].Cells[5].Value = item[4].ToString(); // item category
                    }
                    conn.Close();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
            }
            
        }

        private void dgv_itemList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((bool)dgv_itemList.SelectedRows[0].Cells[0].Value == false)
            {
                dgv_itemList.SelectedRows[0].Cells[0].Value = true;
            }
            else
            {
                dgv_itemList.SelectedRows[0].Cells[0].Value = false;
            }
        }


        #endregion

        private void btn_assignItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow selectedRow in dgv_itemList.Rows)
            {
                if (Convert.ToBoolean(selectedRow.Cells[0].Value))
                {
                   
                    itemIDs.Add(int.Parse(dgv_itemList.SelectedRows[0].Cells[1].Value.ToString()));
                    
                }
            }



            try
            {
                conn.Open();
                if (MessageBox.Show("Are you sure you want to add this item to this supplier?", "Add item to supplier", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (int id in itemIDs)
                    {
                        command = conn.CreateCommand();
                        command.CommandText = "INSERT INTO item_supplier (supp_id_fk, item_id_fk) VALUES ('" + supp_id + "','" + id + "' )";
                        command.ExecuteNonQuery();
                    }
                        
                    MessageBox.Show("Successfully added an item to supplier");

                }
                conn.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void btn_findMode_Click(object sender, EventArgs e)
        {
            // 
            dgv_itemList.Rows.Clear();
            dgv_supplierList.Rows.Clear();

            tbox_suppSearch.Enabled = true;
            btn_suppSearch.Enabled = true;

            modeChecker = false;

            supplierTableLoad();
        }

        private void btn_assignmentMode_Click(object sender, EventArgs e)
        {
            dgv_itemList.Rows.Clear();
            dgv_supplierList.Rows.Clear();

            btn_assignItem.Enabled = true;
            btn_cancel.Enabled = true;
            tbox_suppSearch.Enabled = true;
            tbox_itemSearch.Enabled = true;
            btn_addItem.Enabled = true;
            btn_suppSearch.Enabled = true;

            modeChecker = true;

            supplierTableLoad();
            productTableLoad();
        }

        private void reset()
        {
            tbox_suppSearch.Enabled = false;
            btn_assignItem.Enabled = false;
            btn_cancel.Enabled = false;
            btn_addItem.Enabled = false;
            btn_suppSearch.Enabled = false;
        }

        private void btn_addItem_Click(object sender, EventArgs e)
        {
            viewForm_items itms = new viewForm_items();
            DialogResult dr = itms.ShowDialog(this);

            if (dr == DialogResult.Cancel)
            {
                itms.Close();
            }
            else if (dr == DialogResult.OK)
            {
                itms.refSuppName = tbox_supplier.Text;
                po_ID = fPO_List.refPOID;
                fPO_List.Close();

                dgv_orderLine.Rows.Clear();
                PODetailsLoad();
            }

        }
    }
}
