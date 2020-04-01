using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Controller;

namespace Model
{
    public class PhieuChiModel
    {
        public bool Add(PHIEUCHI data)
        {
            PhieuChiControler PhieuChiControler = new PhieuChiControler();
            KetNoi ketNoi = new KetNoi();
            String query = String.Empty;
            query += "insert into PHIEUCHI(tienDien,tienNuoc,tienKhac) values('" + data.tienDien + "','" + data.tienNuoc + "','" + data.tienKhac + "')";
            bool kq = ketNoi.Command(query);
            return kq;
        }

        public bool Edit(PHIEUCHI data)
        {
            PhieuChiControler PhieuChiControler = new PhieuChiControler();
            String query = String.Empty;
            bool check = false;
            try
            {
                if (data.tienDien != null)
                {
                    if (data.tienNuoc != null)
                    {
                        if (data.tienKhac != null)
                        {
                            bool kq = PhieuChiControler.edit(data);
                            check = kq;
                        }
                    }
                }
            }
            catch (Exception err)
            {
                return check = false;
            }
            return check;
        }

        public bool Delete(PHIEUCHI data)
        {
            PhieuChiControler PhieuChiControler = new PhieuChiControler();
            KetNoi ketNoi = new KetNoi();
            String query = String.Empty;
            query += "delete from PHIEUCHI where(idPhieuChi ='" + data.idPhieuChi + "')";
            bool kq = ketNoi.Command(query);
            return kq;
        }
    }
}
