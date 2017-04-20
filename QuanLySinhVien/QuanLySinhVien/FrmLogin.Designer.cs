namespace QuanLySinhVien
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btThoat = new System.Windows.Forms.Button();
            this.btLogin = new System.Windows.Forms.Button();
            this.rdQTV = new System.Windows.Forms.RadioButton();
            this.rdStudent = new System.Windows.Forms.RadioButton();
            this.rdView = new System.Windows.Forms.RadioButton();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::QuanLySinhVien.Properties.Resources.SX0PQZBD0_T3_theme_background;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btThoat);
            this.panel1.Controls.Add(this.btLogin);
            this.panel1.Controls.Add(this.rdQTV);
            this.panel1.Controls.Add(this.rdStudent);
            this.panel1.Controls.Add(this.rdView);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(658, 425);
            this.panel1.TabIndex = 0;
            // 
            // btThoat
            // 
            this.btThoat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btThoat.BackColor = System.Drawing.Color.Transparent;
            this.btThoat.Location = new System.Drawing.Point(364, 341);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(104, 43);
            this.btThoat.TabIndex = 6;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btLogin
            // 
            this.btLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btLogin.BackColor = System.Drawing.Color.Transparent;
            this.btLogin.Location = new System.Drawing.Point(168, 341);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(104, 43);
            this.btLogin.TabIndex = 5;
            this.btLogin.Text = "Đăng Nhập";
            this.btLogin.UseVisualStyleBackColor = false;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // rdQTV
            // 
            this.rdQTV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdQTV.AutoSize = true;
            this.rdQTV.BackColor = System.Drawing.Color.Transparent;
            this.rdQTV.Location = new System.Drawing.Point(456, 275);
            this.rdQTV.Name = "rdQTV";
            this.rdQTV.Size = new System.Drawing.Size(123, 24);
            this.rdQTV.TabIndex = 4;
            this.rdQTV.Text = "Quản Trị Viên";
            this.rdQTV.UseVisualStyleBackColor = false;
            this.rdQTV.CheckedChanged += new System.EventHandler(this.rdQTV_CheckedChanged);
            // 
            // rdStudent
            // 
            this.rdStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdStudent.AutoSize = true;
            this.rdStudent.BackColor = System.Drawing.Color.Transparent;
            this.rdStudent.Location = new System.Drawing.Point(283, 275);
            this.rdStudent.Name = "rdStudent";
            this.rdStudent.Size = new System.Drawing.Size(95, 24);
            this.rdStudent.TabIndex = 3;
            this.rdStudent.Text = "Sinh Viên";
            this.rdStudent.UseVisualStyleBackColor = false;
            this.rdStudent.CheckedChanged += new System.EventHandler(this.rdStudent_CheckedChanged);
            // 
            // rdView
            // 
            this.rdView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdView.AutoSize = true;
            this.rdView.BackColor = System.Drawing.Color.Transparent;
            this.rdView.Checked = true;
            this.rdView.Location = new System.Drawing.Point(101, 275);
            this.rdView.Name = "rdView";
            this.rdView.Size = new System.Drawing.Size(126, 24);
            this.rdView.TabIndex = 2;
            this.rdView.TabStop = true;
            this.rdView.Text = "Xem thông tin";
            this.rdView.UseVisualStyleBackColor = false;
            this.rdView.CheckedChanged += new System.EventHandler(this.rdView_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.BackColor = System.Drawing.Color.Cyan;
            this.txtPassword.Location = new System.Drawing.Point(310, 183);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(158, 26);
            this.txtPassword.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtID.BackColor = System.Drawing.Color.Cyan;
            this.txtID.Location = new System.Drawing.Point(310, 141);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(158, 26);
            this.txtID.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(173, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(173, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(656, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trình Quản Lí Sinh Viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 425);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.RadioButton rdQTV;
        private System.Windows.Forms.RadioButton rdStudent;
        private System.Windows.Forms.RadioButton rdView;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}