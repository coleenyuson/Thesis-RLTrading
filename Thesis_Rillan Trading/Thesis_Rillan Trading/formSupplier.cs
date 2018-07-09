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
    public partial class formSupplier : Form
    {
        //- - Variables - -
        public Form refAdminHome { get; set; }
        public MySqlConnection conn;
        public MySqlCommand command;
        public MySqlDataAdapter adapter;
        public DataTable dataTable;
        int supp_id;

        public formSupplier()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost; Database=rillan_trading; Uid=root; Pwd=root;");
        }

        //- - Form Load - - 
        private void formSupplier_Load(object sender, EventArgs e)
        {
            timer.Start();
            lbl_DateTime.Text = DateTime.Now.ToShortTimeString() + " " + DateTime.Now.ToLongDateString();
            SuppTableLoad();
        }

        // - - Back Button - -
        private void btn_Back_Click(object sender, EventArgs e)
        {
            formAdminHome fHome = new formAdminHome();
            fHome.refSupplier = this;
            fHome.Show();
            this.Hide();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            formLogin fLogin = new formLogin();
            fLogin.refSupplier = this;
            fLogin.Show();
            this.Hide();
        }

        private void btn_Settings_Click(object sender, EventArgs e)
        {
            formEmployee fEmp = new formEmployee();
            fEmp.refSupplier = this;
            fEmp.Show();
            this.Hide();
        }

        private void formSupplier_FormClosing(object sender, FormClosingEventArgs e)
        {
            formLogin fLogin = new formLogin();
            fLogin.refSupplier = this;
            fLogin.Show();
            this.Close(); // bug
        }


        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (btn_Save.Text == "Update")
            {
                editSupplier();
            }
            else
            {
                addSupplier();
            }
        }

        private void dataGV_supplier_CellContentClick(object sender, DataGridViewCellEventArgs e) //puts the selected cell content to the textbox fields for editing
        {
            if (MessageBox.Show("Do you want to edit this employee's details?", "Edit employee", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                supp_id = int.Parse(dataGV_supplier.SelectedRows[0].Cells[0].Value.ToString());
                tbox_supplierName.Text = dataGV_supplier.SelectedRows[0].Cells[1].Value.ToString();
                tbox_faxNum.Text = dataGV_supplier.SelectedRows[0].Cells[4].Value.ToString();
                tbox_contactNum.Text = dataGV_supplier.SelectedRows[0].Cells[3].Value.ToString();
                tbox_supplierAddress.Text = dataGV_supplier.SelectedRows[0].Cells[2].Value.ToString();

                /*tbox_firstName.BackColor = Color.LightBlue;
                tbox_lastName.BackColor = Color.LightBlue;
                tbox_middleName.BackColor = Color.LightBlue;
                tbox_mobileNum.BackColor = Color.LightBlue;*/
                btn_delete.Text = "Cancel";
                btn_Save.Text = "Update";
                btn_delete.Visible = true;
                String i = "asd" + supp_id;

            }
        }

        private void SuppTableLoad() //loads all data in supplier's table to the data grid
        {
            try
            {
                conn.Open();
                command = new MySqlCommand("(SELECT * FROM supplier)", conn);

                adapter = new MySqlDataAdapter(command);
                dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGV_supplier.DataSource = dataTable;
                conn.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }

            dataGV_supplier.Columns["supp_id"].Visible = false;
            dataGV_supplier.Columns["supp_name"].HeaderText = "Supplier Name";
            dataGV_supplier.Columns["supp_address"].HeaderText = "Supplier Address";
            dataGV_supplier.Columns["supp_contactNum"].HeaderText = "Contact Number";
            dataGV_supplier.Columns["supp_faxNum"].HeaderText = "Fax Number";

        }

        //Create supplier function
        private void addSupplier() //create function
        {
            //Validation
            if (string.IsNullOrWhiteSpace(tbox_supplierName.Text.ToString()))
            {
                MessageBox.Show("Please fill in for supplier's name");
            }
            else if (string.IsNullOrWhiteSpace(tbox_faxNum.Text.ToString()))
            {
                MessageBox.Show("Please fill in for supplier's fax number");
            }
            else if (string.IsNullOrWhiteSpace(tbox_contactNum.Text.ToString()))
            {
                MessageBox.Show("Please fill in for supplier's contact number");
            }
            else if (string.IsNullOrWhiteSpace(tbox_supplierAddress.Text.ToString()))
            {
                MessageBox.Show("Please fill in for supplier's address");
            }
            else
            {
                try
                {
                    conn.Open();

                    //Inserting  values to MySql Emp table
                    MySqlCommand DatabaseCommand = conn.CreateCommand();
                    DatabaseCommand.CommandText = "INSERT INTO supplier (supp_name, supp_faxNum, supp_contactNum, supp_address)VALUES ('" + tbox_supplierName.Text + "','" + tbox_faxNum.Text + "','" + tbox_contactNum.Text + "','" + tbox_supplierAddress.Text + "')";
                    if (MessageBox.Show("Are you sure you want to add this supplier profile?", "Add employee", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DatabaseCommand.ExecuteNonQuery();
                        conn.Close();
                        conn.Dispose();

                        MessageBox.Show("Successfully added an supplier");
                        SuppTableLoad();
                        fieldsReset();
                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
            }
        }

        private void editSupplier() //edit function
        {
            if (btn_Save.Text == "Update")
            {
                try
                {
                    String q = "UPDATE supplier SET supp_name = '" + tbox_supplierName.Text + "', supp_faxNum = '" + tbox_faxNum.Text + "', " +
                        " supp_contactNum = '" + tbox_contactNum.Text + "', supp_address = '" + tbox_supplierAddress.Text + "' WHERE supp_id = '" + supp_id + "' ";

                    conn.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(q, conn);
                    int count = adapter.SelectCommand.ExecuteNonQuery();

                    if (count >= 1)
                    {
                        MessageBox.Show("Employee successfully Updated!");
                    }
                    conn.Close();

                    SuppTableLoad();
                    fieldsReset();
                    btn_Save.Text = "Save";
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
            }
            btn_Save.Text = "Save";
            btn_delete.Visible = false;
        }

        private void fieldsReset() //clears all the textbox fields
        {
            tbox_supplierName.Clear();
            tbox_faxNum.Clear();
            tbox_contactNum.Clear();
            tbox_supplierAddress.Clear();
        }

        private void btn_delete_Click(object sender, EventArgs e) //Disappers when user does not want to edit
        {
            if (btn_delete.Text == "Cancel")
            {
                fieldsReset();
                btn_delete.Visible = false;
            }
        }

        private void tbox_Search_TextChanged(object sender, EventArgs e)
        {
        }

        //Search function
        private void picBox_Search_Click(object sender, EventArgs e)
        {
            if (cmbBox_filter.Text != "Filter By")
            {
                if (cmbBox_filter.SelectedItem.ToString() == "Supplier Name") //Filters supplier's name
                {
                    try
                    {
                        adapter = new MySqlDataAdapter("SELECT * FROM supplier WHERE supp_name LIKE '" + tbox_Search.Text + "%'", conn);
                        dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGV_supplier.DataSource = dataTable;
                    }
                    catch (Exception x)
                    {
                        MessageBox.Show(x.ToString());
                    }
                }
                else if (cmbBox_filter.SelectedItem.ToString() == "Fax Number") //Filters supplier's fax number
                {
                    try
                    {
                        adapter = new MySqlDataAdapter("SELECT * FROM supplier WHERE supp_faxNum LIKE '" + tbox_Search.Text + "%'", conn);
                        dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGV_supplier.DataSource = dataTable;
                    }
                    catch (Exception x)
                    {
                        MessageBox.Show(x.ToString());
                    }
                }
                else if (cmbBox_filter.SelectedItem.ToString() == "Contact Number") //Filters supplier's contact number
                {
                    try
                    {
                        adapter = new MySqlDataAdapter("SELECT * FROM supplier WHERE supp_contactNum LIKE '" + tbox_Search.Text + "%'", conn);
                        dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGV_supplier.DataSource = dataTable;
                    }
                    catch (Exception x)
                    {
                        MessageBox.Show(x.ToString());
                    }
                }
                else if (cmbBox_filter.SelectedItem.ToString() == "Address") //Filters supplier's address
                {
                    try
                    {
                        adapter = new MySqlDataAdapter("SELECT * FROM supplier WHERE supp_address LIKE '" + tbox_Search.Text + "%'", conn);
                        dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGV_supplier.DataSource = dataTable;
                    }
                    catch (Exception x)
                    {
                        MessageBox.Show(x.ToString());
                    }
                }

            }
            else
            {
                MessageBox.Show("Please select filter for search");
            }


        }

        private void btn_refresh_Click(object sender, EventArgs e) //refreshes the data grid
        {
            SuppTableLoad();
        }
    }
}