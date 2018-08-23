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
    public partial class viewFormPOList : Form
    {
        // Variables

        public string refSuppName { get; set; }

        public MySqlConnection conn;
        public MySqlCommand command;
        public MySqlDataAdapter adapter;
        public DataTable dataTable;

        public int refPOID; //temp storage for selected purchase order ID 

        public viewFormPOList()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost; Database=rillan_trading; Uid=root; Pwd=root;");
        }

        private void formPOList_Load(object sender, EventArgs e)
        {
            POTableLoad();
        }

        public void POTableLoad()
        {
            try
            {
                conn.Open();
                adapter = new MySqlDataAdapter("SELECT PO_ID, SUPP_NAME, EMP_FIRSTNAME, PO_DOCDATE, PO_ORDERDATE, PO_STATUS " +
                            "FROM PURCHASE_ORDER " +
                            "INNER JOIN SUPPLIER ON SUPP_ID_FK = SUPP_ID " +
                            "INNER JOIN EMPLOYEE ON EMP_ID_FK = EMP_ID " +
                            "WHERE SUPP_NAME = '" + refSuppName + "'", conn);
                dataTable = new DataTable();
                adapter.Fill(dataTable);

                foreach (DataRow item in dataTable.Rows)
                {
                    int n = dgv_POList.Rows.Add();
                    dgv_POList.Rows[n].Cells[0].Value = item[0].ToString(); // PO ID
                    dgv_POList.Rows[n].Cells[1].Value = item[1].ToString(); // Supplier Name
                    dgv_POList.Rows[n].Cells[2].Value = item[2].ToString(); // Assigned Employee
                    dgv_POList.Rows[n].Cells[3].Value = item[3].ToString(); // Document Date
                    dgv_POList.Rows[n].Cells[4].Value = item[4].ToString(); // Order Date
                    dgv_POList.Rows[n].Cells[5].Value = item[5].ToString(); // Status
                }
                
                conn.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void dgv_POList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_POList.SelectedCells.Count > 0)
            {
                refPOID = int.Parse(dgv_POList.SelectedCells[0].Value.ToString());
            }
        }
    }
}
