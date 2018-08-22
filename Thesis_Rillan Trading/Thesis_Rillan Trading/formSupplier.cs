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
    public partial class formSupplier : Form
    {
        //- - Variables - -
        public Form refAdminHome { get; set; }
        public Form refItemSupp { get; set; }
        public MySqlConnection conn;
        public MySqlCommand command;
        public MySqlDataAdapter adapter;
        public DataTable dataTable;
        int supp_id;

        public formSupplier()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost; Database=rillan_trading; Uid=root; Pwd=root;");
        }

        //- - Form Load - - 
        private void formSupplier_Load(object sender, EventArgs e)
        {
            timer.Start();
            userCon_suppProfiles.Visible = true;
            userCon_suppItem.Visible = false;
            lbl_DateTime.Text = DateTime.Now.ToShortTimeString() + " " + DateTime.Now.ToLongDateString();
        }

        #region Buttons      
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            formLogin fLogin = new formLogin();
            fLogin.refSupplier = this;
            fLogin.Show();
            this.Hide();
        }

        private void btn_Settings_Click(object sender, EventArgs e)
        {
            formEmployee fEmp = new formEmployee();
            fEmp.refSupplier = this;
            fEmp.Show();
            this.Hide();
        }

        private void btn_back_Click_1(object sender, EventArgs e)
        {
            formAdminHome fHome = new formAdminHome();
            fHome.refSupplier = this;
            fHome.Show();
            this.Hide();
        }

        private void btn_suppMasterList_Click(object sender, EventArgs e)
        {
            userCon_suppProfiles.Visible = true;
            userCon_suppItem.Visible = false;
        }

        private void btn_suppItemList_Click(object sender, EventArgs e)
        {
            userCon_suppProfiles.Visible = false;
            userCon_suppItem.Visible = true;
        }

        #endregion


    }
}