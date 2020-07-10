using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DTO;
using Model;

namespace Model.Tests
{
    [TestClass]
    public class PhieuChiTest
    {
        [TestMethod]
        public void Add_Pass()
        { 
            PhieuChiModel phieuChi = new PhieuChiModel();
            PHIEUCHI pc = new PHIEUCHI();
            pc.tienNuoc = 100;
            pc.tienKhac = 200;
            pc.tienDien = 300;
            pc.tenPhieuChi = "";
            pc.idPhieuChi = 10;
            Assert.IsTrue(phieuChi.Add(pc));
        }

        [TestMethod]
        public void Add_Fail()
        {
            PhieuChiModel phieuChi = new PhieuChiModel();
            PHIEUCHI pc = new PHIEUCHI();
            pc.tienNuoc = 100;
            pc.tienKhac = 200;
            pc.tienDien = 300;
            pc.tenPhieuChi = "";
            pc.idPhieuChi = 10;
            Assert.IsFalse(phieuChi.Add(pc));
        }

        [TestMethod]
        public void Edit_Pass()
        {
            PhieuChiModel phieuChi = new PhieuChiModel();
            PHIEUCHI pc = new PHIEUCHI();
            pc.tienNuoc = 100;
            pc.tienKhac = 200;
            pc.tienDien = 300;
            pc.tenPhieuChi = "";
            pc.idPhieuChi = 10;
            Assert.IsTrue(phieuChi.Edit(pc));
        }

        [TestMethod]
        public void Edit_Fail()
        {
            PhieuChiModel phieuChi = new PhieuChiModel();
            PHIEUCHI pc = new PHIEUCHI();
            pc.tienNuoc = 100;
            pc.tienKhac = 200;
            pc.tienDien = 300;
            pc.tenPhieuChi = "";
            pc.idPhieuChi = 10;
            Assert.IsFalse(phieuChi.Edit(pc));
        }

        [TestMethod]
        public void Delete_Pass()
        {
            PhieuChiModel phieuChi = new PhieuChiModel();
            PHIEUCHI pc = new PHIEUCHI();
            pc.tienNuoc = 100;
            pc.tienKhac = 200;
            pc.tienDien = 300;
            pc.tenPhieuChi = "";
            pc.idPhieuChi = 10;
            Assert.IsTrue(phieuChi.Delete(pc));
        }

        [TestMethod]
        public void Delete_Fail()
        {
            PhieuChiModel phieuChi = new PhieuChiModel();
            PHIEUCHI pc = new PHIEUCHI();
            pc.tienNuoc = 100;
            pc.tienKhac = 200;
            pc.tienDien = 300;
            pc.tenPhieuChi = "";
            pc.idPhieuChi = 10;
            Assert.IsFalse(phieuChi.Delete(pc));
        }

        [TestMethod]
        public void GetAll_Pass()
        {
            PhieuChiModel phieuChi = new PhieuChiModel();
            Assert.IsNotNull(phieuChi.getAll());
        }

        [TestMethod]
        public void GetAll_Fail()
        {
            PhieuChiModel phieuChi = new PhieuChiModel();
            Assert.IsNull(phieuChi.getAll());
        }
    }
}
