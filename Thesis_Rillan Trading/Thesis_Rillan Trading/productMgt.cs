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
    public partial class productMgt : UserControl
    {
        // Variables 
        public MySqlConnection conn;
        public MySqlCommand command;
        public MySqlDataAdapter adapter;
        public DataTable dataTable;
        int item_id;
        string itemCode, itemDesc, brand, categ;
        float sellingPrice;

        public productMgt()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost; Database=rillan_trading; Uid=root; Pwd=root;");
        }

        private void productMgt_Load(object sender, EventArgs e)
        {
            productTableLoad();
            //MessageBox.Show(cmbBox_itemBrand.Items[0].ToString(), "Trial", MessageBoxButtons.OK);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

        }

        // - - Buttons - -
        private void btn_Save_Click(object sender, EventArgs e)
        {
            addProduct();
        }

        // - - Data Grid Methods - - 
        private void dataGV_prodList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string b, c, y;

            if (MessageBox.Show("Do you want to edit this product's details?", "Edit Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                item_id = int.Parse(dataGV_prodList.SelectedRows[0].Cells[0].Value.ToString());
                tbox_itemCode.Text = dataGV_prodList.SelectedRows[0].Cells[1].Value.ToString();
                tbox_itemDesc.Text = dataGV_prodList.SelectedRows[0].Cells[2].Value.ToString();

                b = dataGV_prodList.SelectedRows[0].Cells[3].Value.ToString();
                cmbBox_itemBrand.SelectedItem = cmbBox_itemBrand.FindString(b);

                c = dataGV_prodList.SelectedRows[0].Cells[4].Value.ToString();
                cmbBox_itemCateg.SelectedItem = cmbBox_itemCateg.FindString(c);
                
                tbox_sellingPrice.Text = dataGV_prodList.SelectedRows[0].Cells[5].Value.ToString();

                btn_delete.Text = "Cancel";
                btn_Save.Text = "Update";
                btn_delete.Visible = true;
                //String i = "asd" + supp_id;

            }
        }

       

        // - - Defined Functions - - 

        // - - Function: It will load the product data from database to the datagrid view
        private void productTableLoad()
        {
            try
            {
                conn.Open();
                command = new MySqlCommand("SELECT * FROM item", conn);

                adapter = new MySqlDataAdapter(command);
                dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGV_prodList.DataSource = dataTable;
                conn.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }

            dataGV_prodList.Columns["item_id"].Visible = false;
            dataGV_prodList.Columns["item_code"].HeaderText = "Item Code";
            dataGV_prodList.Columns["item_desc"].HeaderText = "Description";
            dataGV_prodList.Columns["item_brand"].HeaderText = "Brand";
            dataGV_prodList.Columns["item_category"].HeaderText = "Category";
            dataGV_prodList.Columns["item_sellingPrice"].HeaderText = "Selling Price";
        }

        // - - Function: Allows user to add an item
        private void addProduct()
        {
            //Validation - - if either of the fields do not contain an input, it will not proceed on adding the item to database
            if (string.IsNullOrWhiteSpace(tbox_itemCode.Text.ToString()) || string.IsNullOrWhiteSpace(tbox_itemDesc.Text.ToString()) || string.IsNullOrWhiteSpace(cmbBox_itemBrand.Text.ToString()) ||
                string.IsNullOrWhiteSpace(cmbBox_itemCateg.Text.ToString()) || string.IsNullOrWhiteSpace(tbox_sellingPrice.Text.ToString()))
            {
                MessageBox.Show("Please make sure all fields have inputs.");
            }
            else
            {
                itemCode = tbox_itemCode.Text;
                itemDesc = tbox_itemDesc.Text;
                brand = cmbBox_itemBrand.Text;
                categ = cmbBox_itemCateg.Text;
                sellingPrice = float.Parse(tbox_sellingPrice.Text);

                try
                {
                    conn.Open();

                    //Inserting  values to MySql Emp table
                    MySqlCommand DatabaseCommand = conn.CreateCommand();
                    DatabaseCommand.CommandText = "INSERT INTO item (item_code, item_desc, item_brand, item_category, item_sellingPrice) VALUES ('" + itemCode + "','" + itemDesc + "','" + brand + "','" + categ + "','" + sellingPrice + "')";
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

        private void updateProduct()
        {

        }

        private void fieldsReset()
        {
            tbox_itemCode.Text = "";
            tbox_itemDesc.Text = "";
            tbox_sellingPrice.Text = "";
            cmbBox_itemBrand.Text = "";
            cmbBox_itemCateg.Text = "";
        }
    }
}

