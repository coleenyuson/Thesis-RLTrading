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
    public partial class addForm_Item : Form
    {
        // Variables
        public MySqlConnection conn;
        public MySqlCommand command;
        public MySqlDataAdapter adapter;
        public DataTable dataTable;

        public string query;

        public int ref_itemID { get; set; }
        public String ref_itemCode { get; set; }
        public String ref_itemDesc { get; set; }
        public String ref_itemBrand { get; set; }
        public String ref_itemCateg { get; set; }
        public String ref_itemUnit { get; set; }
        public float ref_minWhseLvl { get; set; }
        public float ref_minStoreLvl { get; set; }
        public Boolean ref_modeChecker { get; set; }

        public addForm_Item()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost; Database=rillan_trading; Uid=root; Pwd=root;");
        }

        private void addForm_Item_Load(object sender, EventArgs e)
        {
            cmboxBrand_LoadItems();
            cmboxCategory_LoadItems();
            
            if (ref_modeChecker == true) // Update Mode
            {
                setItemDetailsToFields();

                btn_addNewItem.Visible = false;
                btn_Update.Visible = true;
            }
            else if (ref_modeChecker == false) // Create Mode
            {
                btn_addNewItem.Visible = true;
                btn_Update.Visible = false;
            }
        }

        #region Defined Functions
        private void setItemDetailsToFields()
        {
            tbox_itemCode.Text = ref_itemCode;
            tbox_itemDesc.Text = ref_itemDesc;
            cmbox_itemBrand.SelectedItem = ref_itemBrand;
            cmbox_itemCategory.SelectedItem = ref_itemCateg;
            cmbox_itemUnit.SelectedItem = ref_itemUnit;
            tbox_minWhseLvl.Text = ref_minWhseLvl.ToString();
            tbox_minStoreLvl.Text = ref_minStoreLvl.ToString();
        }

        private void cmboxBrand_LoadItems()
        {
            cmbox_itemBrand.Items.Add("");
            //cmbox_itemBrand.Items.Add("Define New Brand...");

            // Loads item brands to combo box
            try
            {
                conn.Open();
                query = "SELECT item_brand FROM item_brand;";
                command = new MySqlCommand(query, conn);
                MySqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    cmbox_itemBrand.Items.Add(dr[0]);
                }

                conn.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }

        }

        private void cmboxCategory_LoadItems()
        {
            cmbox_itemCategory.Items.Add("");
            //cmbox_itemCategory.Items.Add("Define New Category...");

            // Loads item categories to combo box
            try
            {
                conn.Open();
                query = "SELECT item_category FROM item_category;";
                command = new MySqlCommand(query, conn);
                MySqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    cmbox_itemCategory.Items.Add(dr[0]);
                }

                conn.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
                conn.Close();
            }
        }

        public void addNewItem()
        {
            int brandID = getItemBrandID();
            int categID = getItemCategID();

            if (MessageBox.Show("Are you sure you want to add this new item?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

               if (tbox_itemCode.Text != "" || tbox_itemDesc.Text != "" || cmbox_itemBrand.Text != "" || cmbox_itemCategory.Text != "" || cmbox_itemUnit.Text != "" ||
               tbox_minStoreLvl.Text != "" || tbox_minWhseLvl.Text != "")
                {
                    try
                    {
                        conn.Open();
                        MySqlCommand comm = new MySqlCommand("SELECT * FROM item " +
                            " WHERE item_desc = '" + tbox_itemDesc.Text + "' AND item_brand_fk = '" + brandID + "' AND item_category_fk = '" + categID + "' AND item_unit = '" + cmbox_itemUnit.Text + "'; ", conn);
                        MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                        DataTable dt = new DataTable();
                        adp.Fill(dt);

                        if (dt.Rows.Count == 1)
                        {
                            MessageBox.Show("This item is already in the database.");
                        }
                        else if (dt.Rows.Count == 0)
                        {
                            command = conn.CreateCommand();
                            command.CommandText = "INSERT INTO item (item_code, item_desc, item_brand_fk, item_category_fk, item_unit, item_minWhseLvl, item_minStoreLvl) " +
                                " VALUES ('" + tbox_itemCode.Text + "','" + tbox_itemDesc.Text + "', '" + brandID + "', '" + categID + "', '" + cmbox_itemUnit.Text + "', '" + tbox_minWhseLvl.Text + "', '" + tbox_minStoreLvl.Text + "')";
                            command.ExecuteNonQuery();

                            MessageBox.Show("Successfully added the item!");
                        }
                        conn.Close();
                    }
                    catch (Exception x)
                    {
                        MessageBox.Show(x.ToString());
                        conn.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Please make sure all fields have input.");
                }
            }
            
        }

        private int getItemBrandID()
        {
            int brand_id = 0;

            try
            {
                query = "SELECT item_brand_id FROM item_brand WHERE item_brand = '" + cmbox_itemBrand.Text + "';";
                command = new MySqlCommand(query, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                if (dt.Rows.Count == 1) // this means that the query returned a data
                {
                    // Assigns the value from database to int variable 'brand_id'
                    brand_id = int.Parse(dt.Rows[0]["item_brand_id"].ToString());
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }

            return brand_id;
        }

        private int getItemCategID()
        {
            int categ_id = 0;

            try
            {
                query = "SELECT item_categ_id FROM item_category WHERE item_category = '" + cmbox_itemCategory.Text + "';";
                command = new MySqlCommand(query, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                if (dt.Rows.Count == 1) // this means that the query returned a data
                {
                    // Assigns the value from database to int variable 'brand_category'
                    categ_id = int.Parse(dt.Rows[0]["item_categ_id"].ToString());
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
                conn.Close();
            }

            return categ_id;
        }

        public void updateItemDetails()
        {

            int brandID = getItemBrandID();
            int categID = getItemCategID();


            if (tbox_itemCode.Text != "" || tbox_itemDesc.Text != "" || cmbox_itemBrand.Text != "" || cmbox_itemCategory.Text != "" || cmbox_itemUnit.Text != "" ||
               tbox_minStoreLvl.Text != "" || tbox_minWhseLvl.Text != "")
            {
                try
                {
                    conn.Open();
                    command = conn.CreateCommand();
                    command.CommandText = "UPDATE item SET item_code = '" + tbox_itemCode.Text + "', item_desc = '" + tbox_itemDesc.Text + "', " +
                        " item_brand_fk = '" + brandID + "', item_category_fk = '" + categID + "', item_unit = '" + cmbox_itemUnit.Text + "', " +
                        " item_minWhseLvl = '" + float.Parse(tbox_minWhseLvl.Text) + "', item_minStoreLvl = '" + float.Parse(tbox_minStoreLvl.Text) + "' " +
                        " WHERE item_id = '" + ref_itemID + "' ";
                    command.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("You have successfully updated the item's details.");
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Please make sure all fields have input.");
            }
          
        }

        private void clearFields()
        {
            tbox_itemCode.Text = "";
            tbox_itemDesc.Text = "";
            cmbox_itemBrand.SelectedItem = "";
            cmbox_itemCategory.SelectedItem = "";
            cmbox_itemUnit.SelectedItem = "";
            tbox_minWhseLvl.Text = "";
            tbox_minStoreLvl.Text = "";
        }

        #endregion


        private void tbox_minWhseLvl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)Keys.Back) //The  character represents a backspace
            {
                e.Handled = false; //Do not reject the input
            }
            else
            {
                e.Handled = true; //Reject the input
            }
        }


    }
}
