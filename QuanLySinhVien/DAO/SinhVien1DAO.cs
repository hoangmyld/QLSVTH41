using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using DTO;

namespace DAO
{
    public class SinhVien1DAO
    {
        DataProvider dp;
        public SinhVien1DAO()
        {
            dp = new DataProvider();
        }
        public List<SinhVien> getStudent1(string sql)
        {
            try
            {
                SqlDataReader dr = dp.ExecReader(sql);
                List<SinhVien> list = new List<SinhVien>();
                int id;
                string LName, FName, phone, address, sex, email, facity;
                while (dr.Read())
                {
                    id = dr.GetInt32(0);
                    LName = dr.GetString(1);
                    FName = dr.GetString(2);
                    phone = dr.GetString(3);
                    address = dr.GetString(4);
                    sex = dr.GetString(5);
                    email = dr.GetString(6);
                    facity = dr.GetString(7);
                    SinhVien sv = new SinhVien(id, LName, FName, phone, address, sex, email, facity);
                    list.Add(sv);

                }
                return list;
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            finally
            {
                dp.disCon();
            }
        }
        public int ThemSV(SinhVien SV)
        {
            List<SqlParameter> list = new List<SqlParameter>();
            list.Add(new SqlParameter("@masv", SV.MaSV));
            list.Add(new SqlParameter("@ho", SV.Ho));
            list.Add(new SqlParameter("@ten", SV.Ten));
            list.Add(new SqlParameter("@sdt", SV.SDT));
            list.Add(new SqlParameter("@diachi", SV.DiaChi));
            list.Add(new SqlParameter("@gioitinh", SV.GioiTinh));
            list.Add(new SqlParameter("@email", SV.Email));
            list.Add(new SqlParameter("@manganh", SV.MaNganh));
            list.Add(new SqlParameter("@hinh", SV.HinhSV));
           

            try
            {
                return (dp.ExcuteNonquery("Them", System.Data.CommandType.StoredProcedure, list));
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        //public int XoaSV(int id)
        //{
         
         
        //    try
        //    {
        //        //string sql = String.Format("delete from SinhVien where MaSV = {0}", id);
        //        string sql = "delete from SinhVien where MaSV = " + id.ToString();
        //        return dp.ExcuteNonquery(sql, CommandType.Text, null);
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
            


        //}
        public int XoaSV(int id)
        {


            try
            {
                dp.Con();
                //string sql = String.Format("delete from SinhVien where MaSV = {0}", id);
                string sql = "delete from SinhVien where MaSV = " + id;
                return dp.ExecTest(sql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public int SuaSV(SinhVien SV)
        {
            List<SqlParameter> list = new List<SqlParameter>();
            list.Add(new SqlParameter("@masv", SV.MaSV));
            list.Add(new SqlParameter("@ho", SV.Ho));
            list.Add(new SqlParameter("@ten", SV.Ten));
            list.Add(new SqlParameter("@sdt", SV.SDT));
            list.Add(new SqlParameter("@diachi", SV.DiaChi));
            list.Add(new SqlParameter("@gioitinh", SV.GioiTinh));
            list.Add(new SqlParameter("@email", SV.Email));
            list.Add(new SqlParameter("@manganh", SV.MaNganh));
            list.Add(new SqlParameter("@hinh", SV.HinhSV));
            try
            {
                return (dp.ExcuteNonquery("Sua", System.Data.CommandType.StoredProcedure, list));
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public SinhVien getAStudent(string sql)
        {
            try
            {
                SqlDataReader dr = dp.ExecReader(sql);
                
                int id;
                string LName, FName, phone, address, sex, email, facity;
                
                byte[] image = null;
                SinhVien sv;
                dr.Read();                
                    id = dr.GetInt32(0);
                    LName = dr.GetString(1);
                    FName = dr.GetString(2);
                    phone = dr.GetString(3);
                    address = dr.GetString(4);
                    sex = dr.GetString(5);
                    email = dr.GetString(6);
                    facity = dr.GetString(7);
                    if(dr.GetValue(8) != System.DBNull.Value)
                    {
                        image = (byte[])dr.GetValue(8);
                    }
                    sv = new SinhVien(id, LName, FName, phone, address, sex, email, facity, image);
                
                return sv;
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            finally
            {
                dp.disCon();
            }
        }
    }
}
