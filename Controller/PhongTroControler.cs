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
    public class PhongTroControler
    {
        private KetNoi ketNoi = new KetNoi();
        public List<PHONGTRO> getAll()
        {
            List<PHONGTRO> listPhongTro = new List<PHONGTRO>();
            string query = string.Empty;
            // câu lệnh thực hiện truy vấn 
            query += "select [idPhongTro],[tenPhong], [giaKhuyenNghi], [tinhTrangPhong], [chiSoNuocHienHanh], [chiSoDienHienHanh]";
            query += " from [PHONGTRO]";
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
                                PHONGTRO db = new PHONGTRO();
                                db.idPhongTro = int.Parse(reader["idPhongTro"].ToString());
                                db.tenPhong = reader["tenPhong"].ToString();
                                db.giaKhuyenNghi = int.Parse(reader["giaKhuyenNghi"].ToString());
                                db.tinhTrangPhong = reader["tinhTrangPhong"].ToString();
                                db.chiSoNuocHienHanh = int.Parse(reader["chiSoNuocHienHanh"].ToString());
                                db.chiSoNuocHienHanh = int.Parse(reader["chiSoDienHienHanh"].ToString());
                                listPhongTro.Add(db);
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
            return listPhongTro;
        }

        public bool edit(PHONGTRO data)
        {
            string query = String.Empty;
            query += "update PHONGTRO set [tenPhong]=@tenPhong, [giaKhuyenNghi]=@giaKhuyenNghi, [tinhTrangPhong]=@tinhTrangPhong, [chiSoNuocHienHanh]=@chiSoNuocHienHanh, [chiSoDienHienHanh]=@chiSoDienHienHanh where [idPhongTro]=@idPhongTro ";
            using (SqlConnection con = new SqlConnection(ketNoi.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@tenPhong", data.tenPhong);
                    cmd.Parameters.AddWithValue("@giaKhuyenNghi", data.giaKhuyenNghi);
                    cmd.Parameters.AddWithValue("@tinhTrangPhong", data.tinhTrangPhong);
                    cmd.Parameters.AddWithValue("@chiSoNuocHienHanh", data.chiSoNuocHienHanh);
                    cmd.Parameters.AddWithValue("@chiSoDienHienHanh", data.chiSoDienHienHanh);
                    cmd.Parameters.AddWithValue("@idPhongTro", data.idPhongTro);

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
