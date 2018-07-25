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
    public partial class formEmployee : Form
    {
        
        // Variable for Reference Forms
        public Form refAdminHome { get; set; }
        public Form refSupplier { get; set; }
        public Form refInventory { get; set; }
        public Form refCustMgt { get; set; }
        public int ref_Emp_empID;


        public formEmployee()
        {
            InitializeComponent();
        }

        // - - - Form Load - - -
        private void formEmployee_Load(object sender, EventArgs e)
        {
            // - - Date and Time label - -
            timer.Start();
            lbl_DateTime.Text = DateTime.Now.ToShortTimeString() + " " + DateTime.Now.ToLongDateString();

        }

        // Logout Button
        private void btn_Logout_Click_1(object sender, EventArgs e)
        {
            formLogin fLogin = new formLogin();
            fLogin.refEmployee = this;
            fLogin.Show();
            this.Hide();
        }

        // Back Button
        private void btn_Back_Click(object sender, EventArgs e)
        {
            formAdminHome fAdminHome = new formAdminHome();
            fAdminHome.refEmployee = this;
            fAdminHome.ref_empID = ref_Emp_empID;
            fAdminHome.Show();
            this.Hide();
        }
        
        // Save Button - saving input to database
        private void btn_Save_Click(object sender, EventArgs e)
        {

        }

        // Info Button - - Create/Find
        private void btn_Info_Click(object sender, EventArgs e)
        {
          
        }

        private void pnl_Header_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGV_Emp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbl_lastName_Click(object sender, EventArgs e)
        {

        }

        private void tbox_lastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void formEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            formLogin fLogin = new formLogin();
            fLogin.refEmployee = this;
            fLogin.Show();
            this.Close(); //bug
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {

        }

        private void picBox_Search_Click(object sender, EventArgs e)
        {

        }

        private void tbox_Search_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
