namespace Thesis_Rillan_Trading
{
    partial class viewFormPOList
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
            this.dgv_POList = new System.Windows.Forms.DataGridView();
            this.po_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suppName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PO_DocDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PO_OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PO_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_OK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_POList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_POList
            // 
            this.dgv_POList.AllowUserToAddRows = false;
            this.dgv_POList.AllowUserToDeleteRows = false;
            this.dgv_POList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_POList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_POList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.po_ID,
            this.suppName,
            this.empName,
            this.PO_DocDate,
            this.PO_OrderDate,
            this.PO_Status});
            this.dgv_POList.Location = new System.Drawing.Point(12, 12);
            this.dgv_POList.Name = "dgv_POList";
            this.dgv_POList.ReadOnly = true;
            this.dgv_POList.RowHeadersVisible = false;
            this.dgv_POList.RowTemplate.Height = 24;
            this.dgv_POList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_POList.Size = new System.Drawing.Size(776, 487);
            this.dgv_POList.TabIndex = 0;
            this.dgv_POList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_POList_CellClick);
            // 
            // po_ID
            // 
            this.po_ID.HeaderText = "PO_ID";
            this.po_ID.Name = "po_ID";
            this.po_ID.ReadOnly = true;
            this.po_ID.Visible = false;
            // 
            // suppName
            // 
            this.suppName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.suppName.HeaderText = "Supplier Name";
            this.suppName.Name = "suppName";
            this.suppName.ReadOnly = true;
            // 
            // empName
            // 
            this.empName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.empName.HeaderText = "Assigned Employee";
            this.empName.Name = "empName";
            this.empName.ReadOnly = true;
            // 
            // PO_DocDate
            // 
            this.PO_DocDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PO_DocDate.HeaderText = "Document Date";
            this.PO_DocDate.Name = "PO_DocDate";
            this.PO_DocDate.ReadOnly = true;
            // 
            // PO_OrderDate
            // 
            this.PO_OrderDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PO_OrderDate.HeaderText = "Order Date";
            this.PO_OrderDate.Name = "PO_OrderDate";
            this.PO_OrderDate.ReadOnly = true;
            // 
            // PO_Status
            // 
            this.PO_Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PO_Status.HeaderText = "Status";
            this.PO_Status.Name = "PO_Status";
            this.PO_Status.ReadOnly = true;
            this.PO_Status.Width = 78;
            // 
            // btn_OK
            // 
            this.btn_OK.BackColor = System.Drawing.Color.Teal;
            this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_OK.FlatAppearance.BorderSize = 0;
            this.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OK.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OK.ForeColor = System.Drawing.Color.White;
            this.btn_OK.Location = new System.Drawing.Point(694, 506);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(94, 30);
            this.btn_OK.TabIndex = 1;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = false;
            // 
            // formPOList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 547);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.dgv_POList);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formPOList";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Order List";
            this.Load += new System.EventHandler(this.formPOList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_POList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_POList;
        private System.Windows.Forms.DataGridViewTextBoxColumn po_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn suppName;
        private System.Windows.Forms.DataGridViewTextBoxColumn empName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PO_DocDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PO_OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PO_Status;
        private System.Windows.Forms.Button btn_OK;
    }
}