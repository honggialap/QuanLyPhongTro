using System;
using Controller;
using DTO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Controller.Tests
{
    [TestClass]
    public class HopDongTest
    {
        [TestMethod]
        public void GetAll_Pass()
        {
            HopDongControler hopDong = new HopDongControler();
            Assert.IsNotNull(hopDong.getAll());
        }

        [TestMethod]
        public void GetAll_Fail()
        {
            HopDongControler hopDong = new HopDongControler();
            Assert.IsNull(hopDong.getAll());
        }

        [TestMethod]
        public void Edit_Pass()
        {
            HopDongControler hopDong = new HopDongControler();
            HOPDONG hd = new HOPDONG();
            hd.ghiChu = "";
            hd.idHopDong = 2;
            hd.idKhachHang = 1;
            hd.idPhieuThu = 2;
            hd.idPhongTro = 2;
            hd.phiGiaPhong = 100;
            hd.phiTuyBien = 100;
            Assert.IsTrue(hopDong.edit(hd));
        }

        [TestMethod]
        public void Edit_Fail()
        {
            HopDongControler hopDong = new HopDongControler();
            HOPDONG hd = new HOPDONG();
            hd.ghiChu = "";
            hd.idHopDong = 2;
            hd.idKhachHang = 1;
            hd.idPhieuThu = 2;
            hd.idPhongTro = 2;
            hd.phiGiaPhong = 100;
            hd.phiTuyBien = 100;
            Assert.IsFalse(hopDong.edit(hd));
        }
    }
}
