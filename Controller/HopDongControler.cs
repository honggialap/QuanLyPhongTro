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
    public class HopDongControler
    {
        private KetNoi ketNoi = new KetNoi();
        public List<HOPDONG> getAll()
        {
            List<HOPDONG> listHopdong = new List<HOPDONG>();
            string query = string.Empty;
            // câu lệnh thực hiện truy vấn 
            query += "select [idHopDong],[bieuPhiTuyBien], [bieuPhiGiaPhong], [idPhieuThu], [idPhongTro], [ghiChu], [idKhachHang]";
            query += " from [HOPDONG]";
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
                                HOPDONG db = new HOPDONG();
                                db.idHopDong = int.Parse(reader["idHopDong"].ToString());
                                db.phiTuyBien = int.Parse(reader["bieuPhiTuyBien"].ToString());
                                db.phiGiaPhong = int.Parse(reader["bieuPhiGiaPhong"].ToString() != null ? reader["bieuPhiGiaPhong"].ToString() : "0");
                                db.idPhieuThu = int.Parse(reader["idPhieuThu"].ToString() != null ? reader["idPhieuThu"].ToString() : "0");
                                db.idPhongTro = int.Parse(reader["idPhongTro"].ToString() != null ? reader["idPhongTro"].ToString() : "0");
                                db.phiGiaPhong = int.Parse(reader["idKhachHang"].ToString() != null ? reader["idKhachHang"].ToString() : "0");
                                db.ghiChu = reader["ghiChu"].ToString();
                                listHopdong.Add(db);
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
            return listHopdong;
        }

        public bool edit(HOPDONG data)
        {
            string query = String.Empty;
            query += "update HOPDONG set [bieuPhiTuyBien]=@phiTuyBien, [bieuPhiGiaPhong]=@phiGiaPhong, [idPhieuThu]=@idPhieuThu, [idPhongTro]=@idPhongTro, [ghiChu]=@ghiChu, [idKhachHang]=@idKhachHang where [idHopDong]=@idHopDong ";
            using (SqlConnection con = new SqlConnection(ketNoi.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@phiTuyBien", data.phiTuyBien);
                    cmd.Parameters.AddWithValue("@bieuPhiGiaPhong", data.phiGiaPhong);
                    cmd.Parameters.AddWithValue("@idPhieuThu", data.idPhieuThu);
                    cmd.Parameters.AddWithValue("@idPhongTro", data.phiGiaPhong);
                    cmd.Parameters.AddWithValue("@ghiChu", data.ghiChu);
                    cmd.Parameters.AddWithValue("@idHopDong", data.idHopDong);
                    cmd.Parameters.AddWithValue("@idKhachHang", data.idKhachHang);

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
