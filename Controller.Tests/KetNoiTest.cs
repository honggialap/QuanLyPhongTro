using System;
using Controller;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Controller.Tests
{
    [TestClass]
    public class KetNoiTests
    {
        [TestMethod]
        public void Command_Pass()
        {
            KetNoi ketNoi = new KetNoi();
            String query = "SELECT * FROM ACCOUNT";
            bool result = ketNoi.Command(query);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Command_Fail()
        {
            KetNoi ketNoi = new KetNoi();
            String query = "SELECT * FROM BLABLA";
            bool result = ketNoi.Command(query);
            Assert.IsFalse(result);
        }

    }
}
