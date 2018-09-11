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
    public partial class formGRPO : Form
    {
        public MySqlConnection conn;
        public MySqlCommand command;
        public MySqlDataAdapter adapter;
        public DataTable dataTable;

        public int ref_poID { get; set; }
        public string ref_suppName { get; set; }

        public formGRPO()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost; Database=rillan_trading; Uid=root; Pwd=root;");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void formGRPO_Load(object sender, EventArgs e)
        {
            tableLoad();
            tbox_Supplier.Text = ref_suppName;
        }

        #region Defined Functions

        private void tableLoad()
        {
            try
            {
                conn.Open();
                adapter = new MySqlDataAdapter("SELECT item_code, item_desc, po_line_unit, po_line_quantity, po_line_price " +
                    "FROM purchase_order_line " +
                    "INNER JOIN item ON item_id_fk = item_id " +
                    "WHERE po_id = '" + ref_poID + "';", conn);
                dataTable = new DataTable();
                adapter.Fill(dataTable);

                foreach (DataRow item in dataTable.Rows)
                {
                    int n = dgv_po_line.Rows.Add();
                    dgv_po_line.Rows[n].Cells[0].Value = item[0].ToString(); // po id
                    dgv_po_line.Rows[n].Cells[1].Value = item[1].ToString(); // item code
                    dgv_po_line.Rows[n].Cells[2].Value = item[2].ToString(); // item desc
                    dgv_po_line.Rows[n].Cells[3].Value = item[3].ToString(); // unit
                    dgv_po_line.Rows[n].Cells[4].Value = item[4].ToString(); // quantity
                    dgv_po_line.Rows[n].Cells[5].Value = item[5].ToString(); // price
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        #endregion
    }
}
