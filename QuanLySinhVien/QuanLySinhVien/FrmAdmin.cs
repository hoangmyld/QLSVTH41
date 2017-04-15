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

namespace QuanLySinhVien
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }
        public List<SinhVien> getStudent()
        {
            try
            {
                string sql = "select * from SinhVien";
                SinVien1BUS sv = new SinVien1BUS();
                return sv.getStudent1(sql);
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
            loadStudent();
        }
       
     }
    }

