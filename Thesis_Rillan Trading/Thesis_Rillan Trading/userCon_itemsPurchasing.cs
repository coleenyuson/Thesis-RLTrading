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
    public partial class userCon_itemsPurchasing : UserControl
    {
        // Variables
        public MySqlConnection conn;
        public MySqlCommand command;
        public MySqlDataAdapter adapter;
        public DataTable dataTable;

        public int itemID;

        public userCon_itemsPurchasing()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost; Database=rillan_trading; Uid=root; Pwd=root;");
        }

        private void userCon_itemsPurchasing_Load(object sender, EventArgs e)
        {
            itemDataLoad();
            rowColors();
        }

        #region Defined Functions

        private void itemDataLoad()
        {
            try
            {
                conn.Open();
                adapter = new MySqlDataAdapter("SELECT item_id, item_code, item_desc, item_minWhseLvl, (SELECT SUM(grpo_quantity) " +
                    "FROM grpo_line INNER JOIN item ON grpo_item_id_fk = item_id WHERE grpo_item_id_fk = item_id) AS 'In Stock' " +
                    "FROM item;", conn);
                dataTable = new DataTable();
                adapter.Fill(dataTable);

                foreach (DataRow item in dataTable.Rows)
                {
                    int n = dgv_itemMasterList.Rows.Add();
                    dgv_itemMasterList.Rows[n].Cells[0].Value = item[0].ToString(); // item ID
                    dgv_itemMasterList.Rows[n].Cells[1].Value = item[1].ToString(); // item code
                    dgv_itemMasterList.Rows[n].Cells[2].Value = item[2].ToString(); // item description
                    dgv_itemMasterList.Rows[n].Cells[3].Value = item[3].ToString(); // item description
                    if (item[4].ToString() == null || item[4].ToString() == "")
                    {
                        dgv_itemMasterList.Rows[n].Cells[4].Value = 0;
                    }
                    else
                    {
                        dgv_itemMasterList.Rows[n].Cells[4].Value = item[4].ToString(); // total quantity of the specific item 
                    }
                }

             
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
                conn.Close();
            }
        }

        #endregion
        
        private void rowColors()
        {
            for (int i =0; i <dgv_itemMasterList.Rows.Count; i++)
            {
                int minwhselvl = int.Parse(dgv_itemMasterList.Rows[i].Cells[3].Value.ToString());
                int instock = int.Parse(dgv_itemMasterList.Rows[i].Cells[4].Value.ToString());

                if (instock <= minwhselvl)
                {
                    dgv_itemMasterList.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                }
                else if (instock > minwhselvl)
                {
                    dgv_itemMasterList.Rows[i].DefaultCellStyle.ForeColor = Color.Green;
                }
            }
        }
        
        private void dgv_itemMasterList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (itemID != 0)
            {
                viewForm_supplierList fsupplierList = new viewForm_supplierList();
                fsupplierList.ref_itemID = itemID;
                fsupplierList.ShowDialog(this);
            }
        }

        private void dgv_itemMasterList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            itemID = int.Parse(dgv_itemMasterList.SelectedRows[0].Cells[0].Value.ToString());
        }
    }
}
