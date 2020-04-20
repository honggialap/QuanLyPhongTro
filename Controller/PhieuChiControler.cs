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
    public class PhieuChiControler
    {
        private KetNoi ketNoi = new KetNoi();
        public List<PHIEUCHI> getAll()
        {
            List<PHIEUCHI> listPHIEUCHI = new List<PHIEUCHI>();
            string query = string.Empty;
            // câu lệnh thực hiện truy vấn 
            query += "select [idPhieuChi], [tenPhieuChi], [tienDien],[tienNuoc], [tienKhac]";
            query += " from [PHIEUCHI]";
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
                                PHIEUCHI db = new PHIEUCHI();
                                db.idPhieuChi = int.Parse(reader["idPhieuChi"] == DBNull.Value ? "0" : reader["idPhieuChi"].ToString() );
                                db.tenPhieuChi = reader["tenPhieuChi"] == DBNull.Value ? "0" : reader["tenPhieuChi"].ToString();
                                db.tienDien = int.Parse(reader["tienDien"] == DBNull.Value ? "0" : reader["tienDien"].ToString());
                                db.tienNuoc = int.Parse(reader["tienNuoc"] == DBNull.Value ? "0" : reader["tienNuoc"].ToString());
                                db.tienKhac = int.Parse(reader["tienKhac"] == DBNull.Value ? "0" : reader["tienKhac"].ToString());
                                listPHIEUCHI.Add(db);
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
            return listPHIEUCHI;
        }

        public bool edit(PHIEUCHI data)
        {
            string query = String.Empty;
            query += "update PHIEUCHI set [tenPhieuChi]=@tenPhieuChi, [tienDien]=@tienDien, [tienNuoc]=@tienNuoc, [tienKhac]=@tienKhac where [idPhieuChi]=@idPhieuchi ";
            using (SqlConnection con = new SqlConnection(ketNoi.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@idPhieuChi", data.idPhieuChi);
                    cmd.Parameters.AddWithValue("@tenPhieuChi", data.tenPhieuChi);
                    cmd.Parameters.AddWithValue("@tienDien", data.tienDien);
                    cmd.Parameters.AddWithValue("@tienNuoc", data.tienNuoc);
                    cmd.Parameters.AddWithValue("@tienKhac", data.tienKhac);
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
