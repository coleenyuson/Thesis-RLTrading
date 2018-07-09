using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using MySql.Data.MySqlClient;

namespace Thesis_Rillan_Trading
{
    public partial class formAdminHome : Form
    {
        

        //- - - Database - - -
        //public MySqlConnection conn; //connection string

        //- - - Variable for Form Reference - - -
        public Form refLogin { get; set; } 
        public Form refEmployee { get; set; }
        public Form refSupplier { get; set; }
        public Form refInventory { get; set; }

        public int ref_empID;
        
        public formAdminHome()
        {
            InitializeComponent();
            //conn = new MySqlConnection("Server=localhost; Database=rillan_trading; Uid=root; Pwd=root;");
        }

        //- - - Form Load - - -
        private void formAdminHome_Load(object sender, EventArgs e)
        {
            timer.Start();
            lbl_DateTime.Text = DateTime.Now.ToShortTimeString() + " " + DateTime.Now.ToLongDateString();
        }

        //- - - Login Buttons - - - 
        private void btn_Logout_Click_1(object sender, EventArgs e)
        {
            formLogin fLogin = new formLogin();
            fLogin.refAdminHome = this;
            fLogin.Show();
            this.Hide();
        }

        //- - - Menu Buttons - - - 
        private void btn_Sales_Click(object sender, EventArgs e)
        {

        }

        private void btn_Inventory_Click(object sender, EventArgs e)
        {
            formInventoryMgt fInv = new formInventoryMgt();
            fInv.refHome = this;
            fInv.Show();
            this.Hide();
        }

        private void btn_Supplier_Click(object sender, EventArgs e)
        {
            formSupplier fSupplier = new formSupplier();
            fSupplier.refAdminHome = this;
            fSupplier.Show();
            this.Hide();
        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {

        }

        private void btn_Reports_Click(object sender, EventArgs e)
        {

        }

        private void btn_Settings_Click(object sender, EventArgs e)
        {
            formEmployee fEmp = new formEmployee();
            fEmp.refAdminHome = this;
            fEmp.Show();
            this.Hide();
        }

        //- - - Others - - -
        private void lbl_CompanyName_Click(object sender, EventArgs e)
        {

        }

        private void picBox_User_Click(object sender, EventArgs e)
        {

        }

        private void pnl_Footer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_Name_Click(object sender, EventArgs e)
        {

        }

        // - - When user wants to close window - - 
        private void formAdminHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            formLogin fLogin = new formLogin();
            fLogin.refAdminHome = this;
            fLogin.Show();
            this.Close();
        }


    }
}
