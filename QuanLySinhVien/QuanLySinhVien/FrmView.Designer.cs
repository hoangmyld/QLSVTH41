namespace QuanLySinhVien
{
    partial class FrmView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmView));
            this.bttim = new System.Windows.Forms.Button();
            this.txttim = new System.Windows.Forms.TextBox();
            this.btthoat = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvdiemtonghop = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvdiemhocki = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbhoten = new System.Windows.Forms.Label();
            this.lbsdt = new System.Windows.Forms.Label();
            this.lbdc = new System.Windows.Forms.Label();
            this.lbgt = new System.Windows.Forms.Label();
            this.lbemail = new System.Windows.Forms.Label();
            this.lbmanganh = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdiemtonghop)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdiemhocki)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttim
            // 
            this.bttim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttim.Location = new System.Drawing.Point(635, 81);
            this.bttim.Name = "bttim";
            this.bttim.Size = new System.Drawing.Size(134, 57);
            this.bttim.TabIndex = 0;
            this.bttim.Text = "Tìm kiếm sinh viên";
            this.bttim.UseVisualStyleBackColor = true;
            this.bttim.Click += new System.EventHandler(this.bttim_Click);
            // 
            // txttim
            // 
            this.txttim.Location = new System.Drawing.Point(635, 41);
            this.txttim.MaxLength = 4;
            this.txttim.Multiline = true;
            this.txttim.Name = "txttim";
            this.txttim.Size = new System.Drawing.Size(134, 34);
            this.txttim.TabIndex = 2;
            this.txttim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttim_KeyPress);
            // 
            // btthoat
            // 
            this.btthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthoat.Location = new System.Drawing.Point(635, 342);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(134, 57);
            this.btthoat.TabIndex = 3;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvdiemtonghop);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(613, 488);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Xem điểm thi tổng hợp";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvdiemtonghop
            // 
            this.dgvdiemtonghop.BackgroundColor = System.Drawing.Color.White;
            this.dgvdiemtonghop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdiemtonghop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvdiemtonghop.Location = new System.Drawing.Point(3, 3);
            this.dgvdiemtonghop.Name = "dgvdiemtonghop";
            this.dgvdiemtonghop.Size = new System.Drawing.Size(607, 482);
            this.dgvdiemtonghop.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvdiemhocki);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(613, 488);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Xem điểm thi học kì";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvdiemhocki
            // 
            this.dgvdiemhocki.BackgroundColor = System.Drawing.Color.White;
            this.dgvdiemhocki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdiemhocki.Location = new System.Drawing.Point(6, 6);
            this.dgvdiemhocki.Name = "dgvdiemhocki";
            this.dgvdiemhocki.Size = new System.Drawing.Size(604, 229);
            this.dgvdiemhocki.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lbmanganh);
            this.tabPage1.Controls.Add(this.lbemail);
            this.tabPage1.Controls.Add(this.lbgt);
            this.tabPage1.Controls.Add(this.lbdc);
            this.tabPage1.Controls.Add(this.lbsdt);
            this.tabPage1.Controls.Add(this.lbhoten);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(613, 488);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Xem thông tin sinh viên";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbhoten
            // 
            this.lbhoten.BackColor = System.Drawing.Color.White;
            this.lbhoten.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbhoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbhoten.Location = new System.Drawing.Point(458, 40);
            this.lbhoten.Name = "lbhoten";
            this.lbhoten.Size = new System.Drawing.Size(149, 41);
            this.lbhoten.TabIndex = 0;
            this.lbhoten.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbhoten.Click += new System.EventHandler(this.lbhoten_Click);
            // 
            // lbsdt
            // 
            this.lbsdt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbsdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsdt.Location = new System.Drawing.Point(458, 104);
            this.lbsdt.Name = "lbsdt";
            this.lbsdt.Size = new System.Drawing.Size(149, 41);
            this.lbsdt.TabIndex = 1;
            this.lbsdt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbdc
            // 
            this.lbdc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbdc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdc.Location = new System.Drawing.Point(458, 174);
            this.lbdc.Name = "lbdc";
            this.lbdc.Size = new System.Drawing.Size(149, 42);
            this.lbdc.TabIndex = 2;
            this.lbdc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbgt
            // 
            this.lbgt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbgt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbgt.Location = new System.Drawing.Point(458, 270);
            this.lbgt.Name = "lbgt";
            this.lbgt.Size = new System.Drawing.Size(149, 41);
            this.lbgt.TabIndex = 3;
            this.lbgt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbemail
            // 
            this.lbemail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbemail.Location = new System.Drawing.Point(458, 350);
            this.lbemail.Name = "lbemail";
            this.lbemail.Size = new System.Drawing.Size(149, 41);
            this.lbemail.TabIndex = 4;
            this.lbemail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbmanganh
            // 
            this.lbmanganh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbmanganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmanganh.Location = new System.Drawing.Point(458, 419);
            this.lbmanganh.Name = "lbmanganh";
            this.lbmanganh.Size = new System.Drawing.Size(149, 42);
            this.lbmanganh.TabIndex = 5;
            this.lbmanganh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(360, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 46);
            this.label1.TabIndex = 6;
            this.label1.Text = "Họ và tên";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(360, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 41);
            this.label2.TabIndex = 7;
            this.label2.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(360, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 49);
            this.label3.TabIndex = 8;
            this.label3.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(360, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 30);
            this.label4.TabIndex = 9;
            this.label4.Text = "Giới tính";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(360, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 36);
            this.label5.TabIndex = 10;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(360, 419);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 49);
            this.label6.TabIndex = 11;
            this.label6.Text = "Mã ngành";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(33, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 232);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(621, 521);
            this.tabControl1.TabIndex = 1;
            // 
            // FrmView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 530);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.txttim);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.bttim);
            this.Name = "FrmView";
            this.Text = "FrmView";
            this.Load += new System.EventHandler(this.FrmView_Load);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdiemtonghop)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdiemhocki)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttim;
        private System.Windows.Forms.TextBox txttim;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvdiemtonghop;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvdiemhocki;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbmanganh;
        private System.Windows.Forms.Label lbemail;
        private System.Windows.Forms.Label lbgt;
        private System.Windows.Forms.Label lbdc;
        private System.Windows.Forms.Label lbsdt;
        private System.Windows.Forms.Label lbhoten;
        private System.Windows.Forms.TabControl tabControl1;

    }
}