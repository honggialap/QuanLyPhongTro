using System;
using Controller;
using DTO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Controller.Tests
{
    [TestClass]
    public class PhieuChiTest
    {
        [TestMethod]
        public void GetAll_Pass()
        {
            PhieuChiControler phieuChi = new PhieuChiControler();
            Assert.IsNotNull(phieuChi.getAll());
        }

        [TestMethod]
        public void GetAll_Fail()
        {
            PhieuChiControler phieuChi = new PhieuChiControler();
            Assert.IsNull(phieuChi.getAll());
        }

        [TestMethod]
        public void Edit_Pass()
        {
            PhieuChiControler phieuChi = new PhieuChiControler();
            PHIEUCHI pc = new PHIEUCHI();
            pc.tienNuoc = 100;
            pc.tienKhac = 200;
            pc.tienDien = 300;
            pc.tenPhieuChi = "";
            pc.idPhieuChi = 10;
            Assert.IsTrue(phieuChi.edit(pc));
        }

        [TestMethod]
        public void Edit_Fail()
        {
            PhieuChiControler phieuChi = new PhieuChiControler();
            PHIEUCHI pc = new PHIEUCHI();
            pc.tienNuoc = 100;
            pc.tienKhac = 200;
            pc.tienDien = 300;
            pc.tenPhieuChi = "";
            pc.idPhieuChi = 10;
            Assert.IsFalse(phieuChi.edit(pc));
        }
    }
}
