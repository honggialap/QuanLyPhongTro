using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Controller;

namespace Model
{
    public class HopDongModel
    {
        public bool Add(HOPDONG data)
        {
            KetNoi ketNoi = new KetNoi();
            String query = String.Empty;
            query += "insert into HOPDONG(bieuPhiTuyBien,bieuPhiGiaPhong,idPhieuThu,idPhongTro,ghiChu,idKhachHang) " +
                    "values('" + data.phiTuyBien + "','" + data.phiGiaPhong + "','" + data.idPhieuThu + "','" + data.idPhongTro + "','" + data.ghiChu + "','" + data.idKhachHang + "')";
            bool kq = ketNoi.Command(query);
            return kq;
        }

        public bool Edit(HOPDONG data)
        {
            HopDongControler hopDong = new HopDongControler();
            String query = String.Empty;
            bool check = false;
            try
            {
                bool kq = hopDong.edit(data);
                check = kq;
            }
            catch (Exception err)
            {
                return check = false;
            }
            return check;
        }

        public List<HOPDONG> getAll()
        {
            HopDongControler hopDong = new HopDongControler();
            List<HOPDONG> list = hopDong.getAll();
            return list;
        }
    }
}
