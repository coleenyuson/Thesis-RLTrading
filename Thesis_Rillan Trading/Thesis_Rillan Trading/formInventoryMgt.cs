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
        public Form refInvData { get; set; }
        public Form refitemMasterList { get; set; }

        public List<classItems> itemValues { get; set; }

        public formInventoryMgt()
        {
            InitializeComponent();
        }

        private void formInventoryMgt_Load(object sender, EventArgs e)
        {
            // - - When the form loads, it will automatically load the dashboard window - - 
            userControl_invHome.Visible = true;
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

        private void btn_itemMasterList_Click(object sender, EventArgs e)
        {
            formItemMasterList fIML = new formItemMasterList();
            fIML.refInvMgt = this;
            fIML.Show();
            this.Close();
        }

        // - - Shows the dashboard window - -
        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            userControl_invHome.Visible = true;
        }

        private void btn_Settings_Click(object sender, EventArgs e)
        {
            formEmployee fEmp = new formEmployee();
            fEmp.refInventory = this;
            fEmp.Show();
            this.Close();
            
        }

        private void btn_whseMgt_Click(object sender, EventArgs e)
        {
            formInventoryData fWhse = new formInventoryData();
            fWhse.refInvMgt = this;
            fWhse.Show();
            this.Hide();
        }

        private void userControl_invHome_Load(object sender, EventArgs e)
        {

        }

        private void pnl_Header_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
