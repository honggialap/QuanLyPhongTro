using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using DTO;

namespace Model.Tests
{
    [TestClass]
    public class PhongTroTest
    {
        [TestMethod]
        public void Add_Pass()
        {
            PhongTroModel phongTro = new PhongTroModel();
            PHONGTRO pt = new PHONGTRO();
            pt.chiSoDienHienHanh = 0;
            pt.chiSoNuocHienHanh = 2;
            pt.giaKhuyenNghi = 3;
            pt.idPhongTro = 4;
            pt.tenPhong = "a";
            pt.tinhTrangPhong = "";
            Assert.IsTrue(phongTro.Add(pt));
        }

        [TestMethod]
        public void Add_Fail()
        {
            PhongTroModel phongTro = new PhongTroModel();
            PHONGTRO pt = new PHONGTRO();
            pt.chiSoDienHienHanh = 0;
            pt.chiSoNuocHienHanh = 2;
            pt.giaKhuyenNghi = 3;
            pt.idPhongTro = 4;
            pt.tenPhong = "a";
            pt.tinhTrangPhong = "";
            Assert.IsFalse(phongTro.Add(pt));
        }

        [TestMethod]
        public void Edit_Pass()
        {
            PhongTroModel phongTro = new PhongTroModel();
            PHONGTRO pt = new PHONGTRO();
            pt.chiSoDienHienHanh = 0;
            pt.chiSoNuocHienHanh = 2;
            pt.giaKhuyenNghi = 3;
            pt.idPhongTro = 4;
            pt.tenPhong = "a";
            pt.tinhTrangPhong = "";
            Assert.IsTrue(phongTro.Edit(pt));
        }

        [TestMethod]
        public void Edit_Fail()
        {
            PhongTroModel phongTro = new PhongTroModel();
            PHONGTRO pt = new PHONGTRO();
            pt.chiSoDienHienHanh = 0;
            pt.chiSoNuocHienHanh = 2;
            pt.giaKhuyenNghi = 3;
            pt.idPhongTro = 4;
            pt.tenPhong = "a";
            pt.tinhTrangPhong = "";
            Assert.IsFalse(phongTro.Edit(pt));
        }

        [TestMethod]
        public void Delete_Pass()
        {
            PhongTroModel phongTro = new PhongTroModel();
            PHONGTRO pt = new PHONGTRO();
            pt.chiSoDienHienHanh = 0;
            pt.chiSoNuocHienHanh = 2;
            pt.giaKhuyenNghi = 3;
            pt.idPhongTro = 4;
            pt.tenPhong = "a";
            pt.tinhTrangPhong = "";
            Assert.IsTrue(phongTro.Delete(pt));
        }

        [TestMethod]
        public void Delete_Fail()
        {
            PhongTroModel phongTro = new PhongTroModel();
            PHONGTRO pt = new PHONGTRO();
            pt.chiSoDienHienHanh = 0;
            pt.chiSoNuocHienHanh = 2;
            pt.giaKhuyenNghi = 3;
            pt.idPhongTro = 4;
            pt.tenPhong = "a";
            pt.tinhTrangPhong = "";
            Assert.IsFalse(phongTro.Delete(pt));
        }

        [TestMethod]
        public void GetAll_Pass()
        {
            PhongTroModel phongTro = new PhongTroModel();
            Assert.IsNotNull(phongTro.getAll());
        }

        [TestMethod]
        public void GetAll_Fail()
        {
            PhongTroModel phongTro = new PhongTroModel();
            Assert.IsNull(phongTro.getAll());
        }
    }
}
