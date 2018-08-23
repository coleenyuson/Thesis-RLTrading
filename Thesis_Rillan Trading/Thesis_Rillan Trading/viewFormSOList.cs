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
    public partial class viewFormSOList : Form
    {
        //Variable
        public MySqlConnection conn;
        public MySqlCommand command;
        public MySqlDataAdapter adapter;
        public DataTable dataTable;

        public string refCustName { get; set; }

        public int refSOID; //temp storage for selected purchase order ID 


        public viewFormSOList()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost; Database=rillan_trading; Uid=root; Pwd=root;");
        }

        private void viewFormSOList_Load(object sender, EventArgs e)
        {
            SOTableLoad();
        }

        private void SOTableLoad()
        {
            try
            {
                conn.Open();
                adapter = new MySqlDataAdapter("SELECT SO_ID, CUST_NAME, SO_DOCDATE, SO_ORDERDATE, SO_TOTALAMOUNT, SO_STATUS " +
                            "FROM SALES_ORDER " +
                            "INNER JOIN CUSTOMER ON CUST_ID_FK = CUST_ID " +
                            "WHERE CUST_NAME = '" + refCustName + "'", conn);
                dataTable = new DataTable();
                adapter.Fill(dataTable);

                foreach (DataRow item in dataTable.Rows)
                {
                    int n = dgv_SOList.Rows.Add();
                    dgv_SOList.Rows[n].Cells[0].Value = item[0].ToString(); // SO ID
                    dgv_SOList.Rows[n].Cells[1].Value = item[1].ToString(); // Customer Name
                    dgv_SOList.Rows[n].Cells[2].Value = item[2].ToString(); // Document Date
                    dgv_SOList.Rows[n].Cells[3].Value = item[3].ToString(); // Order Date
                    dgv_SOList.Rows[n].Cells[4].Value = item[4].ToString(); // Total Amount
                    dgv_SOList.Rows[n].Cells[5].Value = item[5].ToString(); // Status
                }

                conn.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void dgv_SOList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_SOList.SelectedCells.Count > 0)
            {
                refSOID = int.Parse(dgv_SOList.SelectedCells[0].Value.ToString());
            }
        }
    }
}
