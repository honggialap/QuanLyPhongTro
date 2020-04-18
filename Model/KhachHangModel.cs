using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Controller;

namespace Model
{
    public class KhachHangModel
    {
        public bool Add(KHACHHANG data)
        {
            KhachHangControler khachHang = new KhachHangControler();
            KetNoi ketNoi = new KetNoi();
            String query = String.Empty;
            query += "insert into KHACHHANG(hoTenKhachHang,thongTinCaNhan,lienLac,ghiChu) " +
                "values('" + data.hoTenKH + "','" + data.thongTin + "','" + data.lienLac + "','" + data.ghiChu + "')";
            bool kq = ketNoi.Command(query);
            return kq;
        }

        public bool Edit(KHACHHANG data)
        {
            KhachHangControler khachHang = new KhachHangControler();
            String query = String.Empty;
            bool check = false;
            try
            {
                bool kq = khachHang.edit(data);
                check = kq;
            }
            catch (Exception err)
            {
                return check = false;
            }
            return check;
        }

        public List<KHACHHANG> getAll()
        {
            KhachHangControler khControler = new KhachHangControler();
            List<KHACHHANG> listKhachHang = khControler.getAll();
            return listKhachHang;
        }

        public bool Delete(KHACHHANG data)
        {
            KhachHangControler khachHang = new KhachHangControler();
            KetNoi ketNoi = new KetNoi();
            String query = String.Empty;
            query += "delete from KHACHHANG where(idKhachHang ='" + data.idKhachHang + "')";
            bool kq = ketNoi.Command(query);
            return kq;
        }
    }
}
