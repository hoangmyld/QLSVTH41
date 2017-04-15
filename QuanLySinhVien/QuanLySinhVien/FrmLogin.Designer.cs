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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.rdView = new System.Windows.Forms.RadioButton();
            this.rdStudent = new System.Windows.Forms.RadioButton();
            this.rdQTV = new System.Windows.Forms.RadioButton();
            this.btLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(600, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chào mừng bạn đến với chương trình Quản lý Sinh Viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(280, 133);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(195, 26);
            this.txtID.TabIndex = 2;
            this.txtID.Text = "id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Enabled = false;
            this.txtPassword.Location = new System.Drawing.Point(280, 183);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(195, 26);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "123";
            // 
            // rdView
            // 
            this.rdView.AutoSize = true;
            this.rdView.Checked = true;
            this.rdView.Location = new System.Drawing.Point(83, 238);
            this.rdView.Name = "rdView";
            this.rdView.Size = new System.Drawing.Size(126, 24);
            this.rdView.TabIndex = 3;
            this.rdView.TabStop = true;
            this.rdView.Text = "Xem thông tin";
            this.rdView.UseVisualStyleBackColor = true;
            this.rdView.CheckedChanged += new System.EventHandler(this.rdView_CheckedChanged);
            // 
            // rdStudent
            // 
            this.rdStudent.AutoSize = true;
            this.rdStudent.Location = new System.Drawing.Point(265, 238);
            this.rdStudent.Name = "rdStudent";
            this.rdStudent.Size = new System.Drawing.Size(95, 24);
            this.rdStudent.TabIndex = 3;
            this.rdStudent.Text = "Sinh Viên";
            this.rdStudent.UseVisualStyleBackColor = true;
            this.rdStudent.CheckedChanged += new System.EventHandler(this.rdStudent_CheckedChanged);
            // 
            // rdQTV
            // 
            this.rdQTV.AutoSize = true;
            this.rdQTV.Location = new System.Drawing.Point(412, 238);
            this.rdQTV.Name = "rdQTV";
            this.rdQTV.Size = new System.Drawing.Size(115, 24);
            this.rdQTV.TabIndex = 3;
            this.rdQTV.Text = "Quản trị viên";
            this.rdQTV.UseVisualStyleBackColor = true;
            this.rdQTV.CheckedChanged += new System.EventHandler(this.rdQTV_CheckedChanged);
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(213, 294);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(170, 54);
            this.btLogin.TabIndex = 4;
            this.btLogin.Text = "Đăng Nhập";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 371);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.rdQTV);
            this.Controls.Add(this.rdStudent);
            this.Controls.Add(this.rdView);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}