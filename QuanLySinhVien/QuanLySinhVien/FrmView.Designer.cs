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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbmanganh = new System.Windows.Forms.Label();
            this.lbemail = new System.Windows.Forms.Label();
            this.lbgt = new System.Windows.Forms.Label();
            this.lbdc = new System.Windows.Forms.Label();
            this.lbsdt = new System.Windows.Forms.Label();
            this.lbhoten = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvdiemhocki = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvdiemtonghop = new System.Windows.Forms.DataGridView();
            this.txttim = new System.Windows.Forms.TextBox();
            this.btthoat = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdiemhocki)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdiemtonghop)).BeginInit();
            this.SuspendLayout();
            // 
            // bttim
            // 
            this.bttim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttim.BackgroundImage = global::QuanLySinhVien.Properties.Resources._1492389601_Search;
            this.bttim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bttim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttim.Location = new System.Drawing.Point(570, 75);
            this.bttim.Name = "bttim";
            this.bttim.Size = new System.Drawing.Size(66, 53);
            this.bttim.TabIndex = 2;
            this.bttim.UseVisualStyleBackColor = true;
            this.bttim.Click += new System.EventHandler(this.bttim_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(796, 530);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::QuanLySinhVien.Properties.Resources.SX0PQZBD0_T3_theme_background;
            this.tabPage1.Controls.Add(this.btthoat);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txttim);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.bttim);
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
            this.tabPage1.Size = new System.Drawing.Size(788, 497);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Xem thông tin sinh viên";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.Location = new System.Drawing.Point(47, 420);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 30);
            this.label6.TabIndex = 11;
            this.label6.Text = "Mã ngành";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Location = new System.Drawing.Point(47, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 36);
            this.label5.TabIndex = 10;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Location = new System.Drawing.Point(47, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 30);
            this.label4.TabIndex = 9;
            this.label4.Text = "Giới tính";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Location = new System.Drawing.Point(47, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Location = new System.Drawing.Point(47, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "Số điện thoại";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Location = new System.Drawing.Point(47, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Họ và tên";
            // 
            // lbmanganh
            // 
            this.lbmanganh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbmanganh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbmanganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmanganh.Location = new System.Drawing.Point(197, 408);
            this.lbmanganh.Name = "lbmanganh";
            this.lbmanganh.Size = new System.Drawing.Size(149, 42);
            this.lbmanganh.TabIndex = 5;
            this.lbmanganh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbemail
            // 
            this.lbemail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbemail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbemail.Location = new System.Drawing.Point(197, 335);
            this.lbemail.Name = "lbemail";
            this.lbemail.Size = new System.Drawing.Size(218, 41);
            this.lbemail.TabIndex = 4;
            this.lbemail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbgt
            // 
            this.lbgt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbgt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbgt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbgt.Location = new System.Drawing.Point(197, 259);
            this.lbgt.Name = "lbgt";
            this.lbgt.Size = new System.Drawing.Size(149, 41);
            this.lbgt.TabIndex = 3;
            this.lbgt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbdc
            // 
            this.lbdc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbdc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbdc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdc.Location = new System.Drawing.Point(197, 183);
            this.lbdc.Name = "lbdc";
            this.lbdc.Size = new System.Drawing.Size(218, 42);
            this.lbdc.TabIndex = 2;
            this.lbdc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbsdt
            // 
            this.lbsdt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbsdt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbsdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsdt.Location = new System.Drawing.Point(197, 106);
            this.lbsdt.Name = "lbsdt";
            this.lbsdt.Size = new System.Drawing.Size(218, 41);
            this.lbsdt.TabIndex = 1;
            this.lbsdt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbhoten
            // 
            this.lbhoten.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbhoten.BackColor = System.Drawing.Color.Transparent;
            this.lbhoten.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbhoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbhoten.Location = new System.Drawing.Point(197, 36);
            this.lbhoten.Name = "lbhoten";
            this.lbhoten.Size = new System.Drawing.Size(218, 41);
            this.lbhoten.TabIndex = 0;
            this.lbhoten.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbhoten.Click += new System.EventHandler(this.lbhoten_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::QuanLySinhVien.Properties.Resources.SX0PQZBD0_T3_theme_background;
            this.tabPage2.Controls.Add(this.dgvdiemhocki);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(788, 497);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Xem điểm thi học kì";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvdiemhocki
            // 
            this.dgvdiemhocki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdiemhocki.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvdiemhocki.Location = new System.Drawing.Point(3, 3);
            this.dgvdiemhocki.Name = "dgvdiemhocki";
            this.dgvdiemhocki.Size = new System.Drawing.Size(782, 491);
            this.dgvdiemhocki.TabIndex = 10;
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = global::QuanLySinhVien.Properties.Resources.SX0PQZBD0_T3_theme_background;
            this.tabPage3.Controls.Add(this.dgvdiemtonghop);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(788, 497);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Xem điểm thi tổng hợp";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvdiemtonghop
            // 
            this.dgvdiemtonghop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdiemtonghop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvdiemtonghop.Location = new System.Drawing.Point(3, 3);
            this.dgvdiemtonghop.Name = "dgvdiemtonghop";
            this.dgvdiemtonghop.Size = new System.Drawing.Size(782, 491);
            this.dgvdiemtonghop.TabIndex = 0;
            // 
            // txttim
            // 
            this.txttim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txttim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttim.Location = new System.Drawing.Point(570, 35);
            this.txttim.MaxLength = 4;
            this.txttim.Multiline = true;
            this.txttim.Name = "txttim";
            this.txttim.Size = new System.Drawing.Size(134, 34);
            this.txttim.TabIndex = 1;
            this.txttim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttim_KeyPress);
            // 
            // btthoat
            // 
            this.btthoat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthoat.Location = new System.Drawing.Point(570, 328);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(106, 57);
            this.btthoat.TabIndex = 3;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(567, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Tìm kiếm sinh viên";
            // 
            // FrmView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLySinhVien.Properties.Resources.SX0PQZBD0_T3_theme_background;
            this.ClientSize = new System.Drawing.Size(796, 530);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmView";
            this.Text = "FrmView";
            this.Load += new System.EventHandler(this.FrmView_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdiemhocki)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdiemtonghop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttim;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txttim;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.Label lbhoten;
        private System.Windows.Forms.Label lbmanganh;
        private System.Windows.Forms.Label lbemail;
        private System.Windows.Forms.Label lbgt;
        private System.Windows.Forms.Label lbdc;
        private System.Windows.Forms.Label lbsdt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvdiemhocki;
        private System.Windows.Forms.DataGridView dgvdiemtonghop;
        private System.Windows.Forms.Label label7;

    }
}