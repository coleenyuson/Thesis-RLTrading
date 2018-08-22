namespace Thesis_Rillan_Trading
{
    partial class formItemSupplier
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_addItem = new System.Windows.Forms.Button();
            this.dataGV_item = new System.Windows.Forms.DataGridView();
            this.tbx_itemSearch = new System.Windows.Forms.TextBox();
            this.tbx_supplier = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_item)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Controls.Add(this.btn_addItem);
            this.panel1.Controls.Add(this.dataGV_item);
            this.panel1.Controls.Add(this.tbx_itemSearch);
            this.panel1.Controls.Add(this.tbx_supplier);
            this.panel1.Location = new System.Drawing.Point(10, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1071, 544);
            this.panel1.TabIndex = 1;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(615, 2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(68, 23);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Visible = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click_1);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(787, 3);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(101, 23);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Visible = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click_1);
            // 
            // btn_addItem
            // 
            this.btn_addItem.Location = new System.Drawing.Point(894, 3);
            this.btn_addItem.Name = "btn_addItem";
            this.btn_addItem.Size = new System.Drawing.Size(174, 23);
            this.btn_addItem.TabIndex = 2;
            this.btn_addItem.Text = "Add Item";
            this.btn_addItem.UseVisualStyleBackColor = true;
            this.btn_addItem.Click += new System.EventHandler(this.btn_addItem_Click);
            // 
            // dataGV_item
            // 
            this.dataGV_item.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGV_item.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGV_item.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_item.Location = new System.Drawing.Point(3, 31);
            this.dataGV_item.Name = "dataGV_item";
            this.dataGV_item.RowHeadersVisible = false;
            this.dataGV_item.RowTemplate.Height = 24;
            this.dataGV_item.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGV_item.Size = new System.Drawing.Size(1065, 510);
            this.dataGV_item.TabIndex = 1;
            this.dataGV_item.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGV_item_CellContentClick_1);
            // 
            // tbx_itemSearch
            // 
            this.tbx_itemSearch.Location = new System.Drawing.Point(302, 3);
            this.tbx_itemSearch.Name = "tbx_itemSearch";
            this.tbx_itemSearch.Size = new System.Drawing.Size(307, 22);
            this.tbx_itemSearch.TabIndex = 0;
            this.tbx_itemSearch.Visible = false;
            this.tbx_itemSearch.TextChanged += new System.EventHandler(this.tbx_itemSearch_TextChanged);
            // 
            // tbx_supplier
            // 
            this.tbx_supplier.Location = new System.Drawing.Point(3, 3);
            this.tbx_supplier.Name = "tbx_supplier";
            this.tbx_supplier.Size = new System.Drawing.Size(252, 22);
            this.tbx_supplier.TabIndex = 0;
            this.tbx_supplier.TextChanged += new System.EventHandler(this.tbx_supplier_TextChanged_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // formItemSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 593);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formItemSupplier";
            this.ShowIcon = false;
            this.Text = "formItemSupplier";
            this.Load += new System.EventHandler(this.formItemSupplier_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_item)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_addItem;
        private System.Windows.Forms.DataGridView dataGV_item;
        private System.Windows.Forms.TextBox tbx_itemSearch;
        private System.Windows.Forms.TextBox tbx_supplier;
        private System.Windows.Forms.Button button1;
    }
}