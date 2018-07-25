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
    public partial class formCustomerMgt : Form
    {
        //Variables
        public Form refAdmiHome { get; set; }
        

        public formCustomerMgt()
        {
         
            InitializeComponent();
        }

        private void formCustomerMgt_Load(object sender, EventArgs e)
        {

        }

        private void customerProfile1_Load_1(object sender, EventArgs e)
        {

        }

        // Buttons

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            formLogin fLogin = new formLogin();
            fLogin.refCustMgt = this;
            fLogin.Show();
            this.Hide();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            formAdminHome fHome = new formAdminHome();
            fHome.refCustomer = this;
            fHome.Show();
            this.Close();
        }

        private void btn_Settings_Click(object sender, EventArgs e)
        {
            formEmployee fEmp = new formEmployee();
            fEmp.refCustMgt = this;
            fEmp.Show();
            this.Hide();
        }

        private void btn_custProfiles_Click(object sender, EventArgs e)
        {
            userControl_custAccounts.Visible = false;
            userControl_custProfs.Visible = true;
        }

        private void btn_custAccounts_Click(object sender, EventArgs e)
        {
            userControl_custAccounts.Visible = true;
            userControl_custProfs.Visible = false;
        }
    }
}
