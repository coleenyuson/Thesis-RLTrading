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
    public partial class customerProfile : UserControl
    {

        public MySqlConnection conn;
        public MySqlCommand command;
        public MySqlDataAdapter adapter;
        public DataTable dataTable;

        string query, name, contactPerson, address, contactNum, faxNum;
        int cust_id;

        public customerProfile()
        {
            conn = new MySqlConnection("Server=localhost; Database=rillan_trading; Uid=root; Pwd=root;");
            InitializeComponent();
        }

        private void customerProfile_Load(object sender, EventArgs e)
        {
            customerTableLoad();
            btn_Update.Visible = false;
            btn_Cancel.Visible = false;
        }

        // When user clicks a cell content
        private void dataGV_custProfiles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Do you want to edit this customer's details?", "Edit Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cust_id = int.Parse(dataGV_custProfiles.SelectedRows[0].Cells[0].Value.ToString());
                tbox_custName.Text = dataGV_custProfiles.SelectedRows[0].Cells[1].Value.ToString();
                tbox_contactPerson.Text = dataGV_custProfiles.SelectedRows[0].Cells[2].Value.ToString();
                tbox_address.Text = dataGV_custProfiles.SelectedRows[0].Cells[3].Value.ToString();
                tbox_contactNum.Text = dataGV_custProfiles.SelectedRows[0].Cells[4].Value.ToString();
                tbox_faxNum.Text = dataGV_custProfiles.SelectedRows[0].Cells[5].Value.ToString();

                //Shows update and cancel button
                btn_Update.Visible = true;
                btn_Cancel.Visible = true;

                // Hides save and delete button
                btn_Save.Visible = false;
                btn_delete.Visible = false;
                //String i = "asd" + supp_id;

            }
        }

        // Create mode
        private void btn_Save_Click_1(object sender, EventArgs e)
        {
            addCustomer();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

        }

        // Update Mode
        private void btn_Update_Click(object sender, EventArgs e)
        {
            updateCustomer();
        }

      
        // Defined Functions
        private void fieldsReset()
        {
            tbox_custName.Text = "";
            tbox_contactPerson.Text = "";
            tbox_address.Text = "";
            tbox_contactNum.Text = "";
            tbox_faxNum.Text = "";
        }

        private void customerTableLoad()
        {
            try
            {
                conn.Open();
                query = "SELECT * FROM customer;";
                command = new MySqlCommand(query, conn);

                adapter = new MySqlDataAdapter(command);
                dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGV_custProfiles.DataSource = dataTable;
                conn.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
                conn.Close();
            }

            dataGV_custProfiles.Columns["cust_id"].Visible = false;
            dataGV_custProfiles.Columns["cust_name"].HeaderText = "Name";
            dataGV_custProfiles.Columns["cust_contactPerson"].HeaderText = "Contact Person";
            dataGV_custProfiles.Columns["cust_address"].HeaderText = "Address";
            dataGV_custProfiles.Columns["cust_contactNum"].HeaderText = "Contact Number";
            dataGV_custProfiles.Columns["cust_faxNum"].HeaderText = "Fax Number";
            dataGV_custProfiles.Columns["cust_status"].Visible = false;
        }

        private void addCustomer()
        {
            //Validation - - if either of the fields do not contain an input, it will not proceed on adding the item to database
            if (string.IsNullOrWhiteSpace(tbox_custName.Text.ToString()) || string.IsNullOrWhiteSpace(tbox_contactPerson.Text.ToString()) || string.IsNullOrWhiteSpace(tbox_address.Text.ToString()) ||
                string.IsNullOrWhiteSpace(tbox_contactNum.Text.ToString()) || string.IsNullOrWhiteSpace(tbox_faxNum.Text.ToString()))
            {
                MessageBox.Show("Please make sure all fields have inputs.");
            }
            else
            {
                // Assigns the values from text boxes and combo boxes to their respective variables
                name = tbox_custName.Text;
                contactPerson = tbox_contactPerson.Text;
                address = tbox_address.Text;
                contactNum = tbox_contactNum.Text;
                faxNum = tbox_faxNum.Text;

                try
                {
                    conn.Open();

                    //Inserting  values to MySql item table
                    MySqlCommand DatabaseCommand = conn.CreateCommand();
                    DatabaseCommand.CommandText = "INSERT INTO customer (cust_name, cust_contactPerson, cust_address, cust_contactNum, cust_faxNum) " +
                        " VALUES ('" + name + "','" + contactPerson + "','" + address + "','" + contactNum + "','" + faxNum + "')";
                    if (MessageBox.Show("Are you sure you want to add this customer?", "Add Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DatabaseCommand.ExecuteNonQuery();
                        conn.Close();
                        conn.Dispose();


                        MessageBox.Show("Successfully added a new Customer");
                        customerTableLoad();
                        fieldsReset();
                    }

                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }

            }
        }

        private void updateCustomer()
        {
            try
            {
                String q = "UPDATE customer SET cust_name = '" + tbox_custName.Text + "', cust_contactPerson = '" + tbox_contactPerson.Text + "', " +
                    " cust_address = '" + tbox_address.Text + "', cust_contactNum = '" + tbox_contactNum.Text + "', cust_faxNum = '" + tbox_faxNum.Text + "' WHERE cust_id = '" + cust_id + "' ";

                conn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(q, conn);
                int count = adapter.SelectCommand.ExecuteNonQuery();

                if (count >= 1)
                {
                    MessageBox.Show("Employee successfully Updated!");
                }
                conn.Close();

                customerTableLoad();
                fieldsReset();
                btn_Save.Visible = true;
                btn_delete.Visible = true;
                btn_Update.Visible = false;
                btn_Cancel.Visible = false;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }
    }
}
