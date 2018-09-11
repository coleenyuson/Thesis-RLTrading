namespace Thesis_Rillan_Trading
{
    partial class formGRPO
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbox_Supplier = new System.Windows.Forms.TextBox();
            this.dgv_po_line = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.po_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_itemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_itemDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_po_line)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Supplier";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbox_Supplier
            // 
            this.tbox_Supplier.Location = new System.Drawing.Point(101, 35);
            this.tbox_Supplier.Name = "tbox_Supplier";
            this.tbox_Supplier.ReadOnly = true;
            this.tbox_Supplier.Size = new System.Drawing.Size(220, 27);
            this.tbox_Supplier.TabIndex = 1;
            this.tbox_Supplier.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dgv_po_line
            // 
            this.dgv_po_line.AllowUserToAddRows = false;
            this.dgv_po_line.AllowUserToDeleteRows = false;
            this.dgv_po_line.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_po_line.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_po_line.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.po_id,
            this.clmn_itemCode,
            this.clmn_itemDesc,
            this.clmn_unit,
            this.clmn_quantity});
            this.dgv_po_line.Location = new System.Drawing.Point(22, 80);
            this.dgv_po_line.Name = "dgv_po_line";
            this.dgv_po_line.ReadOnly = true;
            this.dgv_po_line.RowHeadersVisible = false;
            this.dgv_po_line.RowTemplate.Height = 24;
            this.dgv_po_line.Size = new System.Drawing.Size(578, 457);
            this.dgv_po_line.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(462, 543);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Receive";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.ForeColor = System.Drawing.Color.Teal;
            this.btn_cancel.Location = new System.Drawing.Point(318, 543);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(138, 36);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            // 
            // po_id
            // 
            this.po_id.HeaderText = "PO_ID";
            this.po_id.Name = "po_id";
            this.po_id.ReadOnly = true;
            this.po_id.Visible = false;
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
            // clmn_unit
            // 
            this.clmn_unit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clmn_unit.HeaderText = "Unit";
            this.clmn_unit.Name = "clmn_unit";
            this.clmn_unit.ReadOnly = true;
            this.clmn_unit.Width = 65;
            // 
            // clmn_quantity
            // 
            this.clmn_quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clmn_quantity.HeaderText = "Quantity";
            this.clmn_quantity.Name = "clmn_quantity";
            this.clmn_quantity.ReadOnly = true;
            this.clmn_quantity.Width = 94;
            // 
            // formGRPO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(620, 606);
            this.ControlBox = false;
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_po_line);
            this.Controls.Add(this.tbox_Supplier);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "formGRPO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Goods Receipt";
            this.Load += new System.EventHandler(this.formGRPO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_po_line)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbox_Supplier;
        private System.Windows.Forms.DataGridView dgv_po_line;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn po_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_itemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_itemDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_quantity;
    }
}