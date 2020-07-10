using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Controller;
using DTO;
namespace Controller.Tests
{
    [TestClass]
    public class KhachHangTests
    {
        [TestMethod]
        public void GetAll_Pass()
        {
            KhachHangControler khachHangControler = new KhachHangControler();
            Assert.IsNotNull(khachHangControler.getAll());
        }

        [TestMethod]
        public void GetAll_Fail()
        {
            KhachHangControler khachHangControler = new KhachHangControler();
            Assert.IsNull(khachHangControler.getAll());
        }

        [TestMethod]
        public void Edit_Pass()
        {
            KhachHangControler khachHangControler = new KhachHangControler();
            KHACHHANG khachHang = new KHACHHANG();
            khachHang.idKhachHang = 0;
            khachHang.hoTenKH = "a";
            khachHang.lienLac = "a";
            khachHang.thongTin = "a";
            khachHang.idHopDong = 0;
            Assert.IsTrue(khachHangControler.edit(khachHang));
        }

        [TestMethod]
        public void Edit_Fail()
        {
            KhachHangControler khachHangControler = new KhachHangControler();
            KHACHHANG khachHang = new KHACHHANG();
            khachHang.idKhachHang = 0;
            khachHang.hoTenKH = "a";
            khachHang.lienLac = "a";
            khachHang.thongTin = "a";
            khachHang.idHopDong = 0;
            Assert.IsFalse(khachHangControler.edit(khachHang));
        }


    }
}
