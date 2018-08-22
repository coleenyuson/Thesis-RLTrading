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
    public partial class formInventoryMgt : Form
    {
        // - - Variables - -
        public Form refHome { get; set; }
        public Form refLogin { get; set; }
        public Form refSettings { get; set; }
        public Form refPO { get; set; }

        public List<classItems> itemValues { get; set; }

        public formInventoryMgt()
        {
            InitializeComponent();
        }

        private void formInventoryMgt_Load(object sender, EventArgs e)
        {
            // - - When the form loads, it will automatically load the dashboard window - - 
            userControl_invHome.Visible = true;
            userControl_prodList.Visible = false;
        }


        // - - goes back to login screen - -
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            formLogin refLogin = new formLogin();
            refLogin.refInventory = this;
            refLogin.Show();
            this.Close();
        }
        
        // - - Goes back to admin home screen - - 
        private void btn_Back_Click(object sender, EventArgs e)
        {
            formAdminHome refBack = new formAdminHome();
            refBack.refInventory = this;
            refBack.Show();
            this.Close();
        }


        // - - Shows the product management window - - 
        private void btn_productMgt_Click(object sender, EventArgs e)
        {
            userControl_invHome.Visible = false;
            userControl_prodList.Visible = true;
        }


        // - - Shows the dashboard window - -
        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            userControl_invHome.Visible = true;
            userControl_prodList.Visible = false;
        }

        private void btn_Settings_Click(object sender, EventArgs e)
        {
            formEmployee fEmp = new formEmployee();
            fEmp.refInventory = this;
            fEmp.Show();
            this.Close();
            
        }

        private void btn_purchaseOrder_Click(object sender, EventArgs e)
        {
            formPurchaseOrder fPO = new formPurchaseOrder();
            fPO.refInventory = this;
            fPO.Show();
            this.Hide();
        }
    }
}
