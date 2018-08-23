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
    public partial class formWarehouseMgt : Form
    {
        // Variables
        public Form refInvMgt { get; set; }
        public Form refPO { get; set; }
        
        public formWarehouseMgt()
        {
            InitializeComponent();
        }

        private void formWarehouseMgt_Load(object sender, EventArgs e)
        {

        }

        #region Buttons
        private void btn_Back_Click(object sender, EventArgs e)
        {
            formInventoryMgt fInvMgt = new formInventoryMgt();
            fInvMgt.refWhseMgt = this;
            fInvMgt.Show();
            this.Hide();
        }

        private void btn_purchaseOrder_Click(object sender, EventArgs e)
        {
            formPurchaseOrder fPO = new formPurchaseOrder();
            fPO.refWhse = this;
            fPO.Show();
            this.Close();
        }


        #endregion


    }
}
