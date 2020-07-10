using System;
using Model;
using DTO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Model.Tests
{
    [TestClass]
    public class HopDongTest
    {
        [TestMethod]
        public void Add_Pass()
        {
            HopDongModel hopdong = new HopDongModel();
            HOPDONG hd = new HOPDONG();
            hd.ghiChu = "";
            hd.idHopDong = 2;
            hd.idKhachHang = 1;
            hd.idPhieuThu = 2;
            hd.idPhongTro = 2;
            hd.phiGiaPhong = 100;
            hd.phiTuyBien = 100;
            Assert.IsTrue(hopdong.Add(hd));
        }

        [TestMethod]
        public void Add_Fail()
        {
            HopDongModel hopdong = new HopDongModel();
            HOPDONG hd = new HOPDONG();
            hd.ghiChu = "";
            hd.idHopDong = 2;
            hd.idKhachHang = 1;
            hd.idPhieuThu = 2;
            hd.idPhongTro = 2;
            hd.phiGiaPhong = 100;
            hd.phiTuyBien = 100;
            Assert.IsFalse(hopdong.Add(hd));
        }

        [TestMethod]
        public void Edit_Pass()
        {
            HopDongModel hopdong = new HopDongModel();
            HOPDONG hd = new HOPDONG();
            hd.ghiChu = "";
            hd.idHopDong = 2;
            hd.idKhachHang = 1;
            hd.idPhieuThu = 2;
            hd.idPhongTro = 2;
            hd.phiGiaPhong = 100;
            hd.phiTuyBien = 100;
            Assert.IsTrue(hopdong.Edit(hd));
        }

        [TestMethod]
        public void Edit_Fail()
        {
            HopDongModel hopdong = new HopDongModel();
            HOPDONG hd = new HOPDONG();
            hd.ghiChu = "";
            hd.idHopDong = 2;
            hd.idKhachHang = 1;
            hd.idPhieuThu = 2;
            hd.idPhongTro = 2;
            hd.phiGiaPhong = 100;
            hd.phiTuyBien = 100;
            Assert.IsFalse(hopdong.Edit(hd));
        }

        [TestMethod]
        public void GetAll_Pass()
        {
            HopDongModel hopdong = new HopDongModel();
            Assert.IsNotNull(hopdong.getAll());
        }

        [TestMethod]
        public void GetAll_Fail()
        {
            HopDongModel hopdong = new HopDongModel();
            Assert.IsNull(hopdong.getAll());
        }
    }
}
