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
            this.label1 = new System.Windows.Forms.Label();
            this.btLogin = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdQTV = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.rdView = new System.Windows.Forms.RadioButton();
            this.rdStudent = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::QuanLySinhVien.Properties.Resources.SX0PQZBD0_T3_theme_background;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btThoat);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btLogin);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rdQTV);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.rdView);
            this.panel1.Controls.Add(this.rdStudent);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 412);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btThoat
            // 
            this.btThoat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btThoat.BackColor = System.Drawing.Color.Lavender;
            this.btThoat.Location = new System.Drawing.Point(320, 259);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(178, 54);
            this.btThoat.TabIndex = 5;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SkyBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(590, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chào mừng bạn đến với chương trình Quản lý Sinh Viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btLogin
            // 
            this.btLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btLogin.BackColor = System.Drawing.Color.Lavender;
            this.btLogin.Location = new System.Drawing.Point(79, 259);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(170, 54);
            this.btLogin.TabIndex = 4;
            this.btLogin.Text = "Đăng Nhập";
            this.btLogin.UseVisualStyleBackColor = false;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtID.BackColor = System.Drawing.Color.Lavender;
            this.txtID.Location = new System.Drawing.Point(261, 71);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(195, 26);
            this.txtID.TabIndex = 2;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.BackColor = System.Drawing.Color.Lavender;
            this.txtPassword.Enabled = false;
            this.txtPassword.Location = new System.Drawing.Point(261, 120);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(195, 26);
            this.txtPassword.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Lavender;
            this.label2.Location = new System.Drawing.Point(153, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // rdQTV
            // 
            this.rdQTV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdQTV.AutoSize = true;
            this.rdQTV.BackColor = System.Drawing.Color.Lavender;
            this.rdQTV.Location = new System.Drawing.Point(383, 184);
            this.rdQTV.Name = "rdQTV";
            this.rdQTV.Size = new System.Drawing.Size(115, 24);
            this.rdQTV.TabIndex = 3;
            this.rdQTV.Text = "Quản trị viên";
            this.rdQTV.UseVisualStyleBackColor = false;
            this.rdQTV.CheckedChanged += new System.EventHandler(this.rdQTV_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Lavender;
            this.label3.Location = new System.Drawing.Point(153, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password";
            // 
            // rdView
            // 
            this.rdView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdView.AutoSize = true;
            this.rdView.BackColor = System.Drawing.Color.Lavender;
            this.rdView.Checked = true;
            this.rdView.Location = new System.Drawing.Point(79, 184);
            this.rdView.Name = "rdView";
            this.rdView.Size = new System.Drawing.Size(126, 24);
            this.rdView.TabIndex = 3;
            this.rdView.TabStop = true;
            this.rdView.Text = "Xem thông tin";
            this.rdView.UseVisualStyleBackColor = false;
            this.rdView.CheckedChanged += new System.EventHandler(this.rdView_CheckedChanged);
            // 
            // rdStudent
            // 
            this.rdStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdStudent.AutoSize = true;
            this.rdStudent.BackColor = System.Drawing.Color.Lavender;
            this.rdStudent.Location = new System.Drawing.Point(247, 184);
            this.rdStudent.Name = "rdStudent";
            this.rdStudent.Size = new System.Drawing.Size(95, 24);
            this.rdStudent.TabIndex = 3;
            this.rdStudent.Text = "Sinh Viên";
            this.rdStudent.UseVisualStyleBackColor = false;
            this.rdStudent.CheckedChanged += new System.EventHandler(this.rdStudent_CheckedChanged);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 412);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.RadioButton rdView;
        private System.Windows.Forms.RadioButton rdStudent;
        private System.Windows.Forms.RadioButton rdQTV;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btThoat;
    }
}