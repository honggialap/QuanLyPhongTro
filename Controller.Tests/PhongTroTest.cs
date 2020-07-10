using System;
using Controller;
using DTO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Controller.Tests
{
    [TestClass]
    public class PhongTroTest
    {
        [TestMethod]
        public void GetAll_Pass()
        {
            PhongTroControler phongTro = new PhongTroControler();
            Assert.IsNotNull(phongTro.getAll());
        }

        [TestMethod]
        public void GetAll_Fail()
        {
            PhongTroControler phongTro = new PhongTroControler();
            Assert.IsNull(phongTro.getAll());
        }

        [TestMethod]
        public void Edit_Pass()
        {
            PhongTroControler phongTro = new PhongTroControler();
            PHONGTRO pt = new PHONGTRO();
            pt.chiSoDienHienHanh = 0;
            pt.chiSoNuocHienHanh = 2;
            pt.giaKhuyenNghi = 3;
            pt.idPhongTro = 4;
            pt.tenPhong = "a";
            pt.tinhTrangPhong = "";
            Assert.IsTrue(phongTro.edit(pt));
        }

        [TestMethod]
        public void Edit_Fail()
        {
            PhongTroControler phongTro = new PhongTroControler();
            PHONGTRO pt = new PHONGTRO();
            pt.chiSoDienHienHanh = 0;
            pt.chiSoNuocHienHanh = 2;
            pt.giaKhuyenNghi = 3;
            pt.idPhongTro = 4;
            pt.tenPhong = "a";
            pt.tinhTrangPhong = "";
            Assert.IsFalse(phongTro.edit(pt));
        }
    }
}
