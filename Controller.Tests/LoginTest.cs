using System;
using Controller;
using DTO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Controller.Tests
{
    [TestClass]
    public class LoginTest
    {
        [TestMethod]
        public void GetAll_Pass()
        {
            LoginControler login = new LoginControler();
            Assert.IsNotNull(login.getAll());
        }

        [TestMethod]
        public void GetAll_Fail()
        {
            LoginControler login = new LoginControler();
            Assert.IsNull(login.getAll());
        }

        [TestMethod]
        public void Edit_Pass()
        {
            LoginControler login = new LoginControler();
            ACCOUNT account = new ACCOUNT();
            account.id = 0;
            account.taiKhoan = "admin";
            account.matKhau = "1";
            Assert.IsTrue(login.edit(account));
        }

        [TestMethod]
        public void Edit_Fail()
        {
            LoginControler login = new LoginControler();
            ACCOUNT account = new ACCOUNT();
            account.id = 16;
            account.taiKhoan = "a";
            account.matKhau = "1";
            Assert.IsFalse(login.edit(account));
        }
    }
}
