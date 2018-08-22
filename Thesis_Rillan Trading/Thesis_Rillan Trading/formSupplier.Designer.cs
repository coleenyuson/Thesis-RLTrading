namespace Thesis_Rillan_Trading
{
    partial class formSupplier
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
            this.components = new System.ComponentModel.Container();
            this.pnl_Footer = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_DateTime = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Settings = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.pnl_sideMenu = new System.Windows.Forms.Panel();
            this.pnl_window = new System.Windows.Forms.Panel();
            this.btn_suppMasterList = new System.Windows.Forms.Button();
            this.btn_suppItemList = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.pnl_windowPane = new System.Windows.Forms.Panel();
            this.userCon_suppProfiles = new Thesis_Rillan_Trading.userCon_supplierProfiles();
            this.userCon_suppItem = new Thesis_Rillan_Trading.userCon_supplierItem();
            this.pnl_Footer.SuspendLayout();
            this.pnl_Header.SuspendLayout();
            this.pnl_sideMenu.SuspendLayout();
            this.pnl_windowPane.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Footer
            // 
            this.pnl_Footer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Footer.BackColor = System.Drawing.Color.Teal;
            this.pnl_Footer.Controls.Add(this.label3);
            this.pnl_Footer.Controls.Add(this.label1);
            this.pnl_Footer.Controls.Add(this.lbl_DateTime);
            this.pnl_Footer.Location = new System.Drawing.Point(-3, 679);
            this.pnl_Footer.Name = "pnl_Footer";
            this.pnl_Footer.Size = new System.Drawing.Size(1368, 37);
            this.pnl_Footer.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(73, 5);
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
            this.label1.Location = new System.Drawing.Point(20, 5);
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
            this.lbl_DateTime.Location = new System.Drawing.Point(1149, 7);
            this.lbl_DateTime.Name = "lbl_DateTime";
            this.lbl_DateTime.Size = new System.Drawing.Size(158, 20);
            this.lbl_DateTime.TabIndex = 3;
            this.lbl_DateTime.Text = "hh:mm January 1, 2018";
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
            this.pnl_Header.Location = new System.Drawing.Point(-1, -1);
            this.pnl_Header.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(1364, 53);
            this.pnl_Header.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("LuloCleanW01-OneBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(12, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(378, 29);
            this.label2.TabIndex = 35;
            this.label2.Text = "Supplier Management";
            // 
            // btn_Settings
            // 
            this.btn_Settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Settings.FlatAppearance.BorderSize = 0;
            this.btn_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Settings.Image = global::Thesis_Rillan_Trading.Properties.Resources.icons8_Settings_32px;
            this.btn_Settings.Location = new System.Drawing.Point(1264, 7);
            this.btn_Settings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Settings.Name = "btn_Settings";
            this.btn_Settings.Size = new System.Drawing.Size(40, 40);
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
            this.btn_Logout.Location = new System.Drawing.Point(1310, 5);
            this.btn_Logout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(40, 40);
            this.btn_Logout.TabIndex = 5;
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // pnl_sideMenu
            // 
            this.pnl_sideMenu.BackColor = System.Drawing.Color.CadetBlue;
            this.pnl_sideMenu.Controls.Add(this.pnl_window);
            this.pnl_sideMenu.Controls.Add(this.btn_suppMasterList);
            this.pnl_sideMenu.Controls.Add(this.btn_suppItemList);
            this.pnl_sideMenu.Controls.Add(this.btn_back);
            this.pnl_sideMenu.Location = new System.Drawing.Point(0, 52);
            this.pnl_sideMenu.Name = "pnl_sideMenu";
            this.pnl_sideMenu.Size = new System.Drawing.Size(267, 627);
            this.pnl_sideMenu.TabIndex = 34;
            // 
            // pnl_window
            // 
            this.pnl_window.Location = new System.Drawing.Point(266, 0);
            this.pnl_window.Name = "pnl_window";
            this.pnl_window.Size = new System.Drawing.Size(1099, 624);
            this.pnl_window.TabIndex = 35;
            // 
            // btn_suppMasterList
            // 
            this.btn_suppMasterList.FlatAppearance.BorderSize = 0;
            this.btn_suppMasterList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_suppMasterList.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btn_suppMasterList.ForeColor = System.Drawing.Color.Snow;
            this.btn_suppMasterList.Image = global::Thesis_Rillan_Trading.Properties.Resources.icons8_Product_32px;
            this.btn_suppMasterList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_suppMasterList.Location = new System.Drawing.Point(2, 115);
            this.btn_suppMasterList.Margin = new System.Windows.Forms.Padding(2);
            this.btn_suppMasterList.Name = "btn_suppMasterList";
            this.btn_suppMasterList.Size = new System.Drawing.Size(265, 43);
            this.btn_suppMasterList.TabIndex = 5;
            this.btn_suppMasterList.Text = "             Supplier Master List";
            this.btn_suppMasterList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_suppMasterList.UseVisualStyleBackColor = true;
            this.btn_suppMasterList.Click += new System.EventHandler(this.btn_suppMasterList_Click);
            // 
            // btn_suppItemList
            // 
            this.btn_suppItemList.FlatAppearance.BorderSize = 0;
            this.btn_suppItemList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_suppItemList.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btn_suppItemList.ForeColor = System.Drawing.Color.Snow;
            this.btn_suppItemList.Image = global::Thesis_Rillan_Trading.Properties.Resources.icons8_Warehouse_32px;
            this.btn_suppItemList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_suppItemList.Location = new System.Drawing.Point(2, 181);
            this.btn_suppItemList.Margin = new System.Windows.Forms.Padding(2);
            this.btn_suppItemList.Name = "btn_suppItemList";
            this.btn_suppItemList.Size = new System.Drawing.Size(265, 43);
            this.btn_suppItemList.TabIndex = 3;
            this.btn_suppItemList.Text = "             Supplier-Item List";
            this.btn_suppItemList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_suppItemList.UseVisualStyleBackColor = true;
            this.btn_suppItemList.Click += new System.EventHandler(this.btn_suppItemList_Click);
            // 
            // btn_back
            // 
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btn_back.ForeColor = System.Drawing.Color.Snow;
            this.btn_back.Image = global::Thesis_Rillan_Trading.Properties.Resources.icons8_Home_32px_1;
            this.btn_back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_back.Location = new System.Drawing.Point(2, 53);
            this.btn_back.Margin = new System.Windows.Forms.Padding(2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(265, 43);
            this.btn_back.TabIndex = 2;
            this.btn_back.Text = "             Back to Main Menu";
            this.btn_back.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click_1);
            // 
            // pnl_windowPane
            // 
            this.pnl_windowPane.Controls.Add(this.userCon_suppProfiles);
            this.pnl_windowPane.Controls.Add(this.userCon_suppItem);
            this.pnl_windowPane.Location = new System.Drawing.Point(266, 52);
            this.pnl_windowPane.Name = "pnl_windowPane";
            this.pnl_windowPane.Size = new System.Drawing.Size(1099, 627);
            this.pnl_windowPane.TabIndex = 35;
            // 
            // userCon_suppProfiles
            // 
            this.userCon_suppProfiles.BackColor = System.Drawing.Color.WhiteSmoke;
            this.userCon_suppProfiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userCon_suppProfiles.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userCon_suppProfiles.Location = new System.Drawing.Point(0, 0);
            this.userCon_suppProfiles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userCon_suppProfiles.Name = "userCon_suppProfiles";
            this.userCon_suppProfiles.refAdminHome = null;
            this.userCon_suppProfiles.refItemSupp = null;
            this.userCon_suppProfiles.Size = new System.Drawing.Size(1099, 627);
            this.userCon_suppProfiles.TabIndex = 1;
            // 
            // userCon_suppItem
            // 
            this.userCon_suppItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.userCon_suppItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userCon_suppItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userCon_suppItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userCon_suppItem.Location = new System.Drawing.Point(0, 0);
            this.userCon_suppItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userCon_suppItem.Name = "userCon_suppItem";
            this.userCon_suppItem.Size = new System.Drawing.Size(1099, 627);
            this.userCon_suppItem.TabIndex = 0;
            // 
            // formSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1358, 712);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_windowPane);
            this.Controls.Add(this.pnl_sideMenu);
            this.Controls.Add(this.pnl_Footer);
            this.Controls.Add(this.pnl_Header);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formSupplier";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rillan Trading - Supplier";
            this.Load += new System.EventHandler(this.formSupplier_Load);
            this.pnl_Footer.ResumeLayout(false);
            this.pnl_Footer.PerformLayout();
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.pnl_sideMenu.ResumeLayout(false);
            this.pnl_windowPane.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_Footer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_DateTime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_Settings;
        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Panel pnl_sideMenu;
        private System.Windows.Forms.Button btn_suppMasterList;
        private System.Windows.Forms.Button btn_suppItemList;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnl_window;
        private System.Windows.Forms.Panel pnl_windowPane;
        private userCon_supplierItem userCon_suppItem;
        private userCon_supplierProfiles userCon_suppProfiles;
    }
}