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

        int supp_id;

        List<int> itemIDs = new List<int> { };
        List<float> prices = new List<float> { };
        List<string> existingItems = new List<string> { };
        List<string> newItems = new List<string> { };
        List<float> currentPrice = new List<float> { };
        List<float> newPrice = new List<float> { };

        public List<classItems> itemValues { get; set; }

        bool modeChecker = false;

        string itm_exist = "";
        string res_itm_exist = "";
        string itm_new = "";
        string res_itm_new = "";

        public userCon_supplierItem()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost; Database=rillan_trading; Uid=root; Pwd=root;");
        }

        private void supplierItem_Load(object sender, EventArgs e)
        {
            btn_Update.Visible = false;
            newItems.Clear();
            existingItems.Clear();
            reset();
        }

        #region Button Functions

        private void btn_viewMode_Click(object sender, EventArgs e)
        {
            dgv_itemList.Rows.Clear();
            dgv_supplierList.Rows.Clear();

            tbox_suppSearch.Enabled = true;
            btn_suppSearch.Enabled = true;
            btn_assignItem.Enabled = false;
            btn_addItem.Enabled = false;
            btn_removeItem.Enabled = false;
            btn_cancel.Enabled = false;
            btn_Update.Visible = false;

            modeChecker = false;

            supplierTableLoad();
        }

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

        private void btn_assignItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to assign the item/s to this supplier?", "Add item to supplier", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (checkPriceCellValues() > 0) // true - one or more cells have empty cells
                    {
                        MessageBox.Show("Please make sure to enter the price values of the items specified.");
                    }
                    else // false - all cells have values
                    {
                        itemAssignToList();

                        if (!checkExistenceOfItems()) // false - in the selection of items there are no items that were already assigned
                        {
                            MessageBox.Show("Items successfully assigned to supplier!");
                        }
                        else  // true - in the selection of items there were items that were already assigned
                        {
                            printExistingItems();
                            printNewItems();
                        }

                    }
                }

                newItems.Clear();
                existingItems.Clear();
                dgv_itemList.Rows.Clear();
                reset();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
                conn.Close();
            }
        }

        private void btn_assignmentMode_Click(object sender, EventArgs e)
        {
            dgv_itemList.Rows.Clear();
            dgv_supplierList.Rows.Clear();

            btn_assignItem.Enabled = true;
            btn_cancel.Enabled = true;
            tbox_suppSearch.Enabled = true;
            btn_addItem.Enabled = true;
            btn_removeItem.Enabled = true;
            btn_suppSearch.Enabled = true;
            btn_Update.Visible = false;

            modeChecker = true;

            supplierTableLoad();
        }

        private void btn_addItem_Click(object sender, EventArgs e)
        {
            viewForm_items fviewItems = new viewForm_items();
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

        // ?? - not all items will be removed
        private void btn_removeItem_Click(object sender, EventArgs e)
        {
            if (modeChecker) // in assignment mode
            {
                for (int i = 0; i <= dgv_itemList.Rows.Count; i++)
                {
                    if ((bool)dgv_itemList.Rows[i].Cells[4].Value == true)
                    {
                        dgv_itemList.Rows.RemoveAt(dgv_itemList.Rows[i].Index);
                    }
                }
            }
            else if (!modeChecker)
            {
                if (MessageBox.Show("Are you sure you want to unassign the item/s of this supplier?", "Remove Item from Supplier", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show("Delete function not yet available.");
                }
            }

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            getNewItemPrice();

            if (MessageBox.Show("Do you want to update the item price?", "Update Item Price Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                for (int i =0; i <dgv_itemList.Rows.Count; i++)
                {
                    if (currentPrice[i] != newPrice[i])
                    {
                        try
                        {
                            conn.Open();
                            command = conn.CreateCommand();
                            command.CommandText = "UPDATE item_supplier SET selling_price = '"+ newPrice[i] + "' " +
                                " WHERE item_id_fk = '" + int.Parse(dgv_itemList.Rows[i].Cells[0].Value.ToString()) + "' " +
                                " AND supp_id_fk = '" + supp_id + "'";
                            command.ExecuteNonQuery();
                            conn.Close();
                           
                        }
                        catch (Exception x)
                        {
                            MessageBox.Show(x.ToString());
                            conn.Close();
                        }
                    }
                }
            }
            MessageBox.Show("Item Prices succesffully updated!");
            dgv_itemList.Refresh();
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
        
        private void dgv_supplierList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            supp_id = int.Parse(dgv_supplierList.SelectedCells[0].Value.ToString());

            if (modeChecker == false) // find mode; meaning the user wants to check all list items of the specified supplier
            {
                dgv_itemList.Rows.Clear();
                try
                {
                    conn.Open();
                    adapter = new MySqlDataAdapter("SELECT ITEM_ID, ITEM_CODE, ITEM_DESC, FORMAT(SELLING_PRICE,2) FROM ITEM " +
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
                        dgv_itemList.Rows[n].Cells[0].Value = item[0].ToString();
                        dgv_itemList.Rows[n].Cells[1].Value = item[1].ToString(); // item code
                        dgv_itemList.Rows[n].Cells[2].Value = item[2].ToString(); // item desc
                        dgv_itemList.Rows[n].Cells[3].Value = item[3].ToString(); // selling price
                    }
                    conn.Close();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
                getCurrentItemPrice();
            }

        }

        private void dgv_itemList_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void dgv_itemList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((bool)dgv_itemList.Rows[0].Cells[4].Value == false)
            {
                dgv_itemList.Rows[0].Cells[4].Value = true;
            }
            else
            {
                dgv_itemList.Rows[0].Cells[4].Value = false;
            }

        }

        private void dgv_itemList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!modeChecker)
            {
                btn_Update.Visible = true;
            }
        }
        
        #endregion

        #region Defined Functions

        private void reset()
        {
            tbox_suppSearch.Enabled = false;
            btn_assignItem.Enabled = false;
            btn_cancel.Enabled = false;
            btn_addItem.Enabled = false;
            btn_suppSearch.Enabled = false;

        }

        private void reset_btnAssign()
        {

        }

        public void AddToGrid(List<classItems> val)
        {
            if (val != null)
            {
                foreach (classItems item in val)
                {
                    int n = dgv_itemList.Rows.Add();
                    dgv_itemList.Rows[n].Cells[0].Value = item.itemID;
                    dgv_itemList.Rows[n].Cells[1].Value = item.itemCode;
                    dgv_itemList.Rows[n].Cells[2].Value = item.itemDesc;
                    dgv_itemList.Rows[n].Cells[4].Value = false;
                }
            }
        }

        private Boolean checkExistenceOfItems()
        {
            try
            {
                bool _res = false;
                int _val = 0;
                conn.Open();

                for (int i = 0; i < dgv_itemList.Rows.Count; i++)
                {
                    MySqlCommand comm = new MySqlCommand("SELECT item_id_fk, item_desc FROM item_supplier" +
                               " INNER JOIN item ON item_id_fk = item_id " +
                               " WHERE supp_id_fk = '" + supp_id + "' AND item_id_fk = '" + itemIDs[i] + "' ", conn);
                    MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        existingItems.Add(dgv_itemList.Rows[i].Cells[2].Value.ToString());

                        _val += 1;
                    }
                    else if (dt.Rows.Count == 0)
                    {
                        command = conn.CreateCommand();
                        command.CommandText = "INSERT INTO item_supplier (supp_id_fk, item_id_fk, selling_price) VALUES ('" + supp_id + "','" + itemIDs[i] + "', '" + prices[i] + "')";
                        command.ExecuteNonQuery();
                        newItems.Add(dgv_itemList.Rows[i].Cells[2].Value.ToString());

                    }

                }

                if (_val == 0)
                {
                    _res = false;
                }
                else if (_val > 0)
                {
                    _res = true;

                }

                conn.Close();
                return _res;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
                conn.Close();
                return false;
            }
        }

        private void itemAssignToList()
        {
            for (int i = 0; i < dgv_itemList.Rows.Count; i++)
            {
                itemIDs.Add(int.Parse(dgv_itemList.Rows[i].Cells[0].Value.ToString()));
                prices.Add(float.Parse(dgv_itemList.Rows[i].Cells[3].Value.ToString()));
            }
        }

        private void assignItemToSupplier()
        {
            try
            {
                for (int i = 0; i < dgv_itemList.Rows.Count; i++)
                {

                    command = conn.CreateCommand();
                    command.CommandText = "INSERT INTO item_supplier (supp_id_fk, item_id_fk, selling_price) VALUES ('" + supp_id + "','" + itemIDs[i] + "', '" + prices[i] + "')";
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private int checkPriceCellValues()
        {
            int _val = 0;
            for (int i = 0; i < dgv_itemList.Rows.Count; i++)
            {
                if (dgv_itemList.Rows[i].Cells[3].Value.ToString() == String.Empty)
                {
                    _val += 1;
                }

            }
            return _val;
        }

        private void printExistingItems()
        {
            for (int i = 0; i < existingItems.Count; i++)
            {
                itm_exist = existingItems[i] + "\n ";
                res_itm_exist += itm_exist;
            }
            MessageBox.Show("The following items were already assigned to the supplier: " + "\n" + res_itm_exist);
        }

        private void printNewItems()
        {
            for (int i = 0; i < newItems.Count; i++)
            {
                itm_new = newItems[i] + "\n ";
                res_itm_new += itm_new;
            }
            if (res_itm_new == "" || res_itm_new == null)
            {
                MessageBox.Show("No new items added.");
            }
            else if (res_itm_new != "" || res_itm_new != null)
            {
                MessageBox.Show("New items were assigned to the supplier: " + "\n" + res_itm_new);
            }
        }
        
        private void getItemIDs ()
        {
            for (int i = 0; i < dgv_itemList.Rows.Count; i++)
            {
                itemIDs.Add(int.Parse(dgv_itemList.Rows[i].Cells[0].Value.ToString()));
            }
        }

        private void getCurrentItemPrice ()
        {
            for (int i=0; i < dgv_itemList.Rows.Count; i++)
            {
                currentPrice.Add(float.Parse(dgv_itemList.Rows[i].Cells[3].Value.ToString()));
            }
        }

        private void getNewItemPrice()
        {
            for (int i = 0; i < dgv_itemList.Rows.Count; i++)
            {
                newPrice.Add(float.Parse(dgv_itemList.Rows[i].Cells[3].Value.ToString()));
            }
        }
        #endregion


    } 
}
