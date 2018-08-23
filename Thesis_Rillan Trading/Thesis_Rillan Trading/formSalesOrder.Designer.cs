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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_orderMode = new System.Windows.Forms.Button();
            this.btn_findMode = new System.Windows.Forms.Button();
            this.pnl_Footer = new System.Windows.Forms.Panel();
            this.lbl_Role = new System.Windows.Forms.Label();
            this.lbl_DateTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_FaxNum = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_ContactNum = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_custAddress = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp_orderDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_docDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbox_customer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_find = new System.Windows.Forms.Button();
            this.btn_removeItem = new System.Windows.Forms.Button();
            this.btn_cancelOrder = new System.Windows.Forms.Button();
            this.lbl_subtotal = new System.Windows.Forms.Label();
            this.lbl_tax = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lbl_discount = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.btn_addOrder = new System.Windows.Forms.Button();
            this.tbox_notes = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_itemView = new System.Windows.Forms.Button();
            this.dgv_salesOrderLine = new System.Windows.Forms.DataGridView();
            this.itemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_poItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_poItemDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_poQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_poItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_contactPerson = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnl_Footer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_salesOrderLine)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_Back);
            this.panel1.Controls.Add(this.btn_orderMode);
            this.panel1.Controls.Add(this.btn_findMode);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1133, 41);
            this.panel1.TabIndex = 79;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(773, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 85;
            this.label5.Text = "Window Mode:";
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
            this.btn_Back.Size = new System.Drawing.Size(78, 38);
            this.btn_Back.TabIndex = 3;
            this.btn_Back.Text = "BACK";
            this.btn_Back.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_orderMode
            // 
            this.btn_orderMode.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_orderMode.FlatAppearance.BorderSize = 0;
            this.btn_orderMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_orderMode.ForeColor = System.Drawing.Color.White;
            this.btn_orderMode.Location = new System.Drawing.Point(1007, 7);
            this.btn_orderMode.Name = "btn_orderMode";
            this.btn_orderMode.Size = new System.Drawing.Size(112, 27);
            this.btn_orderMode.TabIndex = 83;
            this.btn_orderMode.Text = "Order";
            this.btn_orderMode.UseVisualStyleBackColor = false;
            this.btn_orderMode.Click += new System.EventHandler(this.btn_orderMode_Click);
            // 
            // btn_findMode
            // 
            this.btn_findMode.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_findMode.FlatAppearance.BorderSize = 0;
            this.btn_findMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_findMode.ForeColor = System.Drawing.Color.White;
            this.btn_findMode.Location = new System.Drawing.Point(889, 7);
            this.btn_findMode.Name = "btn_findMode";
            this.btn_findMode.Size = new System.Drawing.Size(112, 27);
            this.btn_findMode.TabIndex = 84;
            this.btn_findMode.Text = "Find";
            this.btn_findMode.UseVisualStyleBackColor = false;
            this.btn_findMode.Click += new System.EventHandler(this.btn_findMode_Click);
            // 
            // pnl_Footer
            // 
            this.pnl_Footer.BackColor = System.Drawing.Color.CadetBlue;
            this.pnl_Footer.Controls.Add(this.lbl_Role);
            this.pnl_Footer.Controls.Add(this.lbl_DateTime);
            this.pnl_Footer.Location = new System.Drawing.Point(-2, 647);
            this.pnl_Footer.Name = "pnl_Footer";
            this.pnl_Footer.Size = new System.Drawing.Size(1132, 33);
            this.pnl_Footer.TabIndex = 80;
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
            this.lbl_DateTime.Location = new System.Drawing.Point(941, 7);
            this.lbl_DateTime.Name = "lbl_DateTime";
            this.lbl_DateTime.Size = new System.Drawing.Size(158, 20);
            this.lbl_DateTime.TabIndex = 3;
            this.lbl_DateTime.Text = "hh:mm January 1, 2018";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(17, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 28);
            this.label1.TabIndex = 81;
            this.label1.Text = "Sales Order";
            // 
            // lbl_FaxNum
            // 
            this.lbl_FaxNum.AutoSize = true;
            this.lbl_FaxNum.Location = new System.Drawing.Point(197, 223);
            this.lbl_FaxNum.Name = "lbl_FaxNum";
            this.lbl_FaxNum.Size = new System.Drawing.Size(84, 20);
            this.lbl_FaxNum.TabIndex = 95;
            this.lbl_FaxNum.Text = "fax number";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(52, 223);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 20);
            this.label12.TabIndex = 94;
            this.label12.Text = "Fax Number:";
            // 
            // lbl_ContactNum
            // 
            this.lbl_ContactNum.AutoSize = true;
            this.lbl_ContactNum.Location = new System.Drawing.Point(197, 194);
            this.lbl_ContactNum.Name = "lbl_ContactNum";
            this.lbl_ContactNum.Size = new System.Drawing.Size(113, 20);
            this.lbl_ContactNum.TabIndex = 93;
            this.lbl_ContactNum.Text = "contact number";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(52, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 20);
            this.label10.TabIndex = 92;
            this.label10.Text = "Contact Number:";
            // 
            // lbl_custAddress
            // 
            this.lbl_custAddress.AutoSize = true;
            this.lbl_custAddress.Location = new System.Drawing.Point(197, 164);
            this.lbl_custAddress.Name = "lbl_custAddress";
            this.lbl_custAddress.Size = new System.Drawing.Size(62, 20);
            this.lbl_custAddress.TabIndex = 91;
            this.lbl_custAddress.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 90;
            this.label7.Text = "Address:";
            // 
            // dtp_orderDate
            // 
            this.dtp_orderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_orderDate.Location = new System.Drawing.Point(775, 165);
            this.dtp_orderDate.Name = "dtp_orderDate";
            this.dtp_orderDate.Size = new System.Drawing.Size(200, 27);
            this.dtp_orderDate.TabIndex = 89;
            // 
            // dtp_docDate
            // 
            this.dtp_docDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_docDate.Location = new System.Drawing.Point(775, 132);
            this.dtp_docDate.Name = "dtp_docDate";
            this.dtp_docDate.Size = new System.Drawing.Size(200, 27);
            this.dtp_docDate.TabIndex = 88;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(627, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 20);
            this.label6.TabIndex = 87;
            this.label6.Text = "Ordering Date:";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("LuloCleanW01-OneBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.Location = new System.Drawing.Point(771, 99);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(71, 23);
            this.lbl_status.TabIndex = 86;
            this.lbl_status.Text = "OPEN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(627, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 85;
            this.label4.Text = "Status:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(627, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 84;
            this.label3.Text = "Document Date:";
            // 
            // tbox_customer
            // 
            this.tbox_customer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbox_customer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbox_customer.Location = new System.Drawing.Point(201, 98);
            this.tbox_customer.Name = "tbox_customer";
            this.tbox_customer.Size = new System.Drawing.Size(233, 27);
            this.tbox_customer.TabIndex = 83;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 82;
            this.label2.Text = "Customer:";
            // 
            // btn_find
            // 
            this.btn_find.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_find.FlatAppearance.BorderSize = 0;
            this.btn_find.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_find.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_find.ForeColor = System.Drawing.Color.White;
            this.btn_find.Location = new System.Drawing.Point(44, 589);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(124, 37);
            this.btn_find.TabIndex = 111;
            this.btn_find.Text = "FIND";
            this.btn_find.UseVisualStyleBackColor = false;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // btn_removeItem
            // 
            this.btn_removeItem.BackColor = System.Drawing.Color.IndianRed;
            this.btn_removeItem.FlatAppearance.BorderSize = 0;
            this.btn_removeItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_removeItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_removeItem.ForeColor = System.Drawing.Color.White;
            this.btn_removeItem.Location = new System.Drawing.Point(978, 245);
            this.btn_removeItem.Name = "btn_removeItem";
            this.btn_removeItem.Size = new System.Drawing.Size(113, 27);
            this.btn_removeItem.TabIndex = 110;
            this.btn_removeItem.Text = "Remove Item";
            this.btn_removeItem.UseVisualStyleBackColor = false;
            // 
            // btn_cancelOrder
            // 
            this.btn_cancelOrder.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_cancelOrder.FlatAppearance.BorderSize = 0;
            this.btn_cancelOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelOrder.Location = new System.Drawing.Point(174, 589);
            this.btn_cancelOrder.Name = "btn_cancelOrder";
            this.btn_cancelOrder.Size = new System.Drawing.Size(94, 37);
            this.btn_cancelOrder.TabIndex = 109;
            this.btn_cancelOrder.Text = "Cancel";
            this.btn_cancelOrder.UseVisualStyleBackColor = false;
            // 
            // lbl_subtotal
            // 
            this.lbl_subtotal.AutoSize = true;
            this.lbl_subtotal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_subtotal.Location = new System.Drawing.Point(1007, 475);
            this.lbl_subtotal.Name = "lbl_subtotal";
            this.lbl_subtotal.Size = new System.Drawing.Size(36, 20);
            this.lbl_subtotal.TabIndex = 108;
            this.lbl_subtotal.Text = "0.00";
            // 
            // lbl_tax
            // 
            this.lbl_tax.AutoSize = true;
            this.lbl_tax.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_tax.Location = new System.Drawing.Point(1007, 502);
            this.lbl_tax.Name = "lbl_tax";
            this.lbl_tax.Size = new System.Drawing.Size(36, 20);
            this.lbl_tax.TabIndex = 107;
            this.lbl_tax.Text = "0.00";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label20.Location = new System.Drawing.Point(907, 477);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 20);
            this.label20.TabIndex = 106;
            this.label20.Text = "Subtotal";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label19.Location = new System.Drawing.Point(942, 502);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(30, 20);
            this.label19.TabIndex = 105;
            this.label19.Text = "Tax";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label17.Location = new System.Drawing.Point(905, 527);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 20);
            this.label17.TabIndex = 104;
            this.label17.Text = "Discount";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_discount
            // 
            this.lbl_discount.AutoSize = true;
            this.lbl_discount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_discount.Location = new System.Drawing.Point(1007, 527);
            this.lbl_discount.Name = "lbl_discount";
            this.lbl_discount.Size = new System.Drawing.Size(36, 20);
            this.lbl_discount.TabIndex = 103;
            this.lbl_discount.Text = "0.00";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(920, 566);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 25);
            this.label16.TabIndex = 102;
            this.label16.Text = "Total";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(1006, 566);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(50, 25);
            this.lbl_total.TabIndex = 101;
            this.lbl_total.Text = "0.00";
            // 
            // btn_addOrder
            // 
            this.btn_addOrder.BackColor = System.Drawing.Color.Teal;
            this.btn_addOrder.FlatAppearance.BorderSize = 0;
            this.btn_addOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addOrder.ForeColor = System.Drawing.Color.White;
            this.btn_addOrder.Location = new System.Drawing.Point(44, 589);
            this.btn_addOrder.Name = "btn_addOrder";
            this.btn_addOrder.Size = new System.Drawing.Size(124, 37);
            this.btn_addOrder.TabIndex = 100;
            this.btn_addOrder.Text = "ADD ORDER";
            this.btn_addOrder.UseVisualStyleBackColor = false;
            // 
            // tbox_notes
            // 
            this.tbox_notes.Location = new System.Drawing.Point(103, 477);
            this.tbox_notes.Multiline = true;
            this.tbox_notes.Name = "tbox_notes";
            this.tbox_notes.Size = new System.Drawing.Size(315, 83);
            this.tbox_notes.TabIndex = 99;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(49, 480);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 20);
            this.label14.TabIndex = 98;
            this.label14.Text = "Notes";
            // 
            // btn_itemView
            // 
            this.btn_itemView.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_itemView.FlatAppearance.BorderSize = 0;
            this.btn_itemView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_itemView.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_itemView.ForeColor = System.Drawing.Color.White;
            this.btn_itemView.Location = new System.Drawing.Point(859, 245);
            this.btn_itemView.Name = "btn_itemView";
            this.btn_itemView.Size = new System.Drawing.Size(113, 27);
            this.btn_itemView.TabIndex = 97;
            this.btn_itemView.Text = "Add Item";
            this.btn_itemView.UseVisualStyleBackColor = false;
            this.btn_itemView.Click += new System.EventHandler(this.btn_itemView_Click);
            // 
            // dgv_salesOrderLine
            // 
            this.dgv_salesOrderLine.AllowUserToAddRows = false;
            this.dgv_salesOrderLine.AllowUserToDeleteRows = false;
            this.dgv_salesOrderLine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_salesOrderLine.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_salesOrderLine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_salesOrderLine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemID,
            this.clmn_poItemCode,
            this.clmn_poItemDescription,
            this.clmn_unit,
            this.clmn_poQuantity,
            this.clmn_poItemPrice});
            this.dgv_salesOrderLine.Location = new System.Drawing.Point(44, 278);
            this.dgv_salesOrderLine.Name = "dgv_salesOrderLine";
            this.dgv_salesOrderLine.RowHeadersVisible = false;
            this.dgv_salesOrderLine.RowTemplate.Height = 24;
            this.dgv_salesOrderLine.Size = new System.Drawing.Size(1047, 185);
            this.dgv_salesOrderLine.TabIndex = 96;
            // 
            // itemID
            // 
            this.itemID.HeaderText = "ID";
            this.itemID.Name = "itemID";
            this.itemID.Visible = false;
            // 
            // clmn_poItemCode
            // 
            this.clmn_poItemCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clmn_poItemCode.HeaderText = "Item Code";
            this.clmn_poItemCode.Name = "clmn_poItemCode";
            this.clmn_poItemCode.Width = 107;
            // 
            // clmn_poItemDescription
            // 
            this.clmn_poItemDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmn_poItemDescription.HeaderText = "Item Description";
            this.clmn_poItemDescription.Name = "clmn_poItemDescription";
            // 
            // clmn_unit
            // 
            this.clmn_unit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clmn_unit.HeaderText = "Unit";
            this.clmn_unit.Name = "clmn_unit";
            this.clmn_unit.Width = 65;
            // 
            // clmn_poQuantity
            // 
            this.clmn_poQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clmn_poQuantity.HeaderText = "Quantity";
            this.clmn_poQuantity.Name = "clmn_poQuantity";
            this.clmn_poQuantity.Width = 94;
            // 
            // clmn_poItemPrice
            // 
            this.clmn_poItemPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clmn_poItemPrice.HeaderText = "Item Price";
            this.clmn_poItemPrice.Name = "clmn_poItemPrice";
            this.clmn_poItemPrice.Width = 104;
            // 
            // lbl_contactPerson
            // 
            this.lbl_contactPerson.AutoSize = true;
            this.lbl_contactPerson.Location = new System.Drawing.Point(197, 136);
            this.lbl_contactPerson.Name = "lbl_contactPerson";
            this.lbl_contactPerson.Size = new System.Drawing.Size(52, 20);
            this.lbl_contactPerson.TabIndex = 113;
            this.lbl_contactPerson.Text = "Person";
            this.lbl_contactPerson.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(52, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 20);
            this.label9.TabIndex = 112;
            this.label9.Text = "Contact Person:";
            // 
            // formSalesOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 679);
            this.Controls.Add(this.lbl_contactPerson);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_find);
            this.Controls.Add(this.btn_removeItem);
            this.Controls.Add(this.btn_cancelOrder);
            this.Controls.Add(this.lbl_subtotal);
            this.Controls.Add(this.lbl_tax);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lbl_discount);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.btn_addOrder);
            this.Controls.Add(this.tbox_notes);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btn_itemView);
            this.Controls.Add(this.dgv_salesOrderLine);
            this.Controls.Add(this.lbl_FaxNum);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbl_ContactNum);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbl_custAddress);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtp_orderDate);
            this.Controls.Add(this.dtp_docDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbox_customer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnl_Footer);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formSalesOrder";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Management - Sales Order";
            this.Load += new System.EventHandler(this.formSalesOrder_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_Footer.ResumeLayout(false);
            this.pnl_Footer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_salesOrderLine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Panel pnl_Footer;
        private System.Windows.Forms.Label lbl_Role;
        private System.Windows.Forms.Label lbl_DateTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_orderMode;
        private System.Windows.Forms.Button btn_findMode;
        private System.Windows.Forms.Label lbl_FaxNum;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_ContactNum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_custAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtp_orderDate;
        private System.Windows.Forms.DateTimePicker dtp_docDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbox_customer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.Button btn_removeItem;
        private System.Windows.Forms.Button btn_cancelOrder;
        private System.Windows.Forms.Label lbl_subtotal;
        private System.Windows.Forms.Label lbl_tax;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbl_discount;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Button btn_addOrder;
        private System.Windows.Forms.TextBox tbox_notes;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_itemView;
        private System.Windows.Forms.DataGridView dgv_salesOrderLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_poItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_poItemDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_poQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_poItemPrice;
        private System.Windows.Forms.Label lbl_contactPerson;
        private System.Windows.Forms.Label label9;
    }
}