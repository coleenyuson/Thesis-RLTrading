namespace Thesis_Rillan_Trading
{
    partial class formSalesOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formSalesOrder));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_Items = new System.Windows.Forms.TabPage();
            this.tabPage_PaymentMeans = new System.Windows.Forms.TabPage();
            this.DGView_items = new System.Windows.Forms.DataGridView();
            this.cmbox_paymentMode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPage_Items.SuspendLayout();
            this.tabPage_PaymentMeans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGView_items)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_Items);
            this.tabControl1.Controls.Add(this.tabPage_PaymentMeans);
            this.tabControl1.Location = new System.Drawing.Point(12, 53);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1077, 627);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_Items
            // 
            this.tabPage_Items.Controls.Add(this.DGView_items);
            this.tabPage_Items.Location = new System.Drawing.Point(4, 29);
            this.tabPage_Items.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage_Items.Name = "tabPage_Items";
            this.tabPage_Items.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage_Items.Size = new System.Drawing.Size(1069, 594);
            this.tabPage_Items.TabIndex = 0;
            this.tabPage_Items.Text = "Items";
            this.tabPage_Items.UseVisualStyleBackColor = true;
            // 
            // tabPage_PaymentMeans
            // 
            this.tabPage_PaymentMeans.Controls.Add(this.label1);
            this.tabPage_PaymentMeans.Controls.Add(this.cmbox_paymentMode);
            this.tabPage_PaymentMeans.Location = new System.Drawing.Point(4, 29);
            this.tabPage_PaymentMeans.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage_PaymentMeans.Name = "tabPage_PaymentMeans";
            this.tabPage_PaymentMeans.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage_PaymentMeans.Size = new System.Drawing.Size(1069, 594);
            this.tabPage_PaymentMeans.TabIndex = 1;
            this.tabPage_PaymentMeans.Text = "Payment Means";
            this.tabPage_PaymentMeans.UseVisualStyleBackColor = true;
            // 
            // DGView_items
            // 
            this.DGView_items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGView_items.Location = new System.Drawing.Point(6, 7);
            this.DGView_items.Name = "DGView_items";
            this.DGView_items.RowTemplate.Height = 24;
            this.DGView_items.Size = new System.Drawing.Size(1057, 568);
            this.DGView_items.TabIndex = 0;
            this.DGView_items.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGView_items_CellContentClick);
            // 
            // cmbox_paymentMode
            // 
            this.cmbox_paymentMode.FormattingEnabled = true;
            this.cmbox_paymentMode.Items.AddRange(new object[] {
            "Cash",
            "Check"});
            this.cmbox_paymentMode.Location = new System.Drawing.Point(164, 19);
            this.cmbox_paymentMode.Name = "cmbox_paymentMode";
            this.cmbox_paymentMode.Size = new System.Drawing.Size(230, 28);
            this.cmbox_paymentMode.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mode of Payment";
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_Back.FlatAppearance.BorderSize = 0;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btn_Back.ForeColor = System.Drawing.Color.Snow;
            this.btn_Back.Image = ((System.Drawing.Image)(resources.GetObject("btn_Back.Image")));
            this.btn_Back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Back.Location = new System.Drawing.Point(1, 1);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(78, 44);
            this.btn_Back.TabIndex = 3;
            this.btn_Back.Text = "BACK";
            this.btn_Back.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Back.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.btn_Back);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1102, 41);
            this.panel1.TabIndex = 4;
            // 
            // formSalesOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 701);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formSalesOrder";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formSalesOrder";
            this.tabControl1.ResumeLayout(false);
            this.tabPage_Items.ResumeLayout(false);
            this.tabPage_PaymentMeans.ResumeLayout(false);
            this.tabPage_PaymentMeans.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGView_items)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_Items;
        private System.Windows.Forms.TabPage tabPage_PaymentMeans;
        private System.Windows.Forms.DataGridView DGView_items;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbox_paymentMode;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Panel panel1;
    }
}