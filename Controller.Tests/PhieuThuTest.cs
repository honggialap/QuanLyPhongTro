using System;
using Controller;
using DTO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Controller.Tests
{
    [TestClass]
    public class PhieuThuTest
    {
        [TestMethod]
        public void GetAll_Pass()
        {
            PhieuThuControler phieuThu = new PhieuThuControler();
            Assert.IsNotNull(phieuThu.getAll());
        }

        [TestMethod]
        public void GetAll_Fail()
        {
            PhieuThuControler phieuThu = new PhieuThuControler();
            Assert.IsNull(phieuThu.getAll());
        }

        [TestMethod]
        public void Edit_Pass()
        {
            PhieuThuControler phieuThu = new PhieuThuControler();
            PHIEUTHU pt = new PHIEUTHU();
            pt.ghiChu = "";
            pt.idPhieuThu = 0;
            pt.phiThuePhong = 100;
            pt.phiTuyBien = 100;
            pt.tienDien = 200;
            pt.tienNuoc = 300;
            Assert.IsTrue(phieuThu.edit(pt));
        }

        [TestMethod]
        public void Edit_Fail()
        {
            PhieuThuControler phieuThu = new PhieuThuControler();
            PHIEUTHU pt = new PHIEUTHU();
            pt.ghiChu = "";
            pt.idPhieuThu = 0;
            pt.phiThuePhong = 100;
            pt.phiTuyBien = 100;
            pt.tienDien = 200;
            pt.tienNuoc = 300;
            Assert.IsFalse(phieuThu.edit(pt));
        }
    }
}
