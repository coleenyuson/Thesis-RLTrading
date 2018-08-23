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
    public partial class viewForm_items : Form
    {
        // Variables
        public MySqlConnection conn;
        public MySqlCommand command;
        public MySqlDataAdapter adapter;
        public DataTable dataTable;

        string query;

        public Form refPO { get; set; }

        public viewForm_items()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost; Database=rillan_trading; Uid=root; Pwd=root;");
        }

        private void viewForm_PO_items_Load(object sender, EventArgs e)
        {
            itemTableLoad();
        }

        private void dgv_items_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        #region Defined Functions
        
        private void itemTableLoad ()
        {
            try
            {
                conn.Open();
                adapter = new MySqlDataAdapter("SELECT item_id, item_code, item_desc, item_brand, item_category from item" +
                    " INNER JOIN ITEM_BRAND ON ITEM_BRAND_ID = ITEM_BRAND_FK" +
                    " INNER JOIN ITEM_CATEGORY ON ITEM_CATEG_ID = ITEM_CATEGORY_FK", conn);
                dataTable = new DataTable();
                adapter.Fill(dataTable);

                foreach (DataRow item in dataTable.Rows)
                {
                    int n = dgv_items.Rows.Add();
                    dgv_items.Rows[n].Cells[0].Value = false;
                    dgv_items.Rows[n].Cells[1].Value = item[0].ToString();
                    dgv_items.Rows[n].Cells[2].Value = item[1].ToString();
                    dgv_items.Rows[n].Cells[3].Value = item[2].ToString();
                    dgv_items.Rows[n].Cells[4].Value = item[3].ToString();
                    dgv_items.Rows[n].Cells[5].Value = item[4].ToString();
                }

                conn.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
            
        }



        #endregion

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            formPurchaseOrder fPurchaseOrder = new formPurchaseOrder();
            fPurchaseOrder.refviewItems = this;
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {  

        }

        private void dgv_items_MouseClick(object sender, MouseEventArgs e)
        {
            if((bool)dgv_items.SelectedRows[0].Cells[0].Value == false)
            {
                dgv_items.SelectedRows[0].Cells[0].Value = true;
            }
            else
            {
                dgv_items.SelectedRows[0].Cells[0].Value = false;
            }
        }

        public List<classItems> getItems()
        {
            List<classItems> cItems = new List<classItems>();
            foreach (DataGridViewRow item in dgv_items.Rows)
            {
                if (Convert.ToBoolean(item.Cells[0].Value))
                {
                    cItems.Add(new classItems
                    {
                        itemID = int.Parse(item.Cells[1].Value.ToString()),
                        itemCode = item.Cells[2].Value.ToString(),
                        itemDesc = item.Cells[3].Value.ToString()
                    });
                }
            }

            return cItems;
        }
       
    }
}
