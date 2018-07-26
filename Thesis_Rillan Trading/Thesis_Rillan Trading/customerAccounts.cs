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
    public partial class customerAccounts : UserControl
    {

        //Variables
        public MySqlConnection conn;
        public MySqlCommand command;
        public MySqlDataAdapter adapter;
        public DataTable dataTable;

        string query;
        int salesOrderID, status;


        public customerAccounts()
        {
            conn = new MySqlConnection("Server=localhost; Database=rillan_trading; Uid=root; Pwd=root;");
            InitializeComponent();
        }

        private void customerAccounts_Load(object sender, EventArgs e)
        {
            lbl_custStatus.Visible = false;
            btn_Status.Visible = false;
            
        }

        private void DGView_customerAccts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
        private void btn_search_Click(object sender, EventArgs e)
        {
            searchCustomer();
        }



        private void searchCustomer()
        {
            try
            {
                conn.Open();
                query = "SELECT s.so_id, c.cust_name, c.cust_status, e.emp_firstName, s.so_date, s.so_totalAmount, IF(s.so_status = 0, 'Closed', 'Open') as Status FROM customer c INNER JOIN sales_order s ON c.cust_id = s.cust_id_fk INNER JOIN employee e ON e.emp_id = s.emp_id_fk WHERE c.cust_name LIKE '" + tbox_custName.Text + "%' AND so_date BETWEEN '" + dtp_dateFrom.Value.ToString("yyyy-MM-dd") + "' AND '" + dtp_dateTo.Value.ToString("yyyy-MM-dd") + "';";
                command = new MySqlCommand(query, conn);

                adapter = new MySqlDataAdapter(command);
                dataTable = new DataTable();
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("Customer has no accounts yet.", "", MessageBoxButtons.OK);
                }
                else
                {
                    DGView_customerAccts.DataSource = dataTable;
                }

                salesOrderID = int.Parse(dataTable.Rows[0]["so_id"].ToString());
                status = int.Parse(dataTable.Rows[0]["cust_status"].ToString());

                if (status == 0)
                {
                    lbl_custStatus.Visible = true;
                    lbl_custStatus.Text = "DEACTIVATED";
                    lbl_custStatus.ForeColor = System.Drawing.Color.Red;

                    btn_Status.Visible = true;
                }
                else if (status == 1)
                {
                    lbl_custStatus.Visible = true;
                    lbl_custStatus.Text = "ACTIVATED";
                    lbl_custStatus.ForeColor = System.Drawing.Color.Green;

                    btn_Status.Visible = true;
                    btn_Status.BackColor = System.Drawing.Color.Firebrick;
                    btn_Status.Text = "Deactivate";
                }

                DGView_customerAccts.Columns["so_id"].Visible = false;
                DGView_customerAccts.Columns["cust_name"].HeaderText = "Customer Name";
                DGView_customerAccts.Columns["cust_status"].Visible = false;
                DGView_customerAccts.Columns["emp_firstName"].HeaderText = "Assigned Employee";
                DGView_customerAccts.Columns["so_date"].HeaderText = "Ordered Date";
                DGView_customerAccts.Columns["so_totalAmount"].HeaderText = "Remaining Balance";
               

                conn.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
                conn.Close();
            }
        }

        private void btn_Status_Click(object sender, EventArgs e)
        {
           
        }

        private void lbl_custStatus_Click(object sender, EventArgs e)
        {

        }
    }
}
