namespace Thesis_Rillan_Trading
{
    partial class formItemMasterList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formItemMasterList));
            this.cmbBox_filter = new System.Windows.Forms.ComboBox();
            this.tbox_Search = new System.Windows.Forms.TextBox();
            this.btn_AddNewItem = new System.Windows.Forms.Button();
            this.dgv_itemMasterList = new System.Windows.Forms.DataGridView();
            this.clmn_itemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_itemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_itemDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_itemBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_itemCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_itemUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_minWhseLvl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_minStoreLvl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.pnl_Footer = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_DateTime = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_Settings = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.picBox_Search = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_itemMasterList)).BeginInit();
            this.pnl_Header.SuspendLayout();
            this.pnl_Footer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Search)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbBox_filter
            // 
            this.cmbBox_filter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbBox_filter.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.cmbBox_filter.FormattingEnabled = true;
            this.cmbBox_filter.Location = new System.Drawing.Point(298, 89);
            this.cmbBox_filter.Name = "cmbBox_filter";
            this.cmbBox_filter.Size = new System.Drawing.Size(165, 28);
            this.cmbBox_filter.TabIndex = 26;
            this.cmbBox_filter.Text = "Filter By";
            // 
            // tbox_Search
            // 
            this.tbox_Search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbox_Search.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.tbox_Search.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.tbox_Search.Location = new System.Drawing.Point(54, 89);
            this.tbox_Search.Margin = new System.Windows.Forms.Padding(2);
            this.tbox_Search.Name = "tbox_Search";
            this.tbox_Search.Size = new System.Drawing.Size(239, 27);
            this.tbox_Search.TabIndex = 25;
            this.tbox_Search.Text = "Search";
            // 
            // btn_AddNewItem
            // 
            this.btn_AddNewItem.BackColor = System.Drawing.Color.Teal;
            this.btn_AddNewItem.FlatAppearance.BorderSize = 0;
            this.btn_AddNewItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddNewItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddNewItem.ForeColor = System.Drawing.Color.Snow;
            this.btn_AddNewItem.Location = new System.Drawing.Point(937, 70);
            this.btn_AddNewItem.Name = "btn_AddNewItem";
            this.btn_AddNewItem.Size = new System.Drawing.Size(139, 46);
            this.btn_AddNewItem.TabIndex = 24;
            this.btn_AddNewItem.Text = "Add New Item";
            this.btn_AddNewItem.UseVisualStyleBackColor = false;
            this.btn_AddNewItem.Click += new System.EventHandler(this.btn_AddNewItem_Click);
            // 
            // dgv_itemMasterList
            // 
            this.dgv_itemMasterList.AllowUserToAddRows = false;
            this.dgv_itemMasterList.AllowUserToDeleteRows = false;
            this.dgv_itemMasterList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_itemMasterList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_itemMasterList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmn_itemID,
            this.clmn_itemCode,
            this.clmn_itemDesc,
            this.clmn_itemBrand,
            this.clmn_itemCategory,
            this.clmn_itemUnit,
            this.clmn_minWhseLvl,
            this.clmn_minStoreLvl});
            this.dgv_itemMasterList.Location = new System.Drawing.Point(12, 122);
            this.dgv_itemMasterList.Name = "dgv_itemMasterList";
            this.dgv_itemMasterList.ReadOnly = true;
            this.dgv_itemMasterList.RowHeadersVisible = false;
            this.dgv_itemMasterList.RowTemplate.Height = 24;
            this.dgv_itemMasterList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_itemMasterList.Size = new System.Drawing.Size(1064, 523);
            this.dgv_itemMasterList.TabIndex = 23;
            this.dgv_itemMasterList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_itemMasterList_CellDoubleClick);
            // 
            // clmn_itemID
            // 
            this.clmn_itemID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clmn_itemID.HeaderText = "Item ID";
            this.clmn_itemID.Name = "clmn_itemID";
            this.clmn_itemID.ReadOnly = true;
            this.clmn_itemID.Visible = false;
            this.clmn_itemID.Width = 57;
            // 
            // clmn_itemCode
            // 
            this.clmn_itemCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clmn_itemCode.HeaderText = "Item Code";
            this.clmn_itemCode.Name = "clmn_itemCode";
            this.clmn_itemCode.ReadOnly = true;
            this.clmn_itemCode.Width = 107;
            // 
            // clmn_itemDesc
            // 
            this.clmn_itemDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmn_itemDesc.HeaderText = "Item Description";
            this.clmn_itemDesc.Name = "clmn_itemDesc";
            this.clmn_itemDesc.ReadOnly = true;
            // 
            // clmn_itemBrand
            // 
            this.clmn_itemBrand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmn_itemBrand.HeaderText = "Brand";
            this.clmn_itemBrand.Name = "clmn_itemBrand";
            this.clmn_itemBrand.ReadOnly = true;
            // 
            // clmn_itemCategory
            // 
            this.clmn_itemCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmn_itemCategory.HeaderText = "Category";
            this.clmn_itemCategory.Name = "clmn_itemCategory";
            this.clmn_itemCategory.ReadOnly = true;
            // 
            // clmn_itemUnit
            // 
            this.clmn_itemUnit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clmn_itemUnit.HeaderText = "Unit";
            this.clmn_itemUnit.Name = "clmn_itemUnit";
            this.clmn_itemUnit.ReadOnly = true;
            this.clmn_itemUnit.Width = 65;
            // 
            // clmn_minWhseLvl
            // 
            this.clmn_minWhseLvl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clmn_minWhseLvl.HeaderText = "Min. Whse Lvl";
            this.clmn_minWhseLvl.Name = "clmn_minWhseLvl";
            this.clmn_minWhseLvl.ReadOnly = true;
            this.clmn_minWhseLvl.Width = 127;
            // 
            // clmn_minStoreLvl
            // 
            this.clmn_minStoreLvl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clmn_minStoreLvl.HeaderText = "Min. Store Lvl";
            this.clmn_minStoreLvl.Name = "clmn_minStoreLvl";
            this.clmn_minStoreLvl.ReadOnly = true;
            this.clmn_minStoreLvl.Width = 126;
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.Teal;
            this.pnl_Header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Header.Controls.Add(this.btn_back);
            this.pnl_Header.Controls.Add(this.btn_Settings);
            this.pnl_Header.Controls.Add(this.btn_Logout);
            this.pnl_Header.Controls.Add(this.lbl_Name);
            this.pnl_Header.ForeColor = System.Drawing.Color.SteelBlue;
            this.pnl_Header.Location = new System.Drawing.Point(-1, 0);
            this.pnl_Header.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(1093, 50);
            this.pnl_Header.TabIndex = 28;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("LuloCleanW01-One", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.Color.Snow;
            this.lbl_Name.Location = new System.Drawing.Point(404, 14);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(240, 23);
            this.lbl_Name.TabIndex = 3;
            this.lbl_Name.Text = "Item Master List";
            // 
            // pnl_Footer
            // 
            this.pnl_Footer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Footer.BackColor = System.Drawing.Color.Teal;
            this.pnl_Footer.Controls.Add(this.label3);
            this.pnl_Footer.Controls.Add(this.label1);
            this.pnl_Footer.Controls.Add(this.lbl_DateTime);
            this.pnl_Footer.Location = new System.Drawing.Point(-1, 661);
            this.pnl_Footer.Name = "pnl_Footer";
            this.pnl_Footer.Size = new System.Drawing.Size(1093, 30);
            this.pnl_Footer.TabIndex = 29;
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
            this.lbl_DateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_DateTime.AutoSize = true;
            this.lbl_DateTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DateTime.ForeColor = System.Drawing.Color.White;
            this.lbl_DateTime.Location = new System.Drawing.Point(887, 5);
            this.lbl_DateTime.Name = "lbl_DateTime";
            this.lbl_DateTime.Size = new System.Drawing.Size(158, 20);
            this.lbl_DateTime.TabIndex = 3;
            this.lbl_DateTime.Text = "hh:mm January 1, 2018";
            // 
            // btn_back
            // 
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F);
            this.btn_back.ForeColor = System.Drawing.Color.Snow;
            this.btn_back.Image = global::Thesis_Rillan_Trading.Properties.Resources.icons8_Back_32px;
            this.btn_back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_back.Location = new System.Drawing.Point(12, 5);
            this.btn_back.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(40, 40);
            this.btn_back.TabIndex = 5;
            this.btn_back.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_Settings
            // 
            this.btn_Settings.FlatAppearance.BorderSize = 0;
            this.btn_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Settings.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F);
            this.btn_Settings.ForeColor = System.Drawing.Color.Snow;
            this.btn_Settings.Image = global::Thesis_Rillan_Trading.Properties.Resources.icons8_Settings_32px;
            this.btn_Settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Settings.Location = new System.Drawing.Point(993, 5);
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
            this.btn_Logout.Location = new System.Drawing.Point(1039, 5);
            this.btn_Logout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(40, 40);
            this.btn_Logout.TabIndex = 3;
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // picBox_Search
            // 
            this.picBox_Search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picBox_Search.Image = ((System.Drawing.Image)(resources.GetObject("picBox_Search.Image")));
            this.picBox_Search.Location = new System.Drawing.Point(14, 84);
            this.picBox_Search.Name = "picBox_Search";
            this.picBox_Search.Size = new System.Drawing.Size(32, 32);
            this.picBox_Search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBox_Search.TabIndex = 27;
            this.picBox_Search.TabStop = false;
            // 
            // formItemMasterList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1091, 690);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_Footer);
            this.Controls.Add(this.pnl_Header);
            this.Controls.Add(this.picBox_Search);
            this.Controls.Add(this.cmbBox_filter);
            this.Controls.Add(this.tbox_Search);
            this.Controls.Add(this.btn_AddNewItem);
            this.Controls.Add(this.dgv_itemMasterList);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formItemMasterList";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item Master List";
            this.Load += new System.EventHandler(this.formItemMasterList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_itemMasterList)).EndInit();
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.pnl_Footer.ResumeLayout(false);
            this.pnl_Footer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox_Search;
        private System.Windows.Forms.ComboBox cmbBox_filter;
        private System.Windows.Forms.TextBox tbox_Search;
        private System.Windows.Forms.Button btn_AddNewItem;
        private System.Windows.Forms.DataGridView dgv_itemMasterList;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_itemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_itemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_itemDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_itemBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_itemCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_itemUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_minWhseLvl;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_minStoreLvl;
        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Button btn_Settings;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Panel pnl_Footer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_DateTime;
        private System.Windows.Forms.Button btn_back;
    }
}