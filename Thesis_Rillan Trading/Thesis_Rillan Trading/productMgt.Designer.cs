namespace Thesis_Rillan_Trading
{
    partial class productMgt
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(productMgt));
            this.pnl_prodDetails = new System.Windows.Forms.Panel();
            this.tbox_sellingPrice = new System.Windows.Forms.TextBox();
            this.lbl_sellingPrice = new System.Windows.Forms.Label();
            this.lbl_categ = new System.Windows.Forms.Label();
            this.cmbBox_itemCateg = new System.Windows.Forms.ComboBox();
            this.lbl_brand = new System.Windows.Forms.Label();
            this.cmbBox_itemBrand = new System.Windows.Forms.ComboBox();
            this.tbox_itemDesc = new System.Windows.Forms.TextBox();
            this.lbl_desc = new System.Windows.Forms.Label();
            this.tbox_itemCode = new System.Windows.Forms.TextBox();
            this.lbl_itemCode = new System.Windows.Forms.Label();
            this.lbl_prodDetails = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.dataGV_prodList = new System.Windows.Forms.DataGridView();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.picBox_Search = new System.Windows.Forms.PictureBox();
            this.cmbBox_filter = new System.Windows.Forms.ComboBox();
            this.tbox_Search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_prodDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_prodList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Search)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_prodDetails
            // 
            this.pnl_prodDetails.BackColor = System.Drawing.Color.LightGray;
            this.pnl_prodDetails.Controls.Add(this.tbox_sellingPrice);
            this.pnl_prodDetails.Controls.Add(this.lbl_sellingPrice);
            this.pnl_prodDetails.Controls.Add(this.lbl_categ);
            this.pnl_prodDetails.Controls.Add(this.cmbBox_itemCateg);
            this.pnl_prodDetails.Controls.Add(this.lbl_brand);
            this.pnl_prodDetails.Controls.Add(this.cmbBox_itemBrand);
            this.pnl_prodDetails.Controls.Add(this.tbox_itemDesc);
            this.pnl_prodDetails.Controls.Add(this.lbl_desc);
            this.pnl_prodDetails.Controls.Add(this.tbox_itemCode);
            this.pnl_prodDetails.Controls.Add(this.lbl_itemCode);
            this.pnl_prodDetails.Controls.Add(this.lbl_prodDetails);
            this.pnl_prodDetails.Location = new System.Drawing.Point(5, 114);
            this.pnl_prodDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_prodDetails.Name = "pnl_prodDetails";
            this.pnl_prodDetails.Size = new System.Drawing.Size(340, 440);
            this.pnl_prodDetails.TabIndex = 0;
            // 
            // tbox_sellingPrice
            // 
            this.tbox_sellingPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbox_sellingPrice.Location = new System.Drawing.Point(120, 335);
            this.tbox_sellingPrice.Name = "tbox_sellingPrice";
            this.tbox_sellingPrice.Size = new System.Drawing.Size(203, 27);
            this.tbox_sellingPrice.TabIndex = 15;
            // 
            // lbl_sellingPrice
            // 
            this.lbl_sellingPrice.AutoSize = true;
            this.lbl_sellingPrice.Location = new System.Drawing.Point(18, 338);
            this.lbl_sellingPrice.Name = "lbl_sellingPrice";
            this.lbl_sellingPrice.Size = new System.Drawing.Size(90, 20);
            this.lbl_sellingPrice.TabIndex = 14;
            this.lbl_sellingPrice.Text = "Selling Price";
            // 
            // lbl_categ
            // 
            this.lbl_categ.AutoSize = true;
            this.lbl_categ.Location = new System.Drawing.Point(18, 284);
            this.lbl_categ.Name = "lbl_categ";
            this.lbl_categ.Size = new System.Drawing.Size(69, 20);
            this.lbl_categ.TabIndex = 6;
            this.lbl_categ.Text = "Category";
            // 
            // cmbBox_itemCateg
            // 
            this.cmbBox_itemCateg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBox_itemCateg.FormattingEnabled = true;
            this.cmbBox_itemCateg.Location = new System.Drawing.Point(120, 281);
            this.cmbBox_itemCateg.Name = "cmbBox_itemCateg";
            this.cmbBox_itemCateg.Size = new System.Drawing.Size(203, 28);
            this.cmbBox_itemCateg.TabIndex = 5;
            // 
            // lbl_brand
            // 
            this.lbl_brand.AutoSize = true;
            this.lbl_brand.Location = new System.Drawing.Point(18, 226);
            this.lbl_brand.Name = "lbl_brand";
            this.lbl_brand.Size = new System.Drawing.Size(48, 20);
            this.lbl_brand.TabIndex = 4;
            this.lbl_brand.Text = "Brand";
            // 
            // cmbBox_itemBrand
            // 
            this.cmbBox_itemBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBox_itemBrand.FormattingEnabled = true;
            this.cmbBox_itemBrand.Location = new System.Drawing.Point(120, 223);
            this.cmbBox_itemBrand.Name = "cmbBox_itemBrand";
            this.cmbBox_itemBrand.Size = new System.Drawing.Size(203, 28);
            this.cmbBox_itemBrand.TabIndex = 1;
            // 
            // tbox_itemDesc
            // 
            this.tbox_itemDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbox_itemDesc.Location = new System.Drawing.Point(120, 169);
            this.tbox_itemDesc.Name = "tbox_itemDesc";
            this.tbox_itemDesc.Size = new System.Drawing.Size(203, 27);
            this.tbox_itemDesc.TabIndex = 2;
            // 
            // lbl_desc
            // 
            this.lbl_desc.AutoSize = true;
            this.lbl_desc.Location = new System.Drawing.Point(18, 172);
            this.lbl_desc.Name = "lbl_desc";
            this.lbl_desc.Size = new System.Drawing.Size(85, 20);
            this.lbl_desc.TabIndex = 3;
            this.lbl_desc.Text = "Description";
            // 
            // tbox_itemCode
            // 
            this.tbox_itemCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbox_itemCode.Location = new System.Drawing.Point(120, 115);
            this.tbox_itemCode.Name = "tbox_itemCode";
            this.tbox_itemCode.Size = new System.Drawing.Size(203, 27);
            this.tbox_itemCode.TabIndex = 1;
            // 
            // lbl_itemCode
            // 
            this.lbl_itemCode.AutoSize = true;
            this.lbl_itemCode.Location = new System.Drawing.Point(18, 118);
            this.lbl_itemCode.Name = "lbl_itemCode";
            this.lbl_itemCode.Size = new System.Drawing.Size(78, 20);
            this.lbl_itemCode.TabIndex = 1;
            this.lbl_itemCode.Text = "Item Code";
            // 
            // lbl_prodDetails
            // 
            this.lbl_prodDetails.AutoSize = true;
            this.lbl_prodDetails.Font = new System.Drawing.Font("LuloCleanW01-One", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prodDetails.Location = new System.Drawing.Point(43, 64);
            this.lbl_prodDetails.Name = "lbl_prodDetails";
            this.lbl_prodDetails.Size = new System.Drawing.Size(240, 23);
            this.lbl_prodDetails.TabIndex = 0;
            this.lbl_prodDetails.Text = "Product Details";
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.IndianRed;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("LuloCleanW01-OneBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.Snow;
            this.btn_delete.Location = new System.Drawing.Point(179, 560);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(166, 38);
            this.btn_delete.TabIndex = 22;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("LuloCleanW01-OneBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Snow;
            this.btn_Save.Location = new System.Drawing.Point(5, 560);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(170, 38);
            this.btn_Save.TabIndex = 21;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // dataGV_prodList
            // 
            this.dataGV_prodList.AllowUserToAddRows = false;
            this.dataGV_prodList.AllowUserToDeleteRows = false;
            this.dataGV_prodList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGV_prodList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_prodList.Location = new System.Drawing.Point(350, 114);
            this.dataGV_prodList.MultiSelect = false;
            this.dataGV_prodList.Name = "dataGV_prodList";
            this.dataGV_prodList.ReadOnly = true;
            this.dataGV_prodList.RowTemplate.Height = 24;
            this.dataGV_prodList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGV_prodList.Size = new System.Drawing.Size(744, 486);
            this.dataGV_prodList.TabIndex = 23;
            this.dataGV_prodList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGV_prodList_CellContentClick);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_refresh.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_refresh.FlatAppearance.BorderSize = 0;
            this.btn_refresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btn_refresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("LuloCleanW01-One", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.Image = global::Thesis_Rillan_Trading.Properties.Resources.icons8_Refresh_32px;
            this.btn_refresh.Location = new System.Drawing.Point(605, 75);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(2);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(35, 35);
            this.btn_refresh.TabIndex = 30;
            this.btn_refresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_refresh.UseVisualStyleBackColor = false;
            // 
            // picBox_Search
            // 
            this.picBox_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBox_Search.Image = ((System.Drawing.Image)(resources.GetObject("picBox_Search.Image")));
            this.picBox_Search.Location = new System.Drawing.Point(645, 75);
            this.picBox_Search.Name = "picBox_Search";
            this.picBox_Search.Size = new System.Drawing.Size(32, 32);
            this.picBox_Search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBox_Search.TabIndex = 29;
            this.picBox_Search.TabStop = false;
            // 
            // cmbBox_filter
            // 
            this.cmbBox_filter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBox_filter.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.cmbBox_filter.FormattingEnabled = true;
            this.cmbBox_filter.Location = new System.Drawing.Point(929, 80);
            this.cmbBox_filter.Name = "cmbBox_filter";
            this.cmbBox_filter.Size = new System.Drawing.Size(165, 28);
            this.cmbBox_filter.TabIndex = 28;
            this.cmbBox_filter.Text = "Filter By";
            // 
            // tbox_Search
            // 
            this.tbox_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbox_Search.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.tbox_Search.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.tbox_Search.Location = new System.Drawing.Point(685, 80);
            this.tbox_Search.Margin = new System.Windows.Forms.Padding(2);
            this.tbox_Search.Name = "tbox_Search";
            this.tbox_Search.Size = new System.Drawing.Size(239, 27);
            this.tbox_Search.TabIndex = 27;
            this.tbox_Search.Text = "Search";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("LuloCleanW01-One", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 34);
            this.label1.TabIndex = 16;
            this.label1.Text = "Product Master List";
            // 
            // productMgt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.picBox_Search);
            this.Controls.Add(this.cmbBox_filter);
            this.Controls.Add(this.tbox_Search);
            this.Controls.Add(this.dataGV_prodList);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.pnl_prodDetails);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "productMgt";
            this.Size = new System.Drawing.Size(1097, 624);
            this.Load += new System.EventHandler(this.productMgt_Load);
            this.pnl_prodDetails.ResumeLayout(false);
            this.pnl_prodDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_prodList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_prodDetails;
        private System.Windows.Forms.TextBox tbox_itemDesc;
        private System.Windows.Forms.Label lbl_desc;
        private System.Windows.Forms.TextBox tbox_itemCode;
        private System.Windows.Forms.Label lbl_itemCode;
        private System.Windows.Forms.Label lbl_prodDetails;
        private System.Windows.Forms.Label lbl_categ;
        private System.Windows.Forms.ComboBox cmbBox_itemCateg;
        private System.Windows.Forms.Label lbl_brand;
        private System.Windows.Forms.ComboBox cmbBox_itemBrand;
        private System.Windows.Forms.Label lbl_sellingPrice;
        private System.Windows.Forms.TextBox tbox_sellingPrice;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.DataGridView dataGV_prodList;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.PictureBox picBox_Search;
        private System.Windows.Forms.ComboBox cmbBox_filter;
        private System.Windows.Forms.TextBox tbox_Search;
        private System.Windows.Forms.Label label1;
    }
}
