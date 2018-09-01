namespace Thesis_Rillan_Trading
{
    partial class userCon_supplierItem
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
            this.gbox_supplier = new System.Windows.Forms.GroupBox();
            this.btn_suppSearch = new System.Windows.Forms.Button();
            this.tbox_suppSearch = new System.Windows.Forms.TextBox();
            this.dgv_supplierList = new System.Windows.Forms.DataGridView();
            this.suppID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suppName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbox_itemList = new System.Windows.Forms.GroupBox();
            this.btn_addItem = new System.Windows.Forms.Button();
            this.dgv_itemList = new System.Windows.Forms.DataGridView();
            this.btn_assignItem = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_assignmentMode = new System.Windows.Forms.Button();
            this.btn_viewMode = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_removeItem = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.itemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gbox_supplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_supplierList)).BeginInit();
            this.gbox_itemList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_itemList)).BeginInit();
            this.SuspendLayout();
            // 
            // gbox_supplier
            // 
            this.gbox_supplier.Controls.Add(this.btn_suppSearch);
            this.gbox_supplier.Controls.Add(this.tbox_suppSearch);
            this.gbox_supplier.Controls.Add(this.dgv_supplierList);
            this.gbox_supplier.Location = new System.Drawing.Point(16, 85);
            this.gbox_supplier.Name = "gbox_supplier";
            this.gbox_supplier.Size = new System.Drawing.Size(410, 473);
            this.gbox_supplier.TabIndex = 0;
            this.gbox_supplier.TabStop = false;
            this.gbox_supplier.Text = "SUPPLIER LIST";
            // 
            // btn_suppSearch
            // 
            this.btn_suppSearch.BackColor = System.Drawing.Color.LightGray;
            this.btn_suppSearch.FlatAppearance.BorderSize = 0;
            this.btn_suppSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_suppSearch.Location = new System.Drawing.Point(329, 26);
            this.btn_suppSearch.Name = "btn_suppSearch";
            this.btn_suppSearch.Size = new System.Drawing.Size(75, 27);
            this.btn_suppSearch.TabIndex = 2;
            this.btn_suppSearch.Text = "Search";
            this.btn_suppSearch.UseVisualStyleBackColor = false;
            this.btn_suppSearch.Click += new System.EventHandler(this.btn_suppSearch_Click);
            // 
            // tbox_suppSearch
            // 
            this.tbox_suppSearch.BackColor = System.Drawing.Color.White;
            this.tbox_suppSearch.Location = new System.Drawing.Point(131, 26);
            this.tbox_suppSearch.Name = "tbox_suppSearch";
            this.tbox_suppSearch.Size = new System.Drawing.Size(193, 27);
            this.tbox_suppSearch.TabIndex = 1;
            // 
            // dgv_supplierList
            // 
            this.dgv_supplierList.AllowUserToAddRows = false;
            this.dgv_supplierList.AllowUserToDeleteRows = false;
            this.dgv_supplierList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_supplierList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_supplierList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_supplierList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.suppID,
            this.suppName});
            this.dgv_supplierList.Location = new System.Drawing.Point(6, 59);
            this.dgv_supplierList.MultiSelect = false;
            this.dgv_supplierList.Name = "dgv_supplierList";
            this.dgv_supplierList.ReadOnly = true;
            this.dgv_supplierList.RowHeadersVisible = false;
            this.dgv_supplierList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_supplierList.RowTemplate.Height = 24;
            this.dgv_supplierList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_supplierList.Size = new System.Drawing.Size(398, 408);
            this.dgv_supplierList.TabIndex = 0;
            this.dgv_supplierList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_supplierList_CellClick);
            // 
            // suppID
            // 
            this.suppID.HeaderText = "ID";
            this.suppID.Name = "suppID";
            this.suppID.ReadOnly = true;
            this.suppID.Visible = false;
            // 
            // suppName
            // 
            this.suppName.HeaderText = "Supplier Name";
            this.suppName.Name = "suppName";
            this.suppName.ReadOnly = true;
            // 
            // gbox_itemList
            // 
            this.gbox_itemList.Controls.Add(this.btn_removeItem);
            this.gbox_itemList.Controls.Add(this.btn_addItem);
            this.gbox_itemList.Controls.Add(this.dgv_itemList);
            this.gbox_itemList.Location = new System.Drawing.Point(442, 89);
            this.gbox_itemList.Name = "gbox_itemList";
            this.gbox_itemList.Size = new System.Drawing.Size(631, 473);
            this.gbox_itemList.TabIndex = 1;
            this.gbox_itemList.TabStop = false;
            this.gbox_itemList.Text = "PRODUCT LIST";
            // 
            // btn_addItem
            // 
            this.btn_addItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_addItem.FlatAppearance.BorderSize = 0;
            this.btn_addItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addItem.Location = new System.Drawing.Point(513, 22);
            this.btn_addItem.Name = "btn_addItem";
            this.btn_addItem.Size = new System.Drawing.Size(112, 27);
            this.btn_addItem.TabIndex = 4;
            this.btn_addItem.Text = "Add Item";
            this.btn_addItem.UseVisualStyleBackColor = false;
            this.btn_addItem.Click += new System.EventHandler(this.btn_addItem_Click);
            // 
            // dgv_itemList
            // 
            this.dgv_itemList.AllowUserToAddRows = false;
            this.dgv_itemList.AllowUserToDeleteRows = false;
            this.dgv_itemList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_itemList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_itemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_itemList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemID,
            this.itemCode,
            this.itemDesc,
            this.sellingPrice,
            this.itemSelect});
            this.dgv_itemList.Location = new System.Drawing.Point(6, 55);
            this.dgv_itemList.Name = "dgv_itemList";
            this.dgv_itemList.RowHeadersVisible = false;
            this.dgv_itemList.RowTemplate.Height = 24;
            this.dgv_itemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_itemList.Size = new System.Drawing.Size(619, 412);
            this.dgv_itemList.TabIndex = 3;
            this.dgv_itemList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_itemList_CellClick);
            this.dgv_itemList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_itemList_CellContentClick);
            this.dgv_itemList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_itemList_CellValueChanged);
            // 
            // btn_assignItem
            // 
            this.btn_assignItem.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_assignItem.FlatAppearance.BorderSize = 0;
            this.btn_assignItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_assignItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_assignItem.ForeColor = System.Drawing.Color.White;
            this.btn_assignItem.Location = new System.Drawing.Point(940, 573);
            this.btn_assignItem.Name = "btn_assignItem";
            this.btn_assignItem.Size = new System.Drawing.Size(127, 36);
            this.btn_assignItem.TabIndex = 2;
            this.btn_assignItem.Text = "ASSIGN";
            this.btn_assignItem.UseVisualStyleBackColor = false;
            this.btn_assignItem.Click += new System.EventHandler(this.btn_assignItem_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(807, 573);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(127, 36);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 28);
            this.label1.TabIndex = 47;
            this.label1.Text = "Product Assignment";
            // 
            // btn_assignmentMode
            // 
            this.btn_assignmentMode.BackColor = System.Drawing.Color.LightGray;
            this.btn_assignmentMode.FlatAppearance.BorderSize = 0;
            this.btn_assignmentMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_assignmentMode.Location = new System.Drawing.Point(955, 29);
            this.btn_assignmentMode.Name = "btn_assignmentMode";
            this.btn_assignmentMode.Size = new System.Drawing.Size(112, 27);
            this.btn_assignmentMode.TabIndex = 3;
            this.btn_assignmentMode.Text = "Assignment";
            this.btn_assignmentMode.UseVisualStyleBackColor = false;
            this.btn_assignmentMode.Click += new System.EventHandler(this.btn_assignmentMode_Click);
            // 
            // btn_viewMode
            // 
            this.btn_viewMode.BackColor = System.Drawing.Color.LightGray;
            this.btn_viewMode.FlatAppearance.BorderSize = 0;
            this.btn_viewMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_viewMode.Location = new System.Drawing.Point(837, 30);
            this.btn_viewMode.Name = "btn_viewMode";
            this.btn_viewMode.Size = new System.Drawing.Size(112, 27);
            this.btn_viewMode.TabIndex = 48;
            this.btn_viewMode.Text = "View";
            this.btn_viewMode.UseVisualStyleBackColor = false;
            this.btn_viewMode.Click += new System.EventHandler(this.btn_viewMode_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(721, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 49;
            this.label2.Text = "Window Mode:";
            // 
            // btn_removeItem
            // 
            this.btn_removeItem.BackColor = System.Drawing.Color.IndianRed;
            this.btn_removeItem.FlatAppearance.BorderSize = 0;
            this.btn_removeItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_removeItem.Location = new System.Drawing.Point(395, 22);
            this.btn_removeItem.Name = "btn_removeItem";
            this.btn_removeItem.Size = new System.Drawing.Size(112, 27);
            this.btn_removeItem.TabIndex = 5;
            this.btn_removeItem.Text = "Remove Item";
            this.btn_removeItem.UseVisualStyleBackColor = false;
            this.btn_removeItem.Click += new System.EventHandler(this.btn_removeItem_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.Teal;
            this.btn_Update.FlatAppearance.BorderSize = 0;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.Color.White;
            this.btn_Update.Location = new System.Drawing.Point(940, 573);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(127, 36);
            this.btn_Update.TabIndex = 50;
            this.btn_Update.Text = "UPDATE";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // itemID
            // 
            this.itemID.HeaderText = "ID";
            this.itemID.Name = "itemID";
            this.itemID.Visible = false;
            // 
            // itemCode
            // 
            this.itemCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.itemCode.HeaderText = "Item Code";
            this.itemCode.Name = "itemCode";
            this.itemCode.ReadOnly = true;
            // 
            // itemDesc
            // 
            this.itemDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.itemDesc.HeaderText = "Description";
            this.itemDesc.Name = "itemDesc";
            this.itemDesc.ReadOnly = true;
            // 
            // sellingPrice
            // 
            this.sellingPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sellingPrice.HeaderText = "Selling Price";
            this.sellingPrice.Name = "sellingPrice";
            // 
            // itemSelect
            // 
            this.itemSelect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.itemSelect.HeaderText = "Remove";
            this.itemSelect.Name = "itemSelect";
            this.itemSelect.Width = 69;
            // 
            // userCon_supplierItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_viewMode);
            this.Controls.Add(this.btn_assignmentMode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_assignItem);
            this.Controls.Add(this.gbox_itemList);
            this.Controls.Add(this.gbox_supplier);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "userCon_supplierItem";
            this.Size = new System.Drawing.Size(1097, 627);
            this.Load += new System.EventHandler(this.supplierItem_Load);
            this.gbox_supplier.ResumeLayout(false);
            this.gbox_supplier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_supplierList)).EndInit();
            this.gbox_itemList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_itemList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbox_supplier;
        private System.Windows.Forms.TextBox tbox_suppSearch;
        private System.Windows.Forms.DataGridView dgv_supplierList;
        private System.Windows.Forms.GroupBox gbox_itemList;
        private System.Windows.Forms.Button btn_suppSearch;
        private System.Windows.Forms.DataGridView dgv_itemList;
        private System.Windows.Forms.Button btn_addItem;
        private System.Windows.Forms.Button btn_assignItem;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn suppID;
        private System.Windows.Forms.DataGridViewTextBoxColumn suppName;
        private System.Windows.Forms.Button btn_assignmentMode;
        private System.Windows.Forms.Button btn_viewMode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_removeItem;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellingPrice;
        private System.Windows.Forms.DataGridViewCheckBoxColumn itemSelect;
    }
}
