using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thesis_Rillan_Trading
{
    public partial class formSalesMgt : Form
    {
        public Form refAdminHome { get; set; }
        public Form refSO { get; set; }

        public formSalesMgt()
        {
            InitializeComponent();
        }

        private void formSalesMgt_Load(object sender, EventArgs e)
        {

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            formAdminHome fHome = new formAdminHome();
            fHome.refSales = this;
            fHome.Show();
            this.Close();
        }

        private void btn_salesOrder_Click(object sender, EventArgs e)
        {
            formSalesOrder fSO = new formSalesOrder();
            fSO.refSalesMgt = this;
            fSO.Show();
            this.Close();
        }
    }
}
