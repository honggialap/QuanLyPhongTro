using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using DTO;


namespace Model.Tests
{
    [TestClass]
    public class LoginTest
    {
        [TestMethod]
        public void Add_Pass()
        {
            LoginModel login = new LoginModel();
            ACCOUNT ac = new ACCOUNT();
            ac.id = 0;
            ac.taiKhoan = "hello";
            ac.matKhau = "jello";
            Assert.IsTrue(login.ThemTaiKhoan(ac));
        }

        [TestMethod]
        public void Add_Fail()
        {
            LoginModel login = new LoginModel();
            ACCOUNT ac = new ACCOUNT();
            ac.id = 0;
            ac.taiKhoan = "hello";
            ac.matKhau = "jello";
            Assert.IsFalse(login.ThemTaiKhoan(ac));
        }

        [TestMethod]
        public void Edit_Pass()
        {
            LoginModel login = new LoginModel();
            ACCOUNT ac = new ACCOUNT();
            ac.id = 0;
            ac.taiKhoan = "hello";
            ac.matKhau = "jello";
            Assert.IsTrue(login.SuaTaiKhoan(ac));

        }

        [TestMethod]
        public void Edit_Fail()
        {
            LoginModel login = new LoginModel();
            ACCOUNT ac = new ACCOUNT();
            ac.id = 0;
            ac.taiKhoan = "hello";
            ac.matKhau = "jello";
            Assert.IsFalse(login.SuaTaiKhoan(ac));
        }

        [TestMethod]
        public void Delete_Pass()
        {
            LoginModel login = new LoginModel();
            ACCOUNT ac = new ACCOUNT();
            ac.id = 0;
            ac.taiKhoan = "hello";
            ac.matKhau = "jello";
            Assert.IsTrue(login.xoa(ac));
        }

        [TestMethod]
        public void Delete_Fail()
        {
            LoginModel login = new LoginModel();
            ACCOUNT ac = new ACCOUNT();
            ac.id = 0;
            ac.taiKhoan = "hello";
            ac.matKhau = "jello";
            Assert.IsFalse(login.xoa(ac));
        }

        [TestMethod]
        public void Login_Pass()
        {
            LoginModel login = new LoginModel();
            ACCOUNT ac = new ACCOUNT();
            ac.id = 0;
            ac.taiKhoan = "hello";
            ac.matKhau = "jello";
            Assert.IsTrue(login.DangNhap(ac));
        }

        [TestMethod]
        public void Login_Fail()
        {
            LoginModel login = new LoginModel();
            ACCOUNT ac = new ACCOUNT();
            ac.id = 0;
            ac.taiKhoan = "hello";
            ac.matKhau = "jello";
            Assert.IsFalse(login.DangNhap(ac));
        }
    }
}
