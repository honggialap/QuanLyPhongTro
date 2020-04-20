using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Controller;

namespace Model
{
    public class PhieuThuModel
    {
        public bool Add(PHIEUTHU data)
        {
            PhieuThuControler phieuThuControler = new PhieuThuControler();
            KetNoi ketNoi = new KetNoi();
            String query = String.Empty;
            query += "insert into PHIEUTHU(tenPhieuThu,phiTuyBien,phiThuePhong,tienDien,tienNuoc,ghiChu) " +
                "values('" + data.tenPhieuThu + "','" + data.phiTuyBien + "','" + data.phiThuePhong + "','" + data.tienDien + "','" + data.tienNuoc + "','" + data.ghiChu + "')";
            bool kq = ketNoi.Command(query);
            return kq;
        }

        public bool Edit(PHIEUTHU data)
        {
            PhieuThuControler phieuThuControler = new PhieuThuControler();
            String query = String.Empty;
            bool check = false;
            try
            {
                bool kq = phieuThuControler.edit(data);
                check = kq;
            }
            catch (Exception err)
            {
                return check = false;
            }
            return check;
        }

        public bool Delete(PHIEUTHU data)
        {
            PhieuThuControler phieuThuControler = new PhieuThuControler();
            KetNoi ketNoi = new KetNoi();
            String query = String.Empty;
            query += "delete from PHIEUTHU where(idPhieuThu ='" + data.idPhieuThu + "')";
            bool kq = ketNoi.Command(query);
            return kq;
        }

        public List<PHIEUTHU> getAll()
        {
            PhieuThuControler phieuThuControler = new PhieuThuControler();
            List<PHIEUTHU> list = phieuThuControler.getAll();
            return list;
        }
    }
}
