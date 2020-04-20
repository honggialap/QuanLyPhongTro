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
    public class PhieuThuControler
    {
        private KetNoi ketNoi = new KetNoi();
        public List<PHIEUTHU> getAll()
        {
            List<PHIEUTHU> listPHIEUTHU = new List<PHIEUTHU>();
            string query = string.Empty;
            // câu lệnh thực hiện truy vấn 
            query += "select [idPhieuThu], [tenPhieuThu], [phiTuyBien],[phiThuePhong], [tienDien], [tienNuoc], [ghiChu]";
            query += " from [PHIEUTHU]";
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
                                PHIEUTHU db = new PHIEUTHU();
                                db.idPhieuThu = int.Parse(reader["idPhieuThu"].ToString());
                                db.tenPhieuThu = reader["tenPhieuThu"] == DBNull.Value ? "0" : reader["tenPhieuThu"].ToString();
                                db.tienDien = int.Parse(reader["tienDien"] == DBNull.Value ? "0" : reader["tienDien"].ToString());
                                db.tienNuoc = int.Parse(reader["tienNuoc"] == DBNull.Value ? "0" : reader["tienNuoc"].ToString());
                                db.phiTuyBien = int.Parse(reader["phiTuyBien"] == DBNull.Value ? "0" : reader["phiTuyBien"].ToString());
                                db.phiThuePhong = int.Parse(reader["phiThuePhong"] == DBNull.Value ? "0" : reader["phiThuePhong"].ToString());
                                db.ghiChu = reader["ghiChu"].ToString();

                                listPHIEUTHU.Add(db);
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
            return listPHIEUTHU;
        }

        public bool edit(PHIEUTHU data)
        {
            string query = String.Empty;
            query += "update PHIEUTHU set [tenPhieuThu]=@tenPhieuThu, [phiTuyBien]=@phiTuyBien, [phiThuePhong]=@phiThuePhong, [tienDien]=@tienDien, [tienNuoc]=@tienNuoc, [ghiChu]=@ghiChu where [idPhieuThu]=@idPhieuThu ";
            using (SqlConnection con = new SqlConnection(ketNoi.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@idPhieuThu", data.idPhieuThu);
                    cmd.Parameters.AddWithValue("@tenPhieuThu", data.tenPhieuThu);
                    cmd.Parameters.AddWithValue("@tienDien", data.tienDien);
                    cmd.Parameters.AddWithValue("@tienNuoc", data.tienNuoc);
                    cmd.Parameters.AddWithValue("@phiTuyBien", data.phiTuyBien);
                    cmd.Parameters.AddWithValue("@phiThuePhong", data.phiThuePhong);
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
