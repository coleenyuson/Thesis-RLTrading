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

        public userCon_supplierItem()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost; Database=rillan_trading; Uid=root; Pwd=root;");

            //Timer 
            Timer timer = new Timer();
           // timer.Interval = 1;
            timer.Tick += new EventHandler(timer_btn_Tick);
            timer.Enabled = true;
        }

        private void supplierItem_Load(object sender, EventArgs e)
        {
            supplierTableLoad();
            productTableLoad();

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

        #region Shortcut Key function
        private void timer_btn_Tick(object sender, EventArgs e)
        {
            if (F2_Pressed) // Find Mode
            {
                tbox_itemSearch.BackColor = Color.FromArgb(223, 228, 234);
                tbox_suppSearch.BackColor = Color.FromArgb(223, 228, 234);
                btn_assign.Enabled = false;
                btn_cancel.Enabled = false;

                // In find mode, when user clicks on a specified user, it will automatically select all the items pertaining to that of the supplier.
                /* If supplier is selected,
                 * supplier id must be identified
                 * this will be passed to the product table 
                 * display item-supplier table
                 * */
            }

            if (F3_Pressed) // Assign Mode
            {
                tbox_itemSearch.BackColor = Color.White;
                tbox_suppSearch.BackColor = Color.White;
                btn_assign.Enabled = true;
                btn_cancel.Enabled = true;
            }
        }

        /*private bool Control_Pressed
        {
            get
            {
                return Keyboard.IsKeyDown(Key.LeftCtrl) || Keyboard.IsKeyDown(Key.RightCtrl);
            }
        }*/

        private bool F2_Pressed
        {
            get
            {
                return Keyboard.IsKeyDown(Key.F2);
            }
        }
        private bool F3_Pressed
        {
            get
            {
                return Keyboard.IsKeyDown(Key.F3);
            }
        }

        #endregion

        #region Data Grid View Functions

        // Load table for supply
        private void supplierTableLoad ()
        {
            try
            {
                conn.Open();
                command = new MySqlCommand("(SELECT supp_id, supp_name FROM supplier)", conn);

                adapter = new MySqlDataAdapter(command);
                dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgv_supplierList.DataSource = dataTable;
                conn.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }

            dgv_supplierList.Columns["supp_id"].Visible = false;
            dgv_supplierList.Columns["supp_name"].HeaderText = "Supplier Name";
        }

        private void productTableLoad()
        {
            try
            {
                conn.Open();
                query = "SELECT i.item_id, i.item_code, i.item_desc, b.item_brand, c.item_category, i.item_sellingPrice FROM item i INNER JOIN item_brand b ON i.item_brand_fk = b.item_brand_id INNER JOIN item_category c ON i.item_category_fk = c.item_categ_id;";
                command = new MySqlCommand(query, conn);

                adapter = new MySqlDataAdapter(command);
                dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgv_itemList.DataSource = dataTable;
                conn.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
                conn.Close();
            }

            dgv_itemList.Columns["item_id"].Visible = false;
            dgv_itemList.Columns["item_code"].HeaderText = "Item Code";
            dgv_itemList.Columns["item_desc"].HeaderText = "Description";
            dgv_itemList.Columns["item_brand"].HeaderText = "Brand";
            dgv_itemList.Columns["item_category"].HeaderText = "Category";
            dgv_itemList.Columns["item_sellingPrice"].HeaderText = "Selling Price";
        }



        #endregion

        private void dgv_supplierList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_supplierList.SelectedCells.Count > 0)
            {
                supp_id = int.Parse(dgv_supplierList.SelectedCells[0].Value.ToString());
            }
        }

        private void dgv_supplierList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
