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
    public partial class formPurchasing : Form
    {
        //Variable 
        public Form refHome { get; set; }
        public formPurchasing()
        {
            InitializeComponent();
        }

        private void formPurchasing_Load(object sender, EventArgs e)
        {
            userCon_itemsPurchasing1.Visible = true;
            userCon_GRPO1.Visible = false;
        }

        private void userCon_itemsPurchasing1_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_1_Click(object sender, EventArgs e)
        {
            formAdminHome fHome = new formAdminHome();
            fHome.refPurchasing = this;
            fHome.Show();
            this.Close();
        }

        private void btn_grpo_Click(object sender, EventArgs e)
        {
            userCon_itemsPurchasing1.Visible = false;
            userCon_GRPO1.Visible = true;
        }

        private void btn_itemInvStatus_Click(object sender, EventArgs e)
        {
            userCon_itemsPurchasing1.Visible = true;
            userCon_GRPO1.Visible = false;
        }
    }
}
