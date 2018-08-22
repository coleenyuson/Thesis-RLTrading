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
    public partial class formItemSupplier : Form
    {

        //Variables
        public MySqlConnection conn;
        public MySqlCommand command;
        public MySqlDataAdapter adapter;
        public DataTable dataTable;

        public Form refSupp { get; set; }

        public formItemSupplier()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost; Database=rillan_trading; Uid=root; Pwd=root;");
        }

        private void formItemSupplier_Load(object sender, EventArgs e)
        {
            itemSupplierLoad();
            //This is for the autocomplete search for supplier name 
            try
            {
                command = new MySqlCommand("SELECT supp_name FROM supplier", conn);
                conn.Open();
                adapter = new MySqlDataAdapter(command);
                dataTable = new DataTable();
                adapter.Fill(dataTable);
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    col.Add(Convert.ToString(row[0]));
                }
                tbx_supplier.AutoCompleteSource = AutoCompleteSource.CustomSource;
                tbx_supplier.AutoCompleteCustomSource = col;
                tbx_supplier.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

                conn.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        //This will display all items with their corresponding supplier in the datagridview
        private void itemSupplierLoad()
        {
            try
            {
                conn.Open();
                adapter = new MySqlDataAdapter("SELECT SUPP_NAME, ITEM_CODE, ITEM_DESC, ITEM_BRAND, ITEM_CATEGORY FROM ITEM " +
                    "INNER JOIN ITEM_SUPPLIER ON ITEM_ID_FK = ITEM_ID " +
                    "INNER JOIN SUPPLIER ON SUPP_ID = SUPP_ID_FK " +
                    "INNER JOIN ITEM_BRAND ON ITEM_BRAND_ID = ITEM_BRAND_FK " +
                    "INNER JOIN ITEM_CATEGORY ON ITEM_CATEG_ID = ITEM_CATEGORY_FK", conn);
                dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGV_item.DataSource = dataTable;
                conn.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }

            btn_addItem.Enabled = false;

            dataGV_item.Columns["supp_name"].HeaderText = "Supplier Name";
            dataGV_item.Columns["item_code"].HeaderText = "Item Code";
            dataGV_item.Columns["item_desc"].HeaderText = "Item Description";
            dataGV_item.Columns["ITEM_BRAND"].HeaderText = "Item Brand";
            dataGV_item.Columns["ITEM_CATEGORY"].HeaderText = "Item Category";

        }

       

   
        
        private void reset()
        {
            btn_search.Visible = false;
            tbx_itemSearch.Visible = false;
            btn_cancel.Visible = false;
            btn_addItem.Text = "Add Item";
            tbx_supplier.Text = "";

            itemSupplierLoad();
        }

        //This will get all the items data from the database and put it in the datagridview
        private void displayItem()
        {
            try
            {
                conn.Open();
                adapter = new MySqlDataAdapter("SELECT item_id, item_code, item_desc, item_brand, item_category, item_sellingPrice from item" +
                    " INNER JOIN ITEM_BRAND ON ITEM_BRAND_ID = ITEM_BRAND_FK" +
                    " INNER JOIN ITEM_CATEGORY ON ITEM_CATEG_ID = ITEM_CATEGORY_FK", conn);
                dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGV_item.DataSource = dataTable;
                conn.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
            dataGV_item.Columns["item_id"].Visible = false;
            dataGV_item.Columns["item_sellingPrice"].HeaderText = "Selling Price";
            dataGV_item.Columns["item_code"].HeaderText = "Item Code";
            dataGV_item.Columns["item_desc"].HeaderText = "Item Description";
            dataGV_item.Columns["ITEM_BRAND"].HeaderText = "Item Brand";
            dataGV_item.Columns["ITEM_CATEGORY"].HeaderText = "Item Category";
        }

        //Search function for items


        //This will add an item to its corresponding supplier
        private void addItemSupplier()
        {
            conn.Open(); // Connection opened

            if (checkExistense())
            {
                MessageBox.Show("Exist!");
            }
            else
            {
                //Inserting  values to MySql Emp table
                command = conn.CreateCommand();
                command.CommandText = "INSERT INTO item_supplier (supp_id_fk, item_id_fk) VALUES ('" + getSuppFk() + "','" + item_id + "' )";
                if (MessageBox.Show("Are you sure you want to add this item to this supplier?", "Add item to supplier", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Successfully added an item to supplier");
                }
            }

            conn.Close();
            reset();
        }

        int supp_id;
        private int getSuppFk()//This function will get the id of the supplier for the create function
        {
            try
            {
                // Get data from DB
                MySqlCommand comm = new MySqlCommand("SELECT supp_id FROM supplier WHERE supp_name = '" + tbx_supplier.Text + "' ", conn);
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
                MessageBox.Show(x.ToString());
                return supp_id;
            }
        }

        int item_id;
       
        private Boolean checkExistense()
        {
            // Connection to Database
            // Connection opened

            // Get data from DB
            try
            {
                MySqlCommand comm = new MySqlCommand("SELECT item_code, supp_name from item" +
                    " INNER JOIN ITEM_SUPPLIER ON ITEM_ID_FK = ITEM_ID" +
                    " INNER JOIN SUPPLIER ON SUPP_ID = SUPP_ID_FK" +
                    " WHERE supp_id_fk = '" + getSuppFk() + "' AND item_id_fk = '" + item_id + "'; ", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                if (dt.Rows.Count == 1) // DB returned 1 row  
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
                return false;
            }

        }

        private void tbx_supplier_TextChanged_1(object sender, EventArgs e)
        {
            if (tbx_supplier.Text == "")
            {
                itemSupplierLoad();
            }
            else
            {
                try
                {
                    conn.Open();
                    adapter = new MySqlDataAdapter("SELECT SUPP_NAME, ITEM_CODE, ITEM_DESC, ITEM_BRAND, ITEM_CATEGORY FROM ITEM " +
                        "INNER JOIN ITEM_SUPPLIER ON ITEM_ID_FK = ITEM_ID " +
                        "INNER JOIN SUPPLIER ON SUPP_ID = SUPP_ID_FK " +
                        "INNER JOIN ITEM_BRAND ON ITEM_BRAND_ID = ITEM_BRAND_FK " +
                        "INNER JOIN ITEM_CATEGORY ON ITEM_CATEG_ID = ITEM_CATEGORY_FK WHERE supp_name = '" + tbx_supplier.Text + "'", conn);
                    dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGV_item.DataSource = dataTable;
                    conn.Close();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
            }

            if (this.tbx_supplier.Text == "")
            {
                btn_addItem.Enabled = false;
            }
            else
            {
                btn_addItem.Enabled = true;
            }
        }

        private void dataGV_item_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //Gets the item id for create function
            if (btn_addItem.Enabled == true)
            {
                try
                {
                    item_id = int.Parse(dataGV_item.SelectedRows[0].Cells[0].Value.ToString());
                    btn_addItem.Text = "Save";
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
            }

        }

        private void btn_search_Click_1(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                adapter = new MySqlDataAdapter("SELECT item_code, item_desc, item_brand, item_category, item_sellingPrice from item" +
                    " INNER JOIN ITEM_BRAND ON ITEM_BRAND_ID = ITEM_BRAND_FK" +
                    " INNER JOIN ITEM_CATEGORY ON ITEM_CATEG_ID = ITEM_CATEGORY_FK WHERE item_code LIKE '" + tbx_itemSearch.Text + "%'", conn);
                dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGV_item.DataSource = dataTable;
                conn.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void btn_cancel_Click_1(object sender, EventArgs e)
        {
            reset();
        }

        private void btn_addItem_Click(object sender, EventArgs e)
        {
            btn_search.Visible = true;
            tbx_itemSearch.Visible = true;
            btn_cancel.Visible = true;

            displayItem();

            if (btn_addItem.Text == "Save")
            {
                addItemSupplier();
                checkExistense();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formSupplier fSupp = new formSupplier();
            fSupp.refItemSupp = this;
            fSupp.Show();
            this.Hide();
        }

        private void tbx_itemSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
