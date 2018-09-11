namespace Thesis_Rillan_Trading
{
    partial class formInventoryMgt
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
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_sideMenu = new System.Windows.Forms.Panel();
            this.pnl_Footer = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_DateTime = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pnl_window = new System.Windows.Forms.Panel();
            this.userControl_invHome = new Thesis_Rillan_Trading.userCon_inventoryHome();
            this.btn_dashboard = new System.Windows.Forms.Button();
            this.btn_itemMasterList = new System.Windows.Forms.Button();
            this.btn_stockTransfer = new System.Windows.Forms.Button();
            this.btn_inventoryData = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Settings = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
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
            this.pnl_Header.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(1368, 53);
            this.pnl_Header.TabIndex = 21;
            this.pnl_Header.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Header_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("LuloCleanW01-One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(486, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Inventory Management";
            // 
            // pnl_sideMenu
            // 
            this.pnl_sideMenu.BackColor = System.Drawing.Color.CadetBlue;
            this.pnl_sideMenu.Controls.Add(this.btn_dashboard);
            this.pnl_sideMenu.Controls.Add(this.btn_itemMasterList);
            this.pnl_sideMenu.Controls.Add(this.btn_stockTransfer);
            this.pnl_sideMenu.Controls.Add(this.btn_inventoryData);
            this.pnl_sideMenu.Controls.Add(this.btn_Back);
            this.pnl_sideMenu.Location = new System.Drawing.Point(-1, 52);
            this.pnl_sideMenu.Name = "pnl_sideMenu";
            this.pnl_sideMenu.Size = new System.Drawing.Size(267, 598);
            this.pnl_sideMenu.TabIndex = 7;
            // 
            // pnl_Footer
            // 
            this.pnl_Footer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Footer.BackColor = System.Drawing.Color.Teal;
            this.pnl_Footer.Controls.Add(this.label3);
            this.pnl_Footer.Controls.Add(this.label1);
            this.pnl_Footer.Controls.Add(this.lbl_DateTime);
            this.pnl_Footer.Location = new System.Drawing.Point(-4, 676);
            this.pnl_Footer.Name = "pnl_Footer";
            this.pnl_Footer.Size = new System.Drawing.Size(1368, 32);
            this.pnl_Footer.TabIndex = 34;
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
            this.lbl_DateTime.Location = new System.Drawing.Point(1151, 8);
            this.lbl_DateTime.Name = "lbl_DateTime";
            this.lbl_DateTime.Size = new System.Drawing.Size(158, 20);
            this.lbl_DateTime.TabIndex = 3;
            this.lbl_DateTime.Text = "hh:mm January 1, 2018";
            // 
            // pnl_window
            // 
            this.pnl_window.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_window.Controls.Add(this.userControl_invHome);
            this.pnl_window.Location = new System.Drawing.Point(266, 52);
            this.pnl_window.Name = "pnl_window";
            this.pnl_window.Size = new System.Drawing.Size(1097, 624);
            this.pnl_window.TabIndex = 22;
            // 
            // userControl_invHome
            // 
            this.userControl_invHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_invHome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.userControl_invHome.Location = new System.Drawing.Point(0, 0);
            this.userControl_invHome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userControl_invHome.Name = "userControl_invHome";
            this.userControl_invHome.Size = new System.Drawing.Size(1097, 624);
            this.userControl_invHome.TabIndex = 0;
            this.userControl_invHome.Load += new System.EventHandler(this.userControl_invHome_Load);
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.FlatAppearance.BorderSize = 0;
            this.btn_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btn_dashboard.ForeColor = System.Drawing.Color.Snow;
            this.btn_dashboard.Image = global::Thesis_Rillan_Trading.Properties.Resources.icons8_Dashboard_32px;
            this.btn_dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dashboard.Location = new System.Drawing.Point(2, 118);
            this.btn_dashboard.Margin = new System.Windows.Forms.Padding(2);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Size = new System.Drawing.Size(265, 43);
            this.btn_dashboard.TabIndex = 6;
            this.btn_dashboard.Text = "             Dashboard";
            this.btn_dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dashboard.UseVisualStyleBackColor = true;
            this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click);
            // 
            // btn_itemMasterList
            // 
            this.btn_itemMasterList.FlatAppearance.BorderSize = 0;
            this.btn_itemMasterList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_itemMasterList.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btn_itemMasterList.ForeColor = System.Drawing.Color.Snow;
            this.btn_itemMasterList.Image = global::Thesis_Rillan_Trading.Properties.Resources.icons8_Product_32px;
            this.btn_itemMasterList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_itemMasterList.Location = new System.Drawing.Point(2, 181);
            this.btn_itemMasterList.Margin = new System.Windows.Forms.Padding(2);
            this.btn_itemMasterList.Name = "btn_itemMasterList";
            this.btn_itemMasterList.Size = new System.Drawing.Size(265, 43);
            this.btn_itemMasterList.TabIndex = 5;
            this.btn_itemMasterList.Text = "             Item Master List";
            this.btn_itemMasterList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_itemMasterList.UseVisualStyleBackColor = true;
            this.btn_itemMasterList.Click += new System.EventHandler(this.btn_itemMasterList_Click);
            // 
            // btn_stockTransfer
            // 
            this.btn_stockTransfer.FlatAppearance.BorderSize = 0;
            this.btn_stockTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stockTransfer.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btn_stockTransfer.ForeColor = System.Drawing.Color.Snow;
            this.btn_stockTransfer.Image = global::Thesis_Rillan_Trading.Properties.Resources.icons8_Move_Stock_32px;
            this.btn_stockTransfer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_stockTransfer.Location = new System.Drawing.Point(2, 313);
            this.btn_stockTransfer.Margin = new System.Windows.Forms.Padding(2);
            this.btn_stockTransfer.Name = "btn_stockTransfer";
            this.btn_stockTransfer.Size = new System.Drawing.Size(265, 43);
            this.btn_stockTransfer.TabIndex = 4;
            this.btn_stockTransfer.Text = "             Stock Transfer";
            this.btn_stockTransfer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_stockTransfer.UseVisualStyleBackColor = true;
            // 
            // btn_inventoryData
            // 
            this.btn_inventoryData.FlatAppearance.BorderSize = 0;
            this.btn_inventoryData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inventoryData.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btn_inventoryData.ForeColor = System.Drawing.Color.Snow;
            this.btn_inventoryData.Image = global::Thesis_Rillan_Trading.Properties.Resources.icons8_Warehouse_32px;
            this.btn_inventoryData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_inventoryData.Location = new System.Drawing.Point(2, 247);
            this.btn_inventoryData.Margin = new System.Windows.Forms.Padding(2);
            this.btn_inventoryData.Name = "btn_inventoryData";
            this.btn_inventoryData.Size = new System.Drawing.Size(265, 43);
            this.btn_inventoryData.TabIndex = 3;
            this.btn_inventoryData.Text = "             Inventory Data";
            this.btn_inventoryData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_inventoryData.UseVisualStyleBackColor = true;
            this.btn_inventoryData.Click += new System.EventHandler(this.btn_whseMgt_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.FlatAppearance.BorderSize = 0;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btn_Back.ForeColor = System.Drawing.Color.Snow;
            this.btn_Back.Image = global::Thesis_Rillan_Trading.Properties.Resources.icons8_Home_32px_1;
            this.btn_Back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Back.Location = new System.Drawing.Point(2, 53);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(265, 43);
            this.btn_Back.TabIndex = 2;
            this.btn_Back.Text = "             Back to Home Menu";
            this.btn_Back.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Settings
            // 
            this.btn_Settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Settings.FlatAppearance.BorderSize = 0;
            this.btn_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Settings.Image = global::Thesis_Rillan_Trading.Properties.Resources.icons8_Settings_32px;
            this.btn_Settings.Location = new System.Drawing.Point(1268, 7);
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
            this.btn_Logout.Location = new System.Drawing.Point(1314, 5);
            this.btn_Logout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(40, 40);
            this.btn_Logout.TabIndex = 5;
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // formInventoryMgt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 705);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_Footer);
            this.Controls.Add(this.pnl_window);
            this.Controls.Add(this.pnl_sideMenu);
            this.Controls.Add(this.pnl_Header);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "formInventoryMgt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rillan Trading - Inventory Management";
            this.Load += new System.EventHandler(this.formInventoryMgt_Load);
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
        private System.Windows.Forms.Button btn_Settings;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Panel pnl_sideMenu;
        private System.Windows.Forms.Button btn_stockTransfer;
        private System.Windows.Forms.Button btn_inventoryData;
        private System.Windows.Forms.Button btn_itemMasterList;
        private System.Windows.Forms.Panel pnl_Footer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_DateTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btn_dashboard;
        private System.Windows.Forms.Panel pnl_window;
        private userCon_inventoryHome userControl_invHome;
    }
}