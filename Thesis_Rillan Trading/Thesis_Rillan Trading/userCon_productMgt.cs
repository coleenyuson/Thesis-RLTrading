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
    public partial class userCon_productMgt : UserControl
    {
        // Variables 
        public MySqlConnection conn;
        public MySqlCommand command;
        public MySqlDataAdapter adapter;
        public DataTable dataTable;
        int item_id, brand_id, categ_id;
        string itemCode, itemDesc, brand, categ;
        float sellingPrice;

        public userCon_productMgt()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost; Database=rillan_trading; Uid=root; Pwd=root;");
        }

        private void productMgt_Load(object sender, EventArgs e)
        {
            // Loads data from database
            productTableLoad();

            // Shows Save and Delete button while hiding Update and Cancel buttons
            btn_Update.Visible = false;
            btn_Cancel.Visible = false;

            // Loads item brands to combo box
            try
            {
                conn.Open();
                query = "SELECT item_brand FROM item_brand;";
                command = new MySqlCommand(query, conn);
                MySqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    cmbBox_itemBrand.Items.Add(dr[0]);
                }

                conn.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }

            // Loads item categories to combo box
            try
            {
                conn.Open();
                query = "SELECT item_category FROM item_category;";
                command = new MySqlCommand(query, conn);
                MySqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    cmbBox_itemCateg.Items.Add(dr[0]);
                }

                conn.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
                conn.Close();
            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

        }

        // - - Buttons - -
        private void btn_Save_Click(object sender, EventArgs e)
        {
            addProduct();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            updateProduct();

            // shows save and delete button
            btn_Save.Visible = true;
            btn_delete.Visible = true;

            // hides update and cancel button
            btn_Update.Visible = false;
            btn_Cancel.Visible = false;

        }

        // - - Data Grid Methods - - 
        private void dataGV_prodList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Do you want to edit this product's details?", "Edit Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                item_id = int.Parse(dataGV_prodList.SelectedRows[0].Cells[0].Value.ToString());
                tbox_itemCode.Text = dataGV_prodList.SelectedRows[0].Cells[1].Value.ToString();
                tbox_itemDesc.Text = dataGV_prodList.SelectedRows[0].Cells[2].Value.ToString();
                cmbBox_itemBrand.Text = dataGV_prodList.SelectedRows[0].Cells[3].Value.ToString();
                cmbBox_itemCateg.Text = dataGV_prodList.SelectedRows[0].Cells[4].Value.ToString();

                //Shows update and cancel button
                btn_Update.Visible = true;
                btn_Cancel.Visible = true;

                // Hides save and delete button
                btn_Save.Visible = false;
                btn_delete.Visible = false;
                //String i = "asd" + supp_id;
                
            }
        }
        
        // - - Defined Functions - - 

        string query;

        // Load Product Table to Data Grid
        private void productTableLoad()
        {
            try
            {
                conn.Open();
                query = "SELECT i.item_id, i.item_code, i.item_desc, b.item_brand, c.item_category FROM item i " +
                    " INNER JOIN item_brand b ON i.item_brand_fk = b.item_brand_id " +
                    " INNER JOIN item_category c ON i.item_category_fk = c.item_categ_id;";
                command = new MySqlCommand(query, conn);

                adapter = new MySqlDataAdapter(command);
                dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGV_prodList.DataSource = dataTable;
                conn.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
                conn.Close();
            }

            dataGV_prodList.Columns["item_id"].Visible = false;
            dataGV_prodList.Columns["item_code"].HeaderText = "Item Code";
            dataGV_prodList.Columns["item_desc"].HeaderText = "Description";
            dataGV_prodList.Columns["item_brand"].HeaderText = "Brand";
            dataGV_prodList.Columns["item_category"].HeaderText = "Category";
        }

        // - - Add New Item - -
        private void addProduct()
        {
            //Validation - - if either of the fields do not contain an input, it will not proceed on adding the item to database
            if (string.IsNullOrWhiteSpace(tbox_itemCode.Text.ToString()) || string.IsNullOrWhiteSpace(tbox_itemDesc.Text.ToString()) || string.IsNullOrWhiteSpace(cmbBox_itemBrand.Text.ToString()) ||
                string.IsNullOrWhiteSpace(cmbBox_itemCateg.Text.ToString()))
            {
                MessageBox.Show("Please make sure all fields have inputs.");
            }
            else
            {
                // Assigns the values from text boxes and combo boxes to their respective variables
                itemCode = tbox_itemCode.Text;
                itemDesc = tbox_itemDesc.Text;
                brand = cmbBox_itemBrand.Text;
                categ = cmbBox_itemCateg.Text;

                try
                {
                    conn.Open();

                    //Inserting  values to MySql item table
                    MySqlCommand DatabaseCommand = conn.CreateCommand();
                    DatabaseCommand.CommandText = "INSERT INTO item (item_code, item_desc, item_brand_fk, item_category_fk) " +
                        " VALUES ('" + itemCode + "','" + itemDesc + "','" + getItemBrandID() + "','" + getItemCategID() + "')";
                    if (MessageBox.Show("Are you sure you want to add this item to the database?", "Add Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DatabaseCommand.ExecuteNonQuery();
                        conn.Close();
                        conn.Dispose();

                        
                        MessageBox.Show("Successfully added an supplier");
                        productTableLoad();
                        fieldsReset();
                    }
                    
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
                
            }
        }

        // - - Update Product Details - -
        private void updateProduct() //edit function
        {
            try
            {
            
                String q = "UPDATE item SET item_code = '" + itemCode + "', item_desc = '" + itemDesc + "',  item_brand_fk = '" + getItemBrandID() + "', item_category_fk = '" + getItemCategID() + "'  WHERE item_id = '" + item_id + "' ";

                conn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(q, conn);
                int count = adapter.SelectCommand.ExecuteNonQuery();

                if (count >= 1)
                {
                    MessageBox.Show("Employee successfully Updated!");
                }
                conn.Close();

                productTableLoad();
                fieldsReset();
                btn_Save.Visible = true;
                btn_delete.Visible = true;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
            
        }
        
        // - - Gets the equivalent item brand ID of the item brand string - - 
        private int getItemBrandID()
        {
            try
            {
                query = "SELECT * FROM item_brand WHERE item_brand = '" + brand + "';";
                command = new MySqlCommand(query, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                if (dt.Rows.Count == 1) // this means that the query returned a data
                {
                    // Assigns the value from database to int variable 'brand_id'
                    brand_id = int.Parse(dt.Rows[0]["item_brand_id"].ToString());
                }
                else
                {
                    // In this block, the function should be adding the new text to database and then gets its item brand ID
                    //addNewItemBrand();
                }

                
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
                conn.Close();
            }

            return brand_id;
        }

        // - - Gets the equivalent item category ID of the item category string - - 
        private int getItemCategID()
        {
            try
            {
                query = "SELECT * FROM item_category WHERE item_category = '" + categ + "';";
                command = new MySqlCommand(query, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    // Assigns the value from database to int variable 'categ_id'
                    categ_id = int.Parse(dt.Rows[0]["item_categ_id"].ToString());
                }
                else
                {
                    // In this block, the function should be adding the new text to database and then gets its item category ID
                    //addNewItemCategory();
                }

            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
                conn.Close();
            }

            return categ_id;
        }

        private int addNewItemBrand()
        {
            try
            {
                
                //Inserting  values to MySql item table
                MySqlCommand DatabaseCommand = conn.CreateCommand();
                DatabaseCommand.CommandText = "INSERT INTO item_brand (item_brand) VALUES ('" + brand + "')";

                query = "SELECT * FROM item_brand WHERE '" + brand + "' = item_brand;";
                command = new MySqlCommand(query, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    brand_id = int.Parse(dt.Rows[0]["item_brand_id"].ToString());
                }

            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }

            return brand_id;
        }

        private int addNewItemCategory()
        {
            try
            {
                //Inserting  values to MySql item table
                MySqlCommand DatabaseCommand = conn.CreateCommand();
                DatabaseCommand.CommandText = "INSERT INTO item_category (item_category) VALUES ('" + categ + "')";

                query = "SELECT * FROM item_category WHERE '" + categ + "' = item_category;";
                command = new MySqlCommand(query, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    categ_id = int.Parse(dt.Rows[0]["item_categ_id"].ToString());
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }

            return categ_id;
        }

        private void fieldsReset()
        { 
            tbox_itemCode.Text = "";
            tbox_itemDesc.Text = "";
            cmbBox_itemBrand.Text = "";
            cmbBox_itemCateg.Text = "";
        }
    }
}

