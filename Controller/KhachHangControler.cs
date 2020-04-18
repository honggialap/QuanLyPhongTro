using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

/// <summary>
/// lop nay chỉ thực hiện load toàn bộ thông tin trong bảng và thực hiện edit 
/// chỉnh sửa và xóa sẽ thực hiện ở lớp modal
/// </summary>
namespace Controller
{
    public class KhachHangControler
    {
        private KetNoi ketNoi = new KetNoi();
        public List<KHACHHANG> getAll()
        {
            List<KHACHHANG> listKHACHHANG = new List<KHACHHANG>();
            string query = string.Empty;
            // câu lệnh thực hiện truy vấn 
            query += "select [idKhachHang], [hoTenKhachHang],[thongTinCaNhan], [lienLac], [ghiChu]";
            query += " from [KHACHHANG]";
            using (SqlConnection conn = new SqlConnection(ketNoi.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    try
                    {
                        conn.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                KHACHHANG db = new KHACHHANG();
                                db.idKhachHang = int.Parse(reader["idKhachHang"].ToString());
                                db.hoTenKH = reader["hoTenKhachHang"].ToString();
                                db.thongTin = reader["thongTinCaNhan"].ToString();
                                db.lienLac = reader["lienLac"].ToString();
                                db.ghiChu = reader["ghiChu"].ToString();
                                listKHACHHANG.Add(db);
                            }
                        }
                        conn.Close();
                        conn.Dispose(); // tra lai tat ca tai nguyen da su dung de giai phong bo nho
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        return null;
                    }
                }
            }
            return listKHACHHANG;
        }

        public bool edit(KHACHHANG data)
        {
            string query = String.Empty;
            query += "update KHACHHANG set [hoTenKhachHang]=@hotenKH, [thongTinCaNhan]=@thongTin, [lienLac]=@lienLac,[ghiChu]=@ghiChu where [idKhachHang]=@idKhachHang ";
            using (SqlConnection con = new SqlConnection(ketNoi.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@idKhachHang", data.idKhachHang);
                    cmd.Parameters.AddWithValue("@hotenKH", data.hoTenKH);
                    cmd.Parameters.AddWithValue("@thongTin", data.thongTin);
                    cmd.Parameters.AddWithValue("@lienLac", data.lienLac);
                    cmd.Parameters.AddWithValue("@ghiChu", data.ghiChu);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
