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

using DTO;
using BUS;
using System.IO;


namespace QuanLySinhVien
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
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

        private void txtmnganh_TextChanged(object sender, EventArgs e)
        {

        }
      
 
    } 
       
 }

