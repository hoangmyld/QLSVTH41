namespace QuanLySinhVien
{
    partial class FrmStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStudent));
            this.tabSinhVien = new System.Windows.Forms.TabControl();
            this.tab = new System.Windows.Forms.TabPage();
            this.lvDangKi = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvHienThi = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btThoat = new System.Windows.Forms.Button();
            this.btLamMoi = new System.Windows.Forms.Button();
            this.btDangKi = new System.Windows.Forms.Button();
            this.btpush = new System.Windows.Forms.Button();
            this.btPull = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdDangKo = new System.Windows.Forms.RadioButton();
            this.rdXem = new System.Windows.Forms.RadioButton();
            this.ckNganh = new System.Windows.Forms.CheckBox();
            this.ckBan = new System.Windows.Forms.CheckBox();
            this.btLoc = new System.Windows.Forms.Button();
            this.cbNganh = new System.Windows.Forms.ComboBox();
            this.cbBan = new System.Windows.Forms.ComboBox();
            this.cbHocKi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbKQ = new System.Windows.Forms.RichTextBox();
            this.tabSinhVien.SuspendLayout();
            this.tab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabSinhVien
            // 
            this.tabSinhVien.Controls.Add(this.tab);
            this.tabSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSinhVien.Location = new System.Drawing.Point(0, 0);
            this.tabSinhVien.Name = "tabSinhVien";
            this.tabSinhVien.SelectedIndex = 0;
            this.tabSinhVien.Size = new System.Drawing.Size(784, 538);
            this.tabSinhVien.TabIndex = 0;
            // 
            // tab
            // 
            this.tab.Controls.Add(this.rtbKQ);
            this.tab.Controls.Add(this.lvDangKi);
            this.tab.Controls.Add(this.lvHienThi);
            this.tab.Controls.Add(this.groupBox2);
            this.tab.Controls.Add(this.btpush);
            this.tab.Controls.Add(this.btPull);
            this.tab.Controls.Add(this.groupBox1);
            this.tab.Location = new System.Drawing.Point(4, 22);
            this.tab.Name = "tab";
            this.tab.Padding = new System.Windows.Forms.Padding(3);
            this.tab.Size = new System.Drawing.Size(776, 512);
            this.tab.TabIndex = 1;
            this.tab.Text = "Đăng kí môn học";
            this.tab.UseVisualStyleBackColor = true;
            this.tab.Enter += new System.EventHandler(this.tab_Enter);
            // 
            // lvDangKi
            // 
            this.lvDangKi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader5});
            this.lvDangKi.Location = new System.Drawing.Point(570, 216);
            this.lvDangKi.Name = "lvDangKi";
            this.lvDangKi.Size = new System.Drawing.Size(176, 219);
            this.lvDangKi.TabIndex = 8;
            this.lvDangKi.UseCompatibleStateImageBehavior = false;
            this.lvDangKi.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Mã Lớp";
            this.columnHeader6.Width = 58;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Tên Môn Học";
            this.columnHeader7.Width = 113;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Số Tín Chỉ";
            // 
            // lvHienThi
            // 
            this.lvHienThi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvHienThi.Location = new System.Drawing.Point(8, 211);
            this.lvHienThi.MultiSelect = false;
            this.lvHienThi.Name = "lvHienThi";
            this.lvHienThi.Size = new System.Drawing.Size(468, 224);
            this.lvHienThi.TabIndex = 7;
            this.lvHienThi.UseCompatibleStateImageBehavior = false;
            this.lvHienThi.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã LH";
            this.columnHeader1.Width = 74;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã MH";
            this.columnHeader2.Width = 73;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên MH";
            this.columnHeader3.Width = 177;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "STC";
            this.columnHeader4.Width = 73;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btThoat);
            this.groupBox2.Controls.Add(this.btLamMoi);
            this.groupBox2.Controls.Add(this.btDangKi);
            this.groupBox2.Location = new System.Drawing.Point(23, 446);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(741, 58);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phím điều khiển";
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(454, 19);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(83, 33);
            this.btThoat.TabIndex = 0;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            // 
            // btLamMoi
            // 
            this.btLamMoi.Location = new System.Drawing.Point(328, 19);
            this.btLamMoi.Name = "btLamMoi";
            this.btLamMoi.Size = new System.Drawing.Size(83, 33);
            this.btLamMoi.TabIndex = 0;
            this.btLamMoi.Text = "Làm mới";
            this.btLamMoi.UseVisualStyleBackColor = true;
            this.btLamMoi.Click += new System.EventHandler(this.btLamMoi_Click);
            // 
            // btDangKi
            // 
            this.btDangKi.Location = new System.Drawing.Point(202, 19);
            this.btDangKi.Name = "btDangKi";
            this.btDangKi.Size = new System.Drawing.Size(83, 33);
            this.btDangKi.TabIndex = 0;
            this.btDangKi.Text = "Đăng kí";
            this.btDangKi.UseVisualStyleBackColor = true;
            this.btDangKi.Click += new System.EventHandler(this.btDangKi_Click);
            // 
            // btpush
            // 
            this.btpush.Location = new System.Drawing.Point(498, 336);
            this.btpush.Name = "btpush";
            this.btpush.Size = new System.Drawing.Size(61, 33);
            this.btpush.TabIndex = 5;
            this.btpush.Text = "<<<<<<<";
            this.btpush.UseVisualStyleBackColor = true;
            this.btpush.Click += new System.EventHandler(this.btpush_Click);
            // 
            // btPull
            // 
            this.btPull.Location = new System.Drawing.Point(498, 269);
            this.btPull.Name = "btPull";
            this.btPull.Size = new System.Drawing.Size(61, 33);
            this.btPull.TabIndex = 5;
            this.btPull.Text = ">>>>>";
            this.btPull.UseVisualStyleBackColor = true;
            this.btPull.Click += new System.EventHandler(this.btPull_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdDangKo);
            this.groupBox1.Controls.Add(this.rdXem);
            this.groupBox1.Controls.Add(this.ckNganh);
            this.groupBox1.Controls.Add(this.ckBan);
            this.groupBox1.Controls.Add(this.btLoc);
            this.groupBox1.Controls.Add(this.cbNganh);
            this.groupBox1.Controls.Add(this.cbBan);
            this.groupBox1.Controls.Add(this.cbHocKi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(28, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 188);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bộ lọc";
            // 
            // rdDangKo
            // 
            this.rdDangKo.AutoSize = true;
            this.rdDangKo.Checked = true;
            this.rdDangKo.Location = new System.Drawing.Point(150, 168);
            this.rdDangKo.Name = "rdDangKo";
            this.rdDangKo.Size = new System.Drawing.Size(57, 17);
            this.rdDangKo.TabIndex = 4;
            this.rdDangKo.TabStop = true;
            this.rdDangKo.Text = "DKMH";
            this.rdDangKo.UseVisualStyleBackColor = true;
            this.rdDangKo.CheckedChanged += new System.EventHandler(this.rdDangKo_CheckedChanged);
            // 
            // rdXem
            // 
            this.rdXem.AutoSize = true;
            this.rdXem.Location = new System.Drawing.Point(150, 145);
            this.rdXem.Name = "rdXem";
            this.rdXem.Size = new System.Drawing.Size(67, 17);
            this.rdXem.TabIndex = 4;
            this.rdXem.Text = "XemTKB";
            this.rdXem.UseVisualStyleBackColor = true;
            this.rdXem.CheckedChanged += new System.EventHandler(this.rdXem_CheckedChanged);
            // 
            // ckNganh
            // 
            this.ckNganh.AutoSize = true;
            this.ckNganh.Location = new System.Drawing.Point(265, 112);
            this.ckNganh.Name = "ckNganh";
            this.ckNganh.Size = new System.Drawing.Size(15, 14);
            this.ckNganh.TabIndex = 3;
            this.ckNganh.UseVisualStyleBackColor = true;
            // 
            // ckBan
            // 
            this.ckBan.AutoSize = true;
            this.ckBan.Location = new System.Drawing.Point(265, 68);
            this.ckBan.Name = "ckBan";
            this.ckBan.Size = new System.Drawing.Size(15, 14);
            this.ckBan.TabIndex = 3;
            this.ckBan.UseVisualStyleBackColor = true;
            // 
            // btLoc
            // 
            this.btLoc.Location = new System.Drawing.Point(29, 145);
            this.btLoc.Name = "btLoc";
            this.btLoc.Size = new System.Drawing.Size(83, 37);
            this.btLoc.TabIndex = 2;
            this.btLoc.Text = "Lọc";
            this.btLoc.UseVisualStyleBackColor = true;
            this.btLoc.Click += new System.EventHandler(this.btLoc_Click);
            // 
            // cbNganh
            // 
            this.cbNganh.FormattingEnabled = true;
            this.cbNganh.Location = new System.Drawing.Point(127, 109);
            this.cbNganh.Name = "cbNganh";
            this.cbNganh.Size = new System.Drawing.Size(113, 21);
            this.cbNganh.TabIndex = 1;
            // 
            // cbBan
            // 
            this.cbBan.FormattingEnabled = true;
            this.cbBan.Location = new System.Drawing.Point(127, 65);
            this.cbBan.Name = "cbBan";
            this.cbBan.Size = new System.Drawing.Size(113, 21);
            this.cbBan.TabIndex = 1;
            // 
            // cbHocKi
            // 
            this.cbHocKi.FormattingEnabled = true;
            this.cbHocKi.Location = new System.Drawing.Point(127, 21);
            this.cbHocKi.Name = "cbHocKi";
            this.cbHocKi.Size = new System.Drawing.Size(140, 21);
            this.cbHocKi.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(26, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã Ngành";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(26, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Ban";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã học kì";
            // 
            // rtbKQ
            // 
            this.rtbKQ.Location = new System.Drawing.Point(357, 13);
            this.rtbKQ.Name = "rtbKQ";
            this.rtbKQ.Size = new System.Drawing.Size(388, 177);
            this.rtbKQ.TabIndex = 9;
            this.rtbKQ.Text = "";
            // 
            // FrmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 538);
            this.Controls.Add(this.tabSinhVien);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmStudent";
            this.Load += new System.EventHandler(this.FrmStudent_Load);
            this.tabSinhVien.ResumeLayout(false);
            this.tab.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabSinhVien;
        private System.Windows.Forms.TabPage tab;
        private System.Windows.Forms.ListView lvDangKi;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ListView lvHienThi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btLamMoi;
        private System.Windows.Forms.Button btDangKi;
        private System.Windows.Forms.Button btpush;
        private System.Windows.Forms.Button btPull;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckNganh;
        private System.Windows.Forms.CheckBox ckBan;
        private System.Windows.Forms.Button btLoc;
        private System.Windows.Forms.ComboBox cbNganh;
        private System.Windows.Forms.ComboBox cbBan;
        private System.Windows.Forms.ComboBox cbHocKi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdDangKo;
        private System.Windows.Forms.RadioButton rdXem;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.RichTextBox rtbKQ;

    }
}