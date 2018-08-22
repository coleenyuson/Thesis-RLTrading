namespace Thesis_Rillan_Trading
{
    partial class formLogin
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
            this.components = new System.ComponentModel.Container();
            this.tbox_Username = new System.Windows.Forms.TextBox();
            this.tbox_Password = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_dateTime = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbox_Username
            // 
            this.tbox_Username.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbox_Username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbox_Username.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.tbox_Username.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_Username.ForeColor = System.Drawing.Color.Teal;
            this.tbox_Username.Location = new System.Drawing.Point(239, 44);
            this.tbox_Username.Name = "tbox_Username";
            this.tbox_Username.Size = new System.Drawing.Size(195, 30);
            this.tbox_Username.TabIndex = 2;
            this.tbox_Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbox_Username.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbox_Username_MouseClick);
            // 
            // tbox_Password
            // 
            this.tbox_Password.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbox_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbox_Password.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_Password.ForeColor = System.Drawing.Color.Teal;
            this.tbox_Password.Location = new System.Drawing.Point(239, 80);
            this.tbox_Password.Name = "tbox_Password";
            this.tbox_Password.PasswordChar = '●';
            this.tbox_Password.Size = new System.Drawing.Size(195, 30);
            this.tbox_Password.TabIndex = 5;
            this.tbox_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbox_Password.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbox_Password_MouseClick);
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.Teal;
            this.btn_Login.FlatAppearance.BorderSize = 0;
            this.btn_Login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.btn_Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_Login.Location = new System.Drawing.Point(75, 148);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(359, 35);
            this.btn_Login.TabIndex = 7;
            this.btn_Login.Text = "LOGIN";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.lbl_username.ForeColor = System.Drawing.Color.Teal;
            this.lbl_username.Location = new System.Drawing.Point(71, 50);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(100, 23);
            this.lbl_username.TabIndex = 8;
            this.lbl_username.Text = "USERNAME";
            this.lbl_username.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.lbl_password.ForeColor = System.Drawing.Color.Teal;
            this.lbl_password.Location = new System.Drawing.Point(71, 86);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(100, 23);
            this.lbl_password.TabIndex = 9;
            this.lbl_password.Text = "PASSWORD";
            this.lbl_password.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.lbl_dateTime);
            this.panel1.Location = new System.Drawing.Point(0, 224);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 36);
            this.panel1.TabIndex = 10;
            // 
            // lbl_dateTime
            // 
            this.lbl_dateTime.AutoSize = true;
            this.lbl_dateTime.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.lbl_dateTime.ForeColor = System.Drawing.Color.Snow;
            this.lbl_dateTime.Location = new System.Drawing.Point(280, 7);
            this.lbl_dateTime.Name = "lbl_dateTime";
            this.lbl_dateTime.Size = new System.Drawing.Size(83, 23);
            this.lbl_dateTime.TabIndex = 11;
            this.lbl_dateTime.Text = "time date";
            this.lbl_dateTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // formLogin
            // 
            this.AcceptButton = this.btn_Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(506, 257);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.tbox_Password);
            this.Controls.Add(this.tbox_Username);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rillan Trading";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formLogin_FormClosing);
            this.Load += new System.EventHandler(this.formLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbox_Username;
        private System.Windows.Forms.TextBox tbox_Password;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_dateTime;
        private System.Windows.Forms.Timer timer;
    }
}

