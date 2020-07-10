using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Controller;

namespace Model
{
    public class LoginModel
    {
        public bool DangNhap(ACCOUNT data)
        {
            LoginControler loginControler = new LoginControler();
            List<ACCOUNT> db = loginControler.getAll();
            bool check = false;
            try
            {
                foreach(ACCOUNT value in db)
                {
                    if(data.taiKhoan == value.taiKhoan)
                    {
                        if (data.matKhau == value.matKhau) check = true;
                    }
                }
            }
            catch(Exception err) {}
            return check;
        }

        public bool ThemTaiKhoan(ACCOUNT data)
        {
            LoginControler loginControler = new LoginControler();
            KetNoi ketNoi = new KetNoi();
            String query = String.Empty;
            query += "insert into ACCOUNT(taiKhoan,matKhau) values('" + data.taiKhoan + "','" + data.matKhau + "')";
            bool kq = ketNoi.Command(query);
            return kq;
        }

        public bool SuaTaiKhoan(ACCOUNT data)
        {
            LoginControler loginControler = new LoginControler();
            String query = String.Empty;
            bool check = false;
            try
            {
                if (data.taiKhoan != null)
                {
                    if (data.matKhau != null)
                    {
                       bool kq = loginControler.edit(data);
                       check = kq;
                    }
                }
            }
            catch (Exception err)
            {
                return check = false;
            }
            return check;
        }

        public bool xoa(ACCOUNT data)
        {
            LoginControler loginControler = new LoginControler();
            KetNoi ketNoi = new KetNoi();
            String query = String.Empty;
            query += "delete from account where(id ='" + data.id + "')";
            bool kq = ketNoi.Command(query);
            return kq;
        }

        public List<ACCOUNT> Load()
        {
            LoginControler loginControler = new LoginControler();
            List<ACCOUNT> db = loginControler.getAll();
            return db;
        }
    }
}
