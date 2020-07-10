using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using DTO;

namespace Model.Tests
{
    [TestClass]
    public class PhieuThuTest
    {
        [TestMethod]
        public void Add_Pass()
        {
            PhieuThuModel phieuThu = new PhieuThuModel();
            PHIEUTHU pt = new PHIEUTHU();
            pt.ghiChu = "";
            pt.idPhieuThu = 0;
            pt.phiThuePhong = 100;
            pt.phiTuyBien = 100;
            pt.tienDien = 200;
            pt.tienNuoc = 300;
            Assert.IsTrue(phieuThu.Add(pt));
        }

        [TestMethod]
        public void Add_Fail()
        {
            PhieuThuModel phieuThu = new PhieuThuModel();
            PHIEUTHU pt = new PHIEUTHU();
            pt.ghiChu = "";
            pt.idPhieuThu = 0;
            pt.phiThuePhong = 100;
            pt.phiTuyBien = 100;
            pt.tienDien = 200;
            pt.tienNuoc = 300;
            Assert.IsFalse(phieuThu.Add(pt));
        }

        [TestMethod]
        public void Edit_Pass()
        {
            PhieuThuModel phieuThu = new PhieuThuModel();
            PHIEUTHU pt = new PHIEUTHU();
            pt.ghiChu = "";
            pt.idPhieuThu = 0;
            pt.phiThuePhong = 100;
            pt.phiTuyBien = 100;
            pt.tienDien = 200;
            pt.tienNuoc = 300;
            Assert.IsTrue(phieuThu.Edit(pt));
        }

        [TestMethod]
        public void Edit_Fail()
        {
            PhieuThuModel phieuThu = new PhieuThuModel();
            PHIEUTHU pt = new PHIEUTHU();
            pt.ghiChu = "";
            pt.idPhieuThu = 0;
            pt.phiThuePhong = 100;
            pt.phiTuyBien = 100;
            pt.tienDien = 200;
            pt.tienNuoc = 300;
            Assert.IsFalse(phieuThu.Edit(pt));
        }

        [TestMethod]
        public void Delete_Pass()
        {
            PhieuThuModel phieuThu = new PhieuThuModel();
            PHIEUTHU pt = new PHIEUTHU();
            pt.ghiChu = "";
            pt.idPhieuThu = 0;
            pt.phiThuePhong = 100;
            pt.phiTuyBien = 100;
            pt.tienDien = 200;
            pt.tienNuoc = 300;
            Assert.IsTrue(phieuThu.Delete(pt));
        }

        [TestMethod]
        public void Delete_Fail()
        {
            PhieuThuModel phieuThu = new PhieuThuModel();
            PHIEUTHU pt = new PHIEUTHU();
            pt.ghiChu = "";
            pt.idPhieuThu = 0;
            pt.phiThuePhong = 100;
            pt.phiTuyBien = 100;
            pt.tienDien = 200;
            pt.tienNuoc = 300;
            Assert.IsFalse(phieuThu.Delete(pt));
        }

        [TestMethod]
        public void GetAll_Pass()
        {
            PhieuThuModel phieuThu = new PhieuThuModel();
            Assert.IsNotNull(phieuThu.getAll());
        }

        [TestMethod]
        public void GetAll_Fail()
        {
            PhieuThuModel phieuThu = new PhieuThuModel();
            Assert.IsNull(phieuThu.getAll());
        }
    }
}
