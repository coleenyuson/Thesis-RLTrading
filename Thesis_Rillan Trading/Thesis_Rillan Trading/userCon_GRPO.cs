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
    public partial class userCon_GRPO : UserControl
    {
        // Variables
        public MySqlConnection conn;
        public MySqlCommand command;
        public MySqlDataAdapter adapter;
        public DataTable dataTable;

        public int poID;
        public string suppName;

        public userCon_GRPO()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost; Database=rillan_trading; Uid=root; Pwd=root;");
        }

        private void userCon_GRPO_Load(object sender, EventArgs e)
        {
            tableLoad();
        }

        #region Defined Functions

        private void tableLoad()
        {
            try
            {
                conn.Open();
                adapter = new MySqlDataAdapter("SELECT po_id, supp_name, po_docDate, po_orderDate, po_status, po_notes " +
                    "FROM purchase_order " +
                    "INNER JOIN supplier ON supp_id_fk = supp_id;", conn);
                dataTable = new DataTable();
                adapter.Fill(dataTable);

                foreach (DataRow item in dataTable.Rows)
                {
                    int n = dgv_purchaseOrders.Rows.Add();
                    dgv_purchaseOrders.Rows[n].Cells[0].Value = item[0].ToString(); // purchase ID
                    dgv_purchaseOrders.Rows[n].Cells[1].Value = item[1].ToString(); // supplier name
                    dgv_purchaseOrders.Rows[n].Cells[2].Value = item[2].ToString(); // document date
                    dgv_purchaseOrders.Rows[n].Cells[3].Value = item[3].ToString(); // ordered date
                    if (int.Parse(item[4].ToString()) == 0 )
                    {
                        dgv_purchaseOrders.Rows[n].Cells[4].Value = "Closed";
                    }
                    else if (int.Parse(item[4].ToString()) == 1)
                    {
                        dgv_purchaseOrders.Rows[n].Cells[4].Value = "Open";
                    }
                    dgv_purchaseOrders.Rows[n].Cells[5].Value = item[5].ToString(); // notes
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        #endregion

        private void dgv_purchaseOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            formGRPO fGRPO = new formGRPO();
            fGRPO.ref_poID = poID;
            fGRPO.ref_suppName = suppName;
            fGRPO.ShowDialog(this);
        }

        private void dgv_purchaseOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            poID = int.Parse(dgv_purchaseOrders.SelectedRows[0].Cells[0].Value.ToString());
            suppName = dgv_purchaseOrders.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}
