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
            this.components = new System.ComponentModel.Container();
            this.gbox_supplier = new System.Windows.Forms.GroupBox();
            this.btn_suppSearch = new System.Windows.Forms.Button();
            this.tbox_suppSearch = new System.Windows.Forms.TextBox();
            this.dgv_supplierList = new System.Windows.Forms.DataGridView();
            this.gbox_itemList = new System.Windows.Forms.GroupBox();
            this.btn_itemSearch = new System.Windows.Forms.Button();
            this.tbox_itemSearch = new System.Windows.Forms.TextBox();
            this.dgv_itemList = new System.Windows.Forms.DataGridView();
            this.btn_assign = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer_btn = new System.Windows.Forms.Timer(this.components);
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
            this.dgv_supplierList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_supplierList.Location = new System.Drawing.Point(6, 59);
            this.dgv_supplierList.MultiSelect = false;
            this.dgv_supplierList.Name = "dgv_supplierList";
            this.dgv_supplierList.ReadOnly = true;
            this.dgv_supplierList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_supplierList.RowTemplate.Height = 24;
            this.dgv_supplierList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_supplierList.Size = new System.Drawing.Size(398, 408);
            this.dgv_supplierList.TabIndex = 0;
            this.dgv_supplierList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_supplierList_CellClick);
            this.dgv_supplierList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_supplierList_CellContentClick);
            // 
            // gbox_itemList
            // 
            this.gbox_itemList.Controls.Add(this.btn_itemSearch);
            this.gbox_itemList.Controls.Add(this.tbox_itemSearch);
            this.gbox_itemList.Controls.Add(this.dgv_itemList);
            this.gbox_itemList.Location = new System.Drawing.Point(442, 89);
            this.gbox_itemList.Name = "gbox_itemList";
            this.gbox_itemList.Size = new System.Drawing.Size(643, 473);
            this.gbox_itemList.TabIndex = 1;
            this.gbox_itemList.TabStop = false;
            this.gbox_itemList.Text = "PRODUCT LIST";
            // 
            // btn_itemSearch
            // 
            this.btn_itemSearch.BackColor = System.Drawing.Color.LightGray;
            this.btn_itemSearch.FlatAppearance.BorderSize = 0;
            this.btn_itemSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_itemSearch.Location = new System.Drawing.Point(562, 26);
            this.btn_itemSearch.Name = "btn_itemSearch";
            this.btn_itemSearch.Size = new System.Drawing.Size(75, 27);
            this.btn_itemSearch.TabIndex = 4;
            this.btn_itemSearch.Text = "Search";
            this.btn_itemSearch.UseVisualStyleBackColor = false;
            // 
            // tbox_itemSearch
            // 
            this.tbox_itemSearch.BackColor = System.Drawing.Color.White;
            this.tbox_itemSearch.Location = new System.Drawing.Point(364, 26);
            this.tbox_itemSearch.Name = "tbox_itemSearch";
            this.tbox_itemSearch.Size = new System.Drawing.Size(193, 27);
            this.tbox_itemSearch.TabIndex = 3;
            // 
            // dgv_itemList
            // 
            this.dgv_itemList.AllowUserToAddRows = false;
            this.dgv_itemList.AllowUserToDeleteRows = false;
            this.dgv_itemList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_itemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_itemList.Location = new System.Drawing.Point(6, 59);
            this.dgv_itemList.Name = "dgv_itemList";
            this.dgv_itemList.ReadOnly = true;
            this.dgv_itemList.RowTemplate.Height = 24;
            this.dgv_itemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_itemList.Size = new System.Drawing.Size(631, 408);
            this.dgv_itemList.TabIndex = 3;
            // 
            // btn_assign
            // 
            this.btn_assign.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_assign.FlatAppearance.BorderSize = 0;
            this.btn_assign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_assign.Font = new System.Drawing.Font("LuloCleanW01-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_assign.Location = new System.Drawing.Point(903, 568);
            this.btn_assign.Name = "btn_assign";
            this.btn_assign.Size = new System.Drawing.Size(182, 36);
            this.btn_assign.TabIndex = 2;
            this.btn_assign.Text = "ASSIGN ITEM";
            this.btn_assign.UseVisualStyleBackColor = false;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("LuloCleanW01-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(770, 568);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(127, 36);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "CANCEL";
            this.btn_cancel.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 28);
            this.label1.TabIndex = 47;
            this.label1.Text = "Supplier-Item Management";
            // 
            // timer_btn
            // 
            this.timer_btn.Tick += new System.EventHandler(this.timer_btn_Tick);
            // 
            // supplierItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_assign);
            this.Controls.Add(this.gbox_itemList);
            this.Controls.Add(this.gbox_supplier);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "supplierItem";
            this.Size = new System.Drawing.Size(1097, 627);
            this.Load += new System.EventHandler(this.supplierItem_Load);
            this.gbox_supplier.ResumeLayout(false);
            this.gbox_supplier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_supplierList)).EndInit();
            this.gbox_itemList.ResumeLayout(false);
            this.gbox_itemList.PerformLayout();
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
        private System.Windows.Forms.Button btn_itemSearch;
        private System.Windows.Forms.TextBox tbox_itemSearch;
        private System.Windows.Forms.Button btn_assign;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer_btn;
    }
}
