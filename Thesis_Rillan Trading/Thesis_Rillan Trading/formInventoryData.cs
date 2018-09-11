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
    public partial class formInventoryData : Form
    {
        // Variables
        public Form refInvMgt { get; set; }
        public Form refPO { get; set; }
        
        public formInventoryData()
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
            fInvMgt.refInvData = this;
            fInvMgt.Show();
            this.Close();
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


    }
}
