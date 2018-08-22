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
    public partial class userCon_supplierProfiles : UserControl
    {
        //- - Variables - -
        public Form refAdminHome { get; set; }
        public Form refItemSupp { get; set; }
        public MySqlConnection conn;
        public MySqlCommand command;
        public MySqlDataAdapter adapter;
        public DataTable dataTable;
        int supp_id;

        public userCon_supplierProfiles()
        {
            conn = new MySqlConnection("Server=localhost; Database=rillan_trading; Uid=root; Pwd=root;");
            InitializeComponent();
        }

        private void supplierProfiles_Load(object sender, EventArgs e)
        {
            suppProfTableLoad();
        }

        private void dataGV_supplier_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Do you want to edit this employee's details?", "Edit employee", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                supp_id = int.Parse(dataGV_supplier.SelectedRows[0].Cells[0].Value.ToString());
                tbox_supplierName.Text = dataGV_supplier.SelectedRows[0].Cells[1].Value.ToString();
                tbox_supplierAddress.Text = dataGV_supplier.SelectedRows[0].Cells[2].Value.ToString();
                tbox_contactPerson.Text = dataGV_supplier.SelectedRows[0].Cells[3].Value.ToString();
                tbox_emailAddr.Text = dataGV_supplier.SelectedRows[0].Cells[4].Value.ToString();
                tbox_contactNum.Text = dataGV_supplier.SelectedRows[0].Cells[5].Value.ToString();
                tbox_faxNum.Text = dataGV_supplier.SelectedRows[0].Cells[6].Value.ToString();


                btn_delete.Text = "Cancel";
                btn_Save.Text = "Update";
                btn_delete.Visible = true;
                String i = "asd" + supp_id;

            }
        }

        #region Button Functions

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

        private void btn_delete_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Defined Functions

        //loads all data in supplier's table to the data grid
        private void suppProfTableLoad() 
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
            dataGV_supplier.Columns["supp_contactPerson"].HeaderText = "Contact Person";
            dataGV_supplier.Columns["supp_emailAddress"].HeaderText = "Email Address";
            dataGV_supplier.Columns["supp_contactNum"].HeaderText = "Contact Number";
            dataGV_supplier.Columns["supp_faxNum"].HeaderText = "Fax Number";

        }

        //create new supplier profile
        private void addSupplier() 
        {
            //Validation
            if (string.IsNullOrWhiteSpace(tbox_supplierName.Text.ToString()))
            {
                MessageBox.Show("Please fill in for supplier's name");
            }
            else if (string.IsNullOrWhiteSpace(tbox_contactPerson.Text.ToString()))
            {
                MessageBox.Show("Please fill in for supplier's fax number");
            }
            else if (string.IsNullOrWhiteSpace(tbox_emailAddr.Text.ToString()))
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
                    DatabaseCommand.CommandText = "INSERT INTO supplier (supp_name,  supp_address,  supp_contactPerson, supp_emailAddress, supp_contactNum, supp_faxNum) " +
                        " VALUES ('" + tbox_supplierName.Text + "','" + tbox_supplierAddress.Text + "','" + tbox_contactPerson.Text + "','" + tbox_emailAddr.Text + "','" + tbox_contactNum.Text + "', '" + tbox_faxNum.Text + "')";
                    if (MessageBox.Show("Are you sure you want to add this supplier profile?", "Add employee", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DatabaseCommand.ExecuteNonQuery();
                        conn.Close();
                        conn.Dispose();

                        MessageBox.Show("Successfully added an supplier");
                        suppProfTableLoad();
                        fieldsReset();
                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
            }
        }

        //edit function
        private void editSupplier() 
        {
            if (btn_Save.Text == "Update")
            {
                try
                {
                    String q = "UPDATE supplier SET supp_name = '" + tbox_supplierName.Text + "', supp_faxNum = '" + tbox_contactPerson.Text + "', " +
                        " supp_contactNum = '" + tbox_emailAddr.Text + "', supp_address = '" + tbox_supplierAddress.Text + "' WHERE supp_id = '" + supp_id + "' ";

                    conn.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(q, conn);
                    int count = adapter.SelectCommand.ExecuteNonQuery();

                    if (count >= 1)
                    {
                        MessageBox.Show("Employee successfully Updated!");
                    }
                    conn.Close();

                    suppProfTableLoad();
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

        //clears all the textbox fields
        private void fieldsReset() 
        {
            tbox_supplierName.Clear();
            tbox_contactPerson.Clear();
            tbox_emailAddr.Clear();
            tbox_supplierAddress.Clear();
        }

        #endregion


    }
}
