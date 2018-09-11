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
    public partial class viewForm_supplierList : Form
    {
        //Variables
        public MySqlConnection conn;
        public MySqlCommand command;
        public MySqlDataAdapter adapter;
        public DataTable dataTable;
        
        public int ref_itemID { get; set; }

        public int supp_id { get; set; }

        public viewForm_supplierList()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost; Database=rillan_trading; Uid=root; Pwd=root;");
        }

        private void viewForm_supplierList_Load(object sender, EventArgs e)
        {
            getItem();
            tableLoad();
        }

        #region Defined Functions

        private void tableLoad()
        {
            try
            {

                conn.Open();
                adapter = new MySqlDataAdapter("SELECT supp_id, supp_name, FORMAT(selling_price,2) FROM item_supplier " +
                    " INNER JOIN supplier ON supp_id_fk = supp_id " +
                    " INNER JOIN item ON item_id_fk = item_id WHERE item_id_fk = '" + ref_itemID + "';", conn);
                dataTable = new DataTable();
                adapter.Fill(dataTable);

                foreach (DataRow item in dataTable.Rows)
                {
                    int n = dgv_supplierList.Rows.Add();
                    dgv_supplierList.Rows[n].Cells[0].Value = item[0].ToString(); // supp ID
                    dgv_supplierList.Rows[n].Cells[1].Value = item[1].ToString(); // supp name
                    dgv_supplierList.Rows[n].Cells[2].Value = item[2].ToString(); // selling price
                }
                conn.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
                conn.Close();
            }
        }

        private void getItem()
        {
            try
            {
                conn.Open();
                adapter = new MySqlDataAdapter("SELECT item_desc FROM item WHERE item_id = '" + ref_itemID + "';", conn);
                dataTable = new DataTable();
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count == 1)
                {
                    tbox_item.Text = dataTable.Rows[0]["item_desc"].ToString();
                }
                conn.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
                conn.Close();
            }
        }

        #endregion

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            formPurchaseOrder fPO = new formPurchaseOrder();
            fPO.refsuppList = this;
            fPO.ref_suppID = supp_id;
            fPO.ref_itemID = ref_itemID;
            fPO.ref_ro = true;
            fPO.Show();
            this.Close();
        }
        
        private void dgv_supplierList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            supp_id = int.Parse(dgv_supplierList.SelectedRows[0].Cells[0].Value.ToString());
        }
    }
}
