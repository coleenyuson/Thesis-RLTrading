namespace Thesis_Rillan_Trading
{
    partial class formCustomerMgt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Settings = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.pnl_sideMenu = new System.Windows.Forms.Panel();
            this.btn_custProfiles = new System.Windows.Forms.Button();
            this.btn_custAccounts = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.pnl_Footer = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_DateTime = new System.Windows.Forms.Label();
            this.pnl_window = new System.Windows.Forms.Panel();
            this.userControl_custAccounts = new Thesis_Rillan_Trading.customerAccounts();
            this.userControl_custProfs = new Thesis_Rillan_Trading.customerProfile();
            this.pnl_Header.SuspendLayout();
            this.pnl_sideMenu.SuspendLayout();
            this.pnl_Footer.SuspendLayout();
            this.pnl_window.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Header
            // 
            this.pnl_Header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Header.BackColor = System.Drawing.Color.Teal;
            this.pnl_Header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Header.Controls.Add(this.label2);
            this.pnl_Header.Controls.Add(this.btn_Settings);
            this.pnl_Header.Controls.Add(this.btn_Logout);
            this.pnl_Header.ForeColor = System.Drawing.Color.SteelBlue;
            this.pnl_Header.Location = new System.Drawing.Point(-3, 0);
            this.pnl_Header.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(1368, 66);
            this.pnl_Header.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("LuloCleanW01-OneBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(18, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(397, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Customer Management";
            // 
            // btn_Settings
            // 
            this.btn_Settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Settings.FlatAppearance.BorderSize = 0;
            this.btn_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Settings.Image = global::Thesis_Rillan_Trading.Properties.Resources.icons8_Settings_32px;
            this.btn_Settings.Location = new System.Drawing.Point(1268, 9);
            this.btn_Settings.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_Settings.Name = "btn_Settings";
            this.btn_Settings.Size = new System.Drawing.Size(40, 50);
            this.btn_Settings.TabIndex = 6;
            this.btn_Settings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Settings.UseVisualStyleBackColor = true;
            this.btn_Settings.Click += new System.EventHandler(this.btn_Settings_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Logout.FlatAppearance.BorderSize = 0;
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logout.Image = global::Thesis_Rillan_Trading.Properties.Resources.icons8_Sign_Out_32px;
            this.btn_Logout.Location = new System.Drawing.Point(1314, 6);
            this.btn_Logout.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(40, 50);
            this.btn_Logout.TabIndex = 5;
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // pnl_sideMenu
            // 
            this.pnl_sideMenu.BackColor = System.Drawing.Color.CadetBlue;
            this.pnl_sideMenu.Controls.Add(this.btn_custProfiles);
            this.pnl_sideMenu.Controls.Add(this.btn_custAccounts);
            this.pnl_sideMenu.Controls.Add(this.btn_Back);
            this.pnl_sideMenu.Location = new System.Drawing.Point(0, 65);
            this.pnl_sideMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_sideMenu.Name = "pnl_sideMenu";
            this.pnl_sideMenu.Size = new System.Drawing.Size(267, 601);
            this.pnl_sideMenu.TabIndex = 23;
            // 
            // btn_custProfiles
            // 
            this.btn_custProfiles.FlatAppearance.BorderSize = 0;
            this.btn_custProfiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_custProfiles.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btn_custProfiles.ForeColor = System.Drawing.Color.Snow;
            this.btn_custProfiles.Image = global::Thesis_Rillan_Trading.Properties.Resources.icons8_Profile_32px_2;
            this.btn_custProfiles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_custProfiles.Location = new System.Drawing.Point(2, 148);
            this.btn_custProfiles.Margin = new System.Windows.Forms.Padding(2);
            this.btn_custProfiles.Name = "btn_custProfiles";
            this.btn_custProfiles.Size = new System.Drawing.Size(265, 54);
            this.btn_custProfiles.TabIndex = 6;
            this.btn_custProfiles.Text = "             Customer Profile";
            this.btn_custProfiles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_custProfiles.UseVisualStyleBackColor = true;
            this.btn_custProfiles.Click += new System.EventHandler(this.btn_custProfiles_Click);
            // 
            // btn_custAccounts
            // 
            this.btn_custAccounts.FlatAppearance.BorderSize = 0;
            this.btn_custAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_custAccounts.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btn_custAccounts.ForeColor = System.Drawing.Color.Snow;
            this.btn_custAccounts.Image = global::Thesis_Rillan_Trading.Properties.Resources.icons8_Debt_32px;
            this.btn_custAccounts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_custAccounts.Location = new System.Drawing.Point(2, 230);
            this.btn_custAccounts.Margin = new System.Windows.Forms.Padding(2);
            this.btn_custAccounts.Name = "btn_custAccounts";
            this.btn_custAccounts.Size = new System.Drawing.Size(265, 54);
            this.btn_custAccounts.TabIndex = 5;
            this.btn_custAccounts.Text = "             Customer Accounts";
            this.btn_custAccounts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_custAccounts.UseVisualStyleBackColor = true;
            this.btn_custAccounts.Click += new System.EventHandler(this.btn_custAccounts_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.FlatAppearance.BorderSize = 0;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btn_Back.ForeColor = System.Drawing.Color.Snow;
            this.btn_Back.Image = global::Thesis_Rillan_Trading.Properties.Resources.icons8_Home_32px_1;
            this.btn_Back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Back.Location = new System.Drawing.Point(2, 66);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(265, 54);
            this.btn_Back.TabIndex = 2;
            this.btn_Back.Text = "             Back to Main Menu";
            this.btn_Back.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // pnl_Footer
            // 
            this.pnl_Footer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Footer.BackColor = System.Drawing.Color.Teal;
            this.pnl_Footer.Controls.Add(this.label3);
            this.pnl_Footer.Controls.Add(this.label1);
            this.pnl_Footer.Controls.Add(this.lbl_DateTime);
            this.pnl_Footer.Location = new System.Drawing.Point(-3, 664);
            this.pnl_Footer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_Footer.Name = "pnl_Footer";
            this.pnl_Footer.Size = new System.Drawing.Size(1368, 40);
            this.pnl_Footer.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(73, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Jane Doe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(20, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "User:";
            // 
            // lbl_DateTime
            // 
            this.lbl_DateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_DateTime.AutoSize = true;
            this.lbl_DateTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DateTime.ForeColor = System.Drawing.Color.White;
            this.lbl_DateTime.Location = new System.Drawing.Point(1151, 10);
            this.lbl_DateTime.Name = "lbl_DateTime";
            this.lbl_DateTime.Size = new System.Drawing.Size(158, 20);
            this.lbl_DateTime.TabIndex = 3;
            this.lbl_DateTime.Text = "hh:mm January 1, 2018";
            // 
            // pnl_window
            // 
            this.pnl_window.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_window.Controls.Add(this.userControl_custProfs);
            this.pnl_window.Controls.Add(this.userControl_custAccounts);
            this.pnl_window.Location = new System.Drawing.Point(267, 65);
            this.pnl_window.Name = "pnl_window";
            this.pnl_window.Size = new System.Drawing.Size(1098, 601);
            this.pnl_window.TabIndex = 36;
            // 
            // userControl_custAccounts
            // 
            this.userControl_custAccounts.BackColor = System.Drawing.Color.WhiteSmoke;
            this.userControl_custAccounts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userControl_custAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_custAccounts.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControl_custAccounts.Location = new System.Drawing.Point(0, 0);
            this.userControl_custAccounts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userControl_custAccounts.Name = "userControl_custAccounts";
            this.userControl_custAccounts.Size = new System.Drawing.Size(1098, 601);
            this.userControl_custAccounts.TabIndex = 0;
            // 
            // userControl_custProfs
            // 
            this.userControl_custProfs.BackColor = System.Drawing.Color.WhiteSmoke;
            this.userControl_custProfs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_custProfs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControl_custProfs.Location = new System.Drawing.Point(0, 0);
            this.userControl_custProfs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userControl_custProfs.Name = "userControl_custProfs";
            this.userControl_custProfs.Size = new System.Drawing.Size(1098, 601);
            this.userControl_custProfs.TabIndex = 1;
            // 
            // formCustomerMgt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 703);
            this.Controls.Add(this.pnl_window);
            this.Controls.Add(this.pnl_Footer);
            this.Controls.Add(this.pnl_sideMenu);
            this.Controls.Add(this.pnl_Header);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formCustomerMgt";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rillan Trading - Customer Management";
            this.Load += new System.EventHandler(this.formCustomerMgt_Load);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.pnl_sideMenu.ResumeLayout(false);
            this.pnl_Footer.ResumeLayout(false);
            this.pnl_Footer.PerformLayout();
            this.pnl_window.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Settings;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Panel pnl_sideMenu;
        private System.Windows.Forms.Button btn_custAccounts;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Panel pnl_Footer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_DateTime;
        private System.Windows.Forms.Button btn_custProfiles;
        private customerProfile userControl_custProfiles;
        private System.Windows.Forms.Panel pnl_window;
        private customerAccounts userControl_custAccounts;
        private customerProfile userControl_custProfs;
    }
}