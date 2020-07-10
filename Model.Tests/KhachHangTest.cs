using System;
using Model;
using DTO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Model.Tests
{
    [TestClass]
    public class KhachHangTest
    {
        [TestMethod]
        public void Add_Pass()
        {
            KhachHangModel khachHang = new KhachHangModel();
            KHACHHANG kh = new KHACHHANG();
            kh.idKhachHang = 0;
            kh.hoTenKH = "a";
            kh.lienLac = "a";
            kh.thongTin = "a";
            kh.idHopDong = 0;
            Assert.IsTrue(khachHang.Add(kh));
        }

        [TestMethod]
        public void Add_Fail()
        {
            KhachHangModel khachHang = new KhachHangModel();
            KHACHHANG kh = new KHACHHANG();
            kh.idKhachHang = 0;
            kh.hoTenKH = "a";
            kh.lienLac = "a";
            kh.thongTin = "a";
            kh.idHopDong = 0;
            Assert.IsFalse(khachHang.Add(kh));
        }

        [TestMethod]
        public void Edit_Pass()
        {
            KhachHangModel khachHang = new KhachHangModel();
            KHACHHANG kh = new KHACHHANG();
            kh.idKhachHang = 0;
            kh.hoTenKH = "a";
            kh.lienLac = "a";
            kh.thongTin = "a";
            kh.idHopDong = 0;
            Assert.IsTrue(khachHang.Edit(kh));
        }

        [TestMethod]
        public void Edit_Fail()
        {
            KhachHangModel khachHang = new KhachHangModel();
            KHACHHANG kh = new KHACHHANG();
            kh.idKhachHang = 0;
            kh.hoTenKH = "a";
            kh.lienLac = "a";
            kh.thongTin = "a";
            kh.idHopDong = 0;
            Assert.IsFalse(khachHang.Edit(kh));

        }

        [TestMethod]
        public void Delete_Pass()
        {
            KhachHangModel khachHang = new KhachHangModel();
            KHACHHANG kh = new KHACHHANG();
            kh.idKhachHang = 0;
            kh.hoTenKH = "a";
            kh.lienLac = "a";
            kh.thongTin = "a";
            kh.idHopDong = 0;
            Assert.IsTrue(khachHang.Delete(kh));
        }

        [TestMethod]
        public void Delete_Fail()
        {
            KhachHangModel khachHang = new KhachHangModel();
            KHACHHANG kh = new KHACHHANG();
            kh.idKhachHang = 0;
            kh.hoTenKH = "a";
            kh.lienLac = "a";
            kh.thongTin = "a";
            kh.idHopDong = 0;
            Assert.IsFalse(khachHang.Delete(kh));
        }

        [TestMethod]
        public void GetAll_Pass()
        {
            KhachHangModel khachHang = new KhachHangModel();
            Assert.IsNotNull(khachHang.getAll());
        }

        [TestMethod]
        public void GetAll_Fail()
        {
            KhachHangModel khachHang = new KhachHangModel();
            Assert.IsNull(khachHang.getAll());
        }
    }
}
