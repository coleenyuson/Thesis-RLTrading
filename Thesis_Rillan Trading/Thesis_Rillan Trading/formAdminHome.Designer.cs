namespace Thesis_Rillan_Trading
{
    partial class formAdminHome
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
            this.lbl_Role = new System.Windows.Forms.Label();
            this.lbl_DateTime = new System.Windows.Forms.Label();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.btn_Settings = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.btn_Supplier = new System.Windows.Forms.Button();
            this.btn_Reports = new System.Windows.Forms.Button();
            this.btn_Customer = new System.Windows.Forms.Button();
            this.btn_Inventory = new System.Windows.Forms.Button();
            this.btn_Sales = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pnl_Footer.SuspendLayout();
            this.pnl_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Footer
            // 
            this.pnl_Footer.BackColor = System.Drawing.Color.Teal;
            this.pnl_Footer.Controls.Add(this.lbl_Role);
            this.pnl_Footer.Controls.Add(this.lbl_DateTime);
            this.pnl_Footer.Location = new System.Drawing.Point(-8, 289);
            this.pnl_Footer.Name = "pnl_Footer";
            this.pnl_Footer.Size = new System.Drawing.Size(815, 33);
            this.pnl_Footer.TabIndex = 2;
            this.pnl_Footer.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Footer_Paint);
            // 
            // lbl_Role
            // 
            this.lbl_Role.AutoSize = true;
            this.lbl_Role.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Role.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Role.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Role.Location = new System.Drawing.Point(20, 5);
            this.lbl_Role.Name = "lbl_Role";
            this.lbl_Role.Size = new System.Drawing.Size(112, 23);
            this.lbl_Role.TabIndex = 3;
            this.lbl_Role.Text = "Administrator";
            // 
            // lbl_DateTime
            // 
            this.lbl_DateTime.AutoSize = true;
            this.lbl_DateTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DateTime.ForeColor = System.Drawing.Color.White;
            this.lbl_DateTime.Location = new System.Drawing.Point(635, 7);
            this.lbl_DateTime.Name = "lbl_DateTime";
            this.lbl_DateTime.Size = new System.Drawing.Size(158, 20);
            this.lbl_DateTime.TabIndex = 3;
            this.lbl_DateTime.Text = "hh:mm January 1, 2018";
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.Teal;
            this.pnl_Header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Header.Controls.Add(this.btn_Settings);
            this.pnl_Header.Controls.Add(this.btn_Logout);
            this.pnl_Header.Controls.Add(this.lbl_Name);
            this.pnl_Header.ForeColor = System.Drawing.Color.SteelBlue;
            this.pnl_Header.Location = new System.Drawing.Point(-8, -1);
            this.pnl_Header.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(815, 50);
            this.pnl_Header.TabIndex = 8;
            // 
            // btn_Settings
            // 
            this.btn_Settings.FlatAppearance.BorderSize = 0;
            this.btn_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Settings.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F);
            this.btn_Settings.ForeColor = System.Drawing.Color.Snow;
            this.btn_Settings.Image = global::Thesis_Rillan_Trading.Properties.Resources.icons8_Settings_32px;
            this.btn_Settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Settings.Location = new System.Drawing.Point(704, 4);
            this.btn_Settings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Settings.Name = "btn_Settings";
            this.btn_Settings.Size = new System.Drawing.Size(40, 40);
            this.btn_Settings.TabIndex = 4;
            this.btn_Settings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Settings.UseVisualStyleBackColor = true;
            this.btn_Settings.Click += new System.EventHandler(this.btn_Settings_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.FlatAppearance.BorderSize = 0;
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logout.Image = global::Thesis_Rillan_Trading.Properties.Resources.icons8_Sign_Out_32px;
            this.btn_Logout.Location = new System.Drawing.Point(752, 4);
            this.btn_Logout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(40, 40);
            this.btn_Logout.TabIndex = 3;
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click_1);
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("LuloCleanW01-OneBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.Color.Snow;
            this.lbl_Name.Location = new System.Drawing.Point(19, 11);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(141, 25);
            this.lbl_Name.TabIndex = 3;
            this.lbl_Name.Text = "JANE DOE";
            this.lbl_Name.Click += new System.EventHandler(this.lbl_Name_Click);
            // 
            // btn_Supplier
            // 
            this.btn_Supplier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Supplier.FlatAppearance.BorderSize = 0;
            this.btn_Supplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Supplier.Font = new System.Drawing.Font("LuloCleanW01-OneBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Supplier.ForeColor = System.Drawing.Color.Teal;
            this.btn_Supplier.Image = global::Thesis_Rillan_Trading.Properties.Resources.Supplier_100px;
            this.btn_Supplier.Location = new System.Drawing.Point(324, 90);
            this.btn_Supplier.Name = "btn_Supplier";
            this.btn_Supplier.Size = new System.Drawing.Size(150, 150);
            this.btn_Supplier.TabIndex = 9;
            this.btn_Supplier.Text = "SUPPLIER";
            this.btn_Supplier.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Supplier.UseVisualStyleBackColor = true;
            this.btn_Supplier.Click += new System.EventHandler(this.btn_Supplier_Click);
            // 
            // btn_Reports
            // 
            this.btn_Reports.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Reports.FlatAppearance.BorderSize = 0;
            this.btn_Reports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reports.Font = new System.Drawing.Font("LuloCleanW01-OneBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reports.ForeColor = System.Drawing.Color.Teal;
            this.btn_Reports.Image = global::Thesis_Rillan_Trading.Properties.Resources.icons8_Ratings_100px;
            this.btn_Reports.Location = new System.Drawing.Point(636, 90);
            this.btn_Reports.Name = "btn_Reports";
            this.btn_Reports.Size = new System.Drawing.Size(150, 150);
            this.btn_Reports.TabIndex = 7;
            this.btn_Reports.Text = "REPORTS";
            this.btn_Reports.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Reports.UseVisualStyleBackColor = true;
            this.btn_Reports.Click += new System.EventHandler(this.btn_Reports_Click);
            // 
            // btn_Customer
            // 
            this.btn_Customer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Customer.FlatAppearance.BorderSize = 0;
            this.btn_Customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Customer.Font = new System.Drawing.Font("LuloCleanW01-OneBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Customer.ForeColor = System.Drawing.Color.Teal;
            this.btn_Customer.Image = global::Thesis_Rillan_Trading.Properties.Resources.icons8_Customer_100px;
            this.btn_Customer.Location = new System.Drawing.Point(480, 90);
            this.btn_Customer.Name = "btn_Customer";
            this.btn_Customer.Size = new System.Drawing.Size(150, 150);
            this.btn_Customer.TabIndex = 5;
            this.btn_Customer.Text = "CUSTOMER";
            this.btn_Customer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Customer.UseVisualStyleBackColor = true;
            this.btn_Customer.Click += new System.EventHandler(this.btn_Customer_Click);
            // 
            // btn_Inventory
            // 
            this.btn_Inventory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Inventory.FlatAppearance.BorderSize = 0;
            this.btn_Inventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Inventory.Font = new System.Drawing.Font("LuloCleanW01-OneBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Inventory.ForeColor = System.Drawing.Color.Teal;
            this.btn_Inventory.Image = global::Thesis_Rillan_Trading.Properties.Resources.icons8_Product_100px;
            this.btn_Inventory.Location = new System.Drawing.Point(168, 90);
            this.btn_Inventory.Name = "btn_Inventory";
            this.btn_Inventory.Size = new System.Drawing.Size(150, 150);
            this.btn_Inventory.TabIndex = 4;
            this.btn_Inventory.Text = "INVENTORY";
            this.btn_Inventory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Inventory.UseVisualStyleBackColor = true;
            this.btn_Inventory.Click += new System.EventHandler(this.btn_Inventory_Click);
            // 
            // btn_Sales
            // 
            this.btn_Sales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Sales.FlatAppearance.BorderSize = 0;
            this.btn_Sales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sales.Font = new System.Drawing.Font("LuloCleanW01-OneBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sales.ForeColor = System.Drawing.Color.Teal;
            this.btn_Sales.Image = global::Thesis_Rillan_Trading.Properties.Resources.icons8_Cash_in_Hand_100px;
            this.btn_Sales.Location = new System.Drawing.Point(12, 90);
            this.btn_Sales.Name = "btn_Sales";
            this.btn_Sales.Size = new System.Drawing.Size(150, 150);
            this.btn_Sales.TabIndex = 3;
            this.btn_Sales.Text = "SALES";
            this.btn_Sales.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Sales.UseVisualStyleBackColor = true;
            this.btn_Sales.Click += new System.EventHandler(this.btn_Sales_Click);
            // 
            // formAdminHome
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(798, 322);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Supplier);
            this.Controls.Add(this.pnl_Header);
            this.Controls.Add(this.btn_Reports);
            this.Controls.Add(this.btn_Customer);
            this.Controls.Add(this.btn_Inventory);
            this.Controls.Add(this.btn_Sales);
            this.Controls.Add(this.pnl_Footer);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formAdminHome";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rillan Trading - Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formAdminHome_FormClosing);
            this.Load += new System.EventHandler(this.formAdminHome_Load);
            this.pnl_Footer.ResumeLayout(false);
            this.pnl_Footer.PerformLayout();
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_Footer;
        private System.Windows.Forms.Label lbl_DateTime;
        private System.Windows.Forms.Button btn_Inventory;
        private System.Windows.Forms.Button btn_Reports;
        private System.Windows.Forms.Label lbl_Role;
        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Button btn_Settings;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Button btn_Sales;
        private System.Windows.Forms.Button btn_Customer;
        private System.Windows.Forms.Button btn_Supplier;
        private System.Windows.Forms.Timer timer;
    }
}