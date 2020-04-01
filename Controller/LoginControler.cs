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
    public class LoginControler
    {
        private KetNoi ketNoi = new KetNoi();
        public List<ACCOUNT> getAll()
        {
            List<ACCOUNT> listAccount = new List<ACCOUNT>();
            string query = string.Empty;
            // câu lệnh thực hiện truy vấn 
            query += "select [taiKhoan],[matKhau]";
            query += " from [ACCOUNT]";
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
                                ACCOUNT db = new ACCOUNT();
                                db.taiKhoan = reader["taiKhoan"].ToString();
                                db.matKhau = reader["matKhau"].ToString();
                                listAccount.Add(db);
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
            return listAccount;
        }

        public bool edit(ACCOUNT data)
        {
            string query = String.Empty;
            query += "update ACCOUNT set [taiKhoan]=@taiKhoan, [matKhau]=@matKhau where [id]=@id ";
            using (SqlConnection con = new SqlConnection(ketNoi.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@taiKhoan", data.taiKhoan);
                    cmd.Parameters.AddWithValue("@matKhau", data.matKhau);
                    cmd.Parameters.AddWithValue("@id", data.id);
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
