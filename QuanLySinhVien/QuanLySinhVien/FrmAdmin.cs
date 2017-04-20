using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Imaging;

using DTO;
using BUS;



namespace QuanLySinhVien
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }
         public List<GV_LH> GetGV_LH()
        {
            try
            {
                string sql = "select * from GV_LH";
                
                return new GV_LHBUS().GetGV_LH(sql);
                }
            catch (Exception ex)
            {

                throw ex;
            }


        }
        public void loadGV_LH()
        {
            dgvGV_LH.DataSource = GetGV_LH();
        }
        public List<Chuyennganh> getchuyennganh()
        {
            try
            {
                string sql = "select * from ChuyenNganh";
                ChuyennganhBUS cn = new ChuyennganhBUS();
                return cn.getchuyennganh(sql);
                }
            catch (Exception ex)
            {

                throw ex;
            }


        }
        public void loadCN()
        {
            dgvcn.DataSource = getchuyennganh();

        }


        public List<SV_LH> GetSV_LH()
        {
            try
            {
                string sql = "Select * from SV_LH";
                SV_LHBus SV_LH = new SV_LHBus();
                return SV_LH.GetSV_LH(sql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void loadSV_LH()
        {
            dgvSV_LH.DataSource = GetSV_LH();
        }
        public List<SV_MH> GetSV_MH()
        {
            try
            {
                string sql = "Select * from SV_MH";
                SV_MHBus SV_MH = new SV_MHBus();
                return SV_MH.GetSV_MH(sql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void loadSV_MH()
        {
            dgvSV_MH.DataSource = GetSV_MH();
        }
       
        public List<LopHoc> GetLH()
        {
            try
            {
                string sql = "Select * from LopHoc";
                LopHocBus LH = new LopHocBus();
                return LH.GetLH(sql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void loadLH()
        {
            dgvLH.DataSource = GetLH();
        }
        public List<SinhVien> getStudent()
        {
            try
            {
                string sql = "select * from SinhVien";
                SinhVien1BUS sv = new SinhVien1BUS();
                return sv.getStudent1(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }
        private void loadMH()
        {
            dgvMH.DataSource = GetMH();
        }
        public List<MonHoc> GetMH()
        {
            try
            {
                string sql = "select * from MonHoc";
                MonHocBus mh = new MonHocBus();
                return mh.GetMH(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }
        private void loadStudent()
        {
            dgvStudent.DataSource = getStudent();
        }

       

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            loadMH();
            loadStudent();
            loadLH();
            loadSV_MH();
            loadSV_LH();
            loadCN();
            loadGV_LH();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            string mamh, tenmh, sotinchi, sotiet, manganh;

            mamh = txtmamh.Text.Trim();
            tenmh = txttenmh.Text.Trim();
            sotinchi = txtsotinchi.Text.Trim();
            sotiet = txtsotiet.Text.Trim();
            manganh = txtmn.Text.Trim();


            MonHoc MH = new MonHoc(mamh, tenmh, sotinchi, sotiet, manganh);

            try
            {
                int i = new MonHocBus().ThemMH(MH);
                if (i == -2)
                {
                    throw new Exception();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dgvMH.DataSource = GetMH();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mamh;
            mamh = txtmamh.Text.Trim();
            try
            {
                int i = new MonHocBus().XoaMH(mamh);
                if (i == -2)
                {
                    throw new Exception();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dgvMH.DataSource = GetMH();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string mamh, tenmh, sotinchi, sotiet, manganh;
            mamh = txtmamh.Text.Trim();
            tenmh = txttenmh.Text.Trim();
            sotinchi = txtsotinchi.Text.Trim();
            sotiet = txtsotiet.Text.Trim();
            manganh = txtmn.Text.Trim();


            MonHoc MH = new MonHoc(mamh, tenmh, sotinchi, sotiet, manganh);

            try
            {
                int i = new MonHocBus().SuaMH(MH);
                if (i == -2)
                {
                    throw new Exception();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dgvMH.DataSource = GetMH();
        }
        string imageLocation = " ";
        private void btTim_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                imageLocation = opf.FileName.ToString();
                pictureBox1.ImageLocation = imageLocation;
            }
        }
        private void btThem_Click_1(object sender, EventArgs e)
        {
            byte[] img = null;
            FileStream streem = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(streem);
            img = brs.ReadBytes((int)streem.Length);
            int masv;
            string ho, ten, sdt, diachi, gioitinh, email, manganh;
            masv = int.Parse(txtMaSV.Text.Trim());
            ho = txtHo.Text.Trim();
            ten = txtTen.Text.Trim();
            sdt = txtSDT.Text.Trim();
            diachi = txtDiaChi.Text.Trim();
            gioitinh = txtGioiTinh.Text.Trim();
            email = txtEmail.Text.Trim();
            manganh = txtMaNganh.Text.Trim();

            SinhVien SV = new SinhVien(masv, ho, ten, sdt, diachi, gioitinh, email, manganh, img);

            try
            {
                int i = new SinhVien1BUS().ThemSV(SV);
                if (i == -2)
                {
                    throw new Exception();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dgvStudent.DataSource = getStudent();
        }

        private void btXoa_Click_1(object sender, EventArgs e)
        {
            int masv;
            masv = int.Parse(txtMaSV.Text.Trim());
            try
            {
                int i = new SinhVien1BUS().XoaSV(masv);
                if (i == -2)
                {
                    throw new Exception();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dgvStudent.DataSource = getStudent();
        }

        private void btSua_Click_1(object sender, EventArgs e)
        {

            byte[] img = null;
            FileStream streem = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(streem);
            img = brs.ReadBytes((int)streem.Length);
            int masv;
            string ho, ten, sdt, diachi, gioitinh, email, manganh;
            masv = int.Parse(txtMaSV.Text.Trim());
            ho = txtHo.Text.Trim();
            ten = txtTen.Text.Trim();
            sdt = txtSDT.Text.Trim();
            diachi = txtDiaChi.Text.Trim();
            gioitinh = txtGioiTinh.Text.Trim();
            email = txtEmail.Text.Trim();
            manganh = txtMaNganh.Text.Trim();
            SinhVien SV = new SinhVien(masv, ho, ten, sdt, diachi, gioitinh, email, manganh, img);

            try
            {
                int i = new SinhVien1BUS().SuaSV(SV);
                if (i == -2)
                {
                    throw new Exception();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dgvStudent.DataSource = getStudent();
        }

        private void btthem1_Click(object sender, EventArgs e)
        {
            int mahk, tinhtrang;
            string mamh, malh;
            DateTime tgbatdau, tgketthuc;
            malh = txtmalop.Text.Trim();
            mamh = txtmh.Text.Trim();
            mahk = int.Parse(txtmahk.Text.Trim());
            tgbatdau = DateTime.Parse(txtBD.Text.Trim());
            tgketthuc = DateTime.Parse(txtKT.Text.Trim());
            tinhtrang = int.Parse(txttinhtrang.Text.Trim());

            LopHoc LH = new LopHoc(malh, mamh, mahk, tgbatdau, tgketthuc, tinhtrang);

            try
            {
                int i = new LopHocBus().ThemLH(LH);
                if (i == -2)
                {
                    throw new Exception();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dgvLH.DataSource = GetLH();
        }

        private void btsua1_Click(object sender, EventArgs e)
        {
            int mahk, tinhtrang;
            string mamh, malh;
            DateTime tgbatdau, tgketthuc;
            malh = txtmalop.Text.Trim();
            mamh = txtmh.Text.Trim();
            mahk = int.Parse(txtmahk.Text.Trim());
            tgbatdau = DateTime.Parse(txtBD.Text.Trim());
            tgketthuc = DateTime.Parse(txtKT.Text.Trim());
            tinhtrang = int.Parse(txttinhtrang.Text.Trim());

            LopHoc LH = new LopHoc(malh, mamh, mahk, tgbatdau, tgketthuc, tinhtrang);

            try
            {
                int i = new LopHocBus().SuaLH(LH);
                if (i == -2)
                {
                    throw new Exception();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dgvLH.DataSource = GetLH();
        }

        private void btxoa1_Click(object sender, EventArgs e)
        {
            string malh ;
            malh = txtmalop.Text.Trim();
            try
            {
                int i = new LopHocBus().XoaLH(malh);
                //if (i == -2)
                //{
                //    throw new Exception();
                //}

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dgvLH.DataSource = GetLH();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int masv;
            string mamh;
            double diem;
            masv = int.Parse(txtmsv.Text.Trim());
            mamh = txtmmh.Text.Trim();
            diem = double.Parse(txtdiem.Text.Trim());

            SV_MH sh = new SV_MH(masv,mamh,diem);

            try
            {
                int i = new SV_MHBus().ThemSV_MH(sh);
                if (i == -2)
                {
                    throw new Exception();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dgvSV_MH.DataSource = GetSV_MH();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            int masv;
            string mamh;
            double diem;
            masv = int.Parse(txtmsv.Text.Trim());
            mamh = txtmmh.Text.Trim();
            diem = double.Parse(txtdiem.Text.Trim());

            SV_MH sh = new SV_MH(masv, mamh, diem);

            try
            {
                int i = new SV_MHBus().SuaSV_MH(sh);
                if (i == -2)
                {
                    throw new Exception();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dgvSV_MH.DataSource = GetSV_MH();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int masv;
            string mamh;
            masv = int.Parse(txtmsv.Text.Trim());
            mamh = txtmsv.Text.Trim();
            
            try
            {
                int i = new SV_MHBus().XoaSV_MH(masv, mamh);
                if (i == -2)
                {
                    throw new Exception();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dgvSV_MH.DataSource = GetSV_MH();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int masv;
            string malh;
            double diemgk,diemck;
            masv = int.Parse(txtmsv1.Text.Trim());
            malh = txtmalh1.Text.Trim();
            diemgk = double.Parse(txtdiemgk.Text.Trim());
            diemck = double.Parse(txtdiemck.Text.Trim());

            SV_LH slh = new SV_LH(masv, malh, diemgk,diemck);

            try
            {
                int i = new SV_LHBus().ThemSV_LH(slh);
                if (i == -2)
                {
                    throw new Exception();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dgvSV_LH.DataSource = GetSV_LH();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int masv;
            string malh;
            double diemgk, diemck;
            masv = int.Parse(txtmsv1.Text.Trim());
            malh = txtmalh1.Text.Trim();
            diemgk = double.Parse(txtdiemgk.Text.Trim());
            diemck = double.Parse(txtdiemck.Text.Trim());

            SV_LH slh = new SV_LH(masv, malh, diemgk, diemck);

            try
            {
                int i = new SV_LHBus().SuaSV_LH(slh);
                if (i == -2)
                {
                    throw new Exception();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dgvSV_LH.DataSource = GetSV_LH();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int masv;
            string malh;
            masv = int.Parse(txtmsv1.Text.Trim());
            malh = txtmalh1.Text.Trim();
            try
            {
                int i = new SV_LHBus().XoaSV_LH(masv,malh);
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dgvSV_LH.DataSource = GetSV_LH();
        }

        private void btaddcn_Click(object sender, EventArgs e)
        {
            try
            {
                string manganh, tennganh;
                manganh = txtmnganh.Text;
                tennganh = txttennganh.Text;
                Chuyennganh cn = new Chuyennganh(manganh, tennganh);
                int i = new ChuyennganhBUS().Addchuyennganh(cn);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            txtmnganh.Clear();
            txttennganh.Clear();
            loadCN();
        }

        private void btxoacn_Click(object sender, EventArgs e)
        {
            try
            {
                string manganh = txtmnganh.Text.Trim();
                int i = new ChuyennganhBUS().xoachuyennganh(manganh);
                txtmnganh.Clear();
                txttennganh.Clear();
                loadCN();
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        private void s_Click(object sender, EventArgs e)
        {
            string macn, tencn;
            macn = txtmnganh.Text;
            tencn = txttennganh.Text;
            Chuyennganh cn = new Chuyennganh(macn, tencn);
            try
            {
                int i = new ChuyennganhBUS().Suachuyennganh(cn);
                if (i == -2)
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            dgvcn.DataSource = getchuyennganh();
            txtmnganh.Clear();
            txttennganh.Clear();
            loadCN();
        }

   
        private void button13_Click(object sender, EventArgs e)
        {
            int magv;
            string malop;
          
            magv = int.Parse(txtgv.Text.Trim());
            malop = txtlh.Text.Trim();
           

            GV_LH sh = new GV_LH(magv, malop);

            try
            {
                int i = new GV_LHBUS().ThemGV_LH(sh);
                if (i == -2)
                {
                    throw new Exception();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dgvGV_LH.DataSource = GetGV_LH();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int magv;
            string malop;

            magv = int.Parse(txtgv.Text.Trim());
            malop = txtlh.Text.Trim();


            GV_LH sh = new GV_LH(magv, malop);

            try
            {
                int i = new GV_LHBUS().SuaGV_LH(sh);
                if (i == -2)
                {
                    throw new Exception();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dgvGV_LH.DataSource = GetGV_LH();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int magv;
            string malh;
            magv = int.Parse(txtgv.Text.Trim());
            malh = txtlh.Text.Trim();
            try
            {
                int i = new GV_LHBUS().XoaGV_LH(magv, malh);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dgvGV_LH.DataSource = GetGV_LH();
        }

      //Giang Vien

        DataTable dtChuyenNganh, dtTeacher;
        
        private void loadTeacher()
        {
            try
            {
                dtTeacher = new GiangVienBUS().getTeacher();
                dgvGiangVien.DataSource = dtTeacher;
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }            
        }
        private void loadChuyenNganh()
        {
            try
            {
                dtChuyenNganh = new GiangVienBUS().getChuyenNganh();
            }
            catch (Exception ex)
            {                
                MessageBox.Show(ex.Message);
            }
        }
        
        private void bindTeacher()
        {            
            txtMaGV_GV.DataBindings.Clear();
            txtMaGV_GV.DataBindings.Add("Text", dtTeacher, "MaGV");
            txtHo_GV.DataBindings.Clear();
            txtHo_GV.DataBindings.Add("Text", dtTeacher, "Ho");
            txtTen_GV.DataBindings.Clear();
            txtTen_GV.DataBindings.Add("Text", dtTeacher, "Ten");
            txtDiaChiGV.DataBindings.Clear();
            txtDiaChiGV.DataBindings.Add("Text", dtTeacher, "DiaChi");
            cbGioiTinhGV.DataBindings.Clear();
            cbGioiTinhGV.DataBindings.Add("Text", dtTeacher, "GioiTinh");
            cbMaNganh_GV.DataBindings.Clear();
            cbMaNganh_GV.DataBindings.Add("Text", dtTeacher, "MaNganh");
        }
        private void tabGiangVien_Enter(object sender, EventArgs e)
        {
            loadTeacher();
            loadChuyenNganh();
            cbMaNganh_GV.DataSource = dtChuyenNganh;
            cbMaNganh_GV.DisplayMember = "TenNganh";
            cbMaNganh_GV.ValueMember = "MaNganh";
            bindTeacher();
        }

        private void rdBindGV_CheckedChanged(object sender, EventArgs e)
        {
            bindTeacher();
        }

        private void rdNoneBindGV_CheckedChanged(object sender, EventArgs e)
        {
            txtMaGV_GV.DataBindings.Clear();
            txtMaGV_GV.Text = "";
            txtHo_GV.DataBindings.Clear();
            txtHo_GV.Text = "";
            txtTen_GV.DataBindings.Clear();
            txtTen_GV.Text = "";
            txtDiaChiGV.DataBindings.Clear();
            txtDiaChiGV.Text = "";
            cbGioiTinhGV.DataBindings.Clear();
            cbGioiTinhGV.SelectedIndex = -1;
            cbMaNganh_GV.DataBindings.Clear();
            cbMaNganh_GV.SelectedIndex = -1;
        }
        private Image ConvertToImg(byte[] arrImg) 
        {
            if (arrImg != null)
            {
                MemoryStream ms = new MemoryStream(arrImg);
                return Image.FromStream(ms);
            }
            return null;
        }
        private byte[] ConvertToByte(Image img)
        {
            if (img != null) 
            {
                MemoryStream ms = new MemoryStream();
                img.Save(ms, ImageFormat.Jpeg);
                byte[] arrImg = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(arrImg, 0, arrImg.Length);
                return arrImg;
            }
            return null;
        }
        private void btThemGV_Click(object sender, EventArgs e)
        {
            try
            {
                int MaGV = int.Parse(txtMaGV_GV.Text);
                string Ho = txtHo_GV.Text,
                    Ten = txtTen_GV.Text,
                    DiaChi = txtDiaChiGV.Text,
                    GioiTinh = cbGioiTinhGV.Text,
                    MaNganh = cbMaNganh_GV.SelectedValue.ToString();
                byte[] HinhGV = ConvertToByte(picGV_GV.Image);
                GiangVien gv = new GiangVien(MaGV, Ho, Ten, DiaChi, GioiTinh, MaNganh, HinhGV);
                int kq = new GiangVienBUS().insertTeacher(gv);
                loadTeacher();
                picGV_GV.Image = null;
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }

        private void btHinhGV_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                picGV_GV.Image = Image.FromFile(opf.FileName);
            }
        }

        private void btXoaGV_Click(object sender, EventArgs e)
        {
            try
            {
                int i = new GiangVienBUS().deleteTeacher(int.Parse(txtMaGV_GV.Text));
                loadTeacher();
                bindTeacher();
            }
            catch (FormatException)
            {
                MessageBox.Show("Ma Giao Vien bạn nhập vào không hợp lệ!");
            }
            catch (Exception ex)
            {                
                MessageBox.Show(ex.Message);
            }
        }

        private void btSuaGV_Click(object sender, EventArgs e)
        {
            try
            {
                int MaGV = int.Parse(txtMaGV_GV.Text);
                string Ho = txtHo_GV.Text,
                    Ten = txtTen_GV.Text,
                    DiaChi = txtDiaChiGV.Text,
                    GioiTinh = cbGioiTinhGV.Text,
                    MaNganh = cbMaNganh_GV.SelectedValue.ToString();
                byte[] HinhGV = ConvertToByte(picGV_GV.Image);
                GiangVien gv = new GiangVien(MaGV, Ho, Ten, DiaChi, GioiTinh, MaNganh, HinhGV);
                int kq = new GiangVienBUS().updateTeacher(gv);
                loadTeacher();
                picGV_GV.Image = null;
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }

        private void cbMaNganh_GV_TextChanged(object sender, EventArgs e)
        {
            DataRow dr = dtChuyenNganh.Rows.Find(cbMaNganh_GV.Text);
            if (dr != null)
            {
                if (dr["MaNganh"].ToString() == cbMaNganh_GV.Text)
                {
                    cbMaNganh_GV.SelectedValue = dr["MaNganh"].ToString();
                }
            }
        }

        private void btSearchGV_Click(object sender, EventArgs e)
        {
            if (rdNoneBindGV.Checked)
            {
                try
                {
                    string sql = @"select * from GiangVien where ";
                    if (txtMaGV_GV.Text != "") { sql += String.Format(@"MaGV = {0} ", txtMaGV_GV.Text); } else sql += @"null is null ";
                    if (txtHo_GV.Text != "") { sql += String.Format(@"and Ho = N'{0}' ", txtHo_GV.Text); } else sql += @"and null is null ";
                    if (txtTen_GV.Text != "") { sql += String.Format(@"and Ten = N'{0}' ", txtTen_GV.Text); } else sql += @"and null is null ";
                    if (txtDiaChiGV.Text != "") { sql += String.Format(@"and DiaChi = N'{0}' ", txtDiaChiGV.Text); } else sql += @"and null is null ";
                    if (cbGioiTinhGV.SelectedIndex != -1) { sql += String.Format(@"and GioiTinh = N'{0}' ", cbGioiTinhGV.Text); } else sql += @"and null is null ";
                    if (cbMaNganh_GV.SelectedIndex != -1) { sql += String.Format(@"and MaNganh = N'{0}' ", cbMaNganh_GV.SelectedValue.ToString()); } else sql += @"and null is null ";
                    dtTeacher = null;
                   
                    dtTeacher = new GiangVienBUS().searchGV(sql);
                    dgvGiangVien.DataSource = dtTeacher;
                    //bindTeacher();
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show(ex.Message);
                }
            }
            else MessageBox.Show("Bạn chỉ có thể sử dụng chức năng này khi tắt chức năng binding!");
        }

        private void btLoadGV_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaGV_GV.Text != "")
                {
                    DataRow dr = dtTeacher.Rows.Find(int.Parse(txtMaGV_GV.Text));
                    if (dr != null && dr["HinhGV"] != System.DBNull.Value)
                    {
                        picGV_GV.Image = ConvertToImg((byte[])dr["HinhGV"]);
                    }
                }
            }
            catch (Exception)
            {
                
                MessageBox.Show("Hình ảnh cần load chứa giá trị null");
            }
            
                
        }

        private void btRefreshGV_Click(object sender, EventArgs e)
        {
            loadTeacher();
            loadChuyenNganh();
            cbMaNganh_GV.DataSource = dtChuyenNganh;
            cbMaNganh_GV.DisplayMember = "TenNganh";
            cbMaNganh_GV.ValueMember = "MaNganh";
            bindTeacher();
            rdBindGV.Checked = true;
        }

      

       
      
 
    } 
       
 }

