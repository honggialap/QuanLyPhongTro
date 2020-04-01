using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Controller;

namespace Model
{
    public class PhongTroModel
    {
        public bool Add(PHONGTRO data)
        {
            KetNoi ketNoi = new KetNoi();
            String query = String.Empty;
            query += "insert into PHONGTRO(tenPhong,giaKhuyenNghi,tinhTrangPhong,chiSoNuocHienHanh,chiSoDienHienHanh) " +
                    "values('" + data.tenPhong + "','" + data.giaKhuyenNghi + "','" + data.tinhTrangPhong + "','" + data.chiSoNuocHienHanh + "','" + data.chiSoDienHienHanh + "')";
            bool kq = ketNoi.Command(query);
            return kq;
        }

        public bool Edit(PHONGTRO data)
        {
            PhongTroControler phongTro = new PhongTroControler();
            String query = String.Empty;
            bool check = false;
            try
            {
                bool kq = phongTro.edit(data);
                check = kq;
            }
            catch (Exception err)
            {
                return check = false;
            }
            return check;
        }

        public bool Delete(PHONGTRO data)
        {
            KetNoi ketNoi = new KetNoi();
            String query = String.Empty;
            query += "delete from PHONGTRO where(idPhongTro ='" + data.idPhongTro + "')";
            bool kq = ketNoi.Command(query);
            return kq;
        }
    }
}
