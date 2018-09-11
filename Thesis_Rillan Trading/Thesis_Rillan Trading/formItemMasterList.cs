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
    public partial class formItemMasterList : Form
    {
        // Variables
        public Form refInvMgt { get; set; }

        public MySqlConnection conn;
        public MySqlCommand command;
        public MySqlDataAdapter adapter;
        public DataTable dataTable;

        public formItemMasterList()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost; Database=rillan_trading; Uid=root; Pwd=root;");
        }

        private void formItemMasterList_Load(object sender, EventArgs e)
        {
            itemTableLoad();
        }

        #region Buttons
        private void btn_back_Click(object sender, EventArgs e)
        {
            formInventoryMgt fItmMgt = new formInventoryMgt();
            fItmMgt.refitemMasterList = this;
            fItmMgt.Show();
            this.Close();
        }

        private void btn_AddNewItem_Click(object sender, EventArgs e)
        {
            addForm_Item fAddItem = new addForm_Item();

            fAddItem.ref_modeChecker = false;

            DialogResult dr = fAddItem.ShowDialog(this);

            if (dr == DialogResult.Cancel)
            {
                fAddItem.Close();
            }
            else if (dr == DialogResult.OK)
            {

                fAddItem.addNewItem();
                fAddItem.Close();

                dgv_itemMasterList.Rows.Clear();
                itemTableLoad();
            }
        }

        private void btn_Settings_Click(object sender, EventArgs e)
        {
            formAdminSettings fSettings = new formAdminSettings();
            fSettings.refInventory = this;
            fSettings.Show();
            this.Close();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            formLogin fLogin = new formLogin();
            fLogin.refInventory = this;
            fLogin.Show();
            this.Close();
        }
        #endregion

        #region Defined Functions
        private void itemTableLoad()
        {
            try
            {
                conn.Open();
                adapter = new MySqlDataAdapter("SELECT item_id, item_code, item_desc, item_brand, item_category, item_unit, item_minWhseLvl, item_minStoreLvl " +
                            " FROM item " +
                            " INNER JOIN item_brand ON item_brand_fk = item_brand_id " +
                            " INNER JOIN item_category on item_category_fk = item_categ_id ", conn);
                dataTable = new DataTable();
                adapter.Fill(dataTable);

                foreach (DataRow item in dataTable.Rows)
                {
                    int n = dgv_itemMasterList.Rows.Add();
                    dgv_itemMasterList.Rows[n].Cells[0].Value = item[0].ToString(); // item ID
                    dgv_itemMasterList.Rows[n].Cells[1].Value = item[1].ToString(); // item code
                    dgv_itemMasterList.Rows[n].Cells[2].Value = item[2].ToString(); // item description
                    dgv_itemMasterList.Rows[n].Cells[3].Value = item[3].ToString(); // item brand
                    dgv_itemMasterList.Rows[n].Cells[4].Value = item[4].ToString(); // item category
                    dgv_itemMasterList.Rows[n].Cells[5].Value = item[5].ToString(); // item unit
                    dgv_itemMasterList.Rows[n].Cells[6].Value = item[6].ToString(); // min. whse level
                    dgv_itemMasterList.Rows[n].Cells[7].Value = item[7].ToString(); // min. store level
                }

                conn.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
                conn.Close();
            }
        }

        private void setItemValues()
        {
            
        }

        #endregion

        private void dgv_itemMasterList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            addForm_Item fUpdate = new addForm_Item();

            fUpdate.ref_itemID = int.Parse(dgv_itemMasterList.SelectedRows[0].Cells[0].Value.ToString());
            fUpdate.ref_itemCode = dgv_itemMasterList.SelectedRows[0].Cells[1].Value.ToString();
            fUpdate.ref_itemDesc = dgv_itemMasterList.SelectedRows[0].Cells[2].Value.ToString();
            fUpdate.ref_itemBrand = dgv_itemMasterList.SelectedRows[0].Cells[3].Value.ToString();
            fUpdate.ref_itemCateg = dgv_itemMasterList.SelectedRows[0].Cells[4].Value.ToString();
            fUpdate.ref_itemUnit = dgv_itemMasterList.SelectedRows[0].Cells[5].Value.ToString();
            fUpdate.ref_minWhseLvl = float.Parse(dgv_itemMasterList.SelectedRows[0].Cells[6].Value.ToString());
            fUpdate.ref_minStoreLvl = float.Parse(dgv_itemMasterList.SelectedRows[0].Cells[7].Value.ToString());


            fUpdate.ref_modeChecker = true;

            DialogResult dr = fUpdate.ShowDialog(this);

            if (dr == DialogResult.Cancel)
            {
                fUpdate.Close();
            }
            else if (dr == DialogResult.OK)
            {
                fUpdate.updateItemDetails();
                fUpdate.Close();

                dgv_itemMasterList.Rows.Clear();
                itemTableLoad();
            }
        }
    }
}
