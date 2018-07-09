namespace Thesis_Rillan_Trading
{
    partial class formCustomer
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_CustMgt = new System.Windows.Forms.TabPage();
            this.tabPage_CustAccounts = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_CustMgt);
            this.tabControl1.Controls.Add(this.tabPage_CustAccounts);
            this.tabControl1.Location = new System.Drawing.Point(2, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1031, 699);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_CustMgt
            // 
            this.tabPage_CustMgt.Location = new System.Drawing.Point(4, 29);
            this.tabPage_CustMgt.Name = "tabPage_CustMgt";
            this.tabPage_CustMgt.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_CustMgt.Size = new System.Drawing.Size(1023, 666);
            this.tabPage_CustMgt.TabIndex = 0;
            this.tabPage_CustMgt.Text = "Customer Management";
            this.tabPage_CustMgt.UseVisualStyleBackColor = true;
            // 
            // tabPage_CustAccounts
            // 
            this.tabPage_CustAccounts.Location = new System.Drawing.Point(4, 29);
            this.tabPage_CustAccounts.Name = "tabPage_CustAccounts";
            this.tabPage_CustAccounts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_CustAccounts.Size = new System.Drawing.Size(1023, 521);
            this.tabPage_CustAccounts.TabIndex = 1;
            this.tabPage_CustAccounts.Text = "Customer Accounts";
            this.tabPage_CustAccounts.UseVisualStyleBackColor = true;
            // 
            // formCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 709);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formCustomer";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rillan Trading System";
            this.Load += new System.EventHandler(this.formCustomer_Load);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_CustMgt;
        private System.Windows.Forms.TabPage tabPage_CustAccounts;
    }
}