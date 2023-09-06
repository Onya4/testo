using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PasswordCheack.Test
{
    [TestClass]
    public class UnitTest1
    {
        string password = "WhiteM@ry13";
        Cheack cheack = new Cheack();
        [TestMethod]
        public void capital_WhiteMry13_1return()
        {
            string expented = "1";
            string actual = cheack.capital(password);
            Assert.AreEqual(actual, expented);
        }
        [TestMethod]
        public void uppercase_WhiteMry13_1return()
        {
            string expented2 = "1";
            string actual = cheack.uppercase(password);
            Assert.AreEqual(actual, expented2);
        }
        [TestMethod]
        public void number_WhiteMry13_1return()
        {
            string expented3 = "1";
            string actual = cheack.number(password);
            Assert.AreEqual(actual, expented3);
        }
        [TestMethod]
        public void token_WhiteMry13_1return()
        {
            string expented4 = "1";
            string actual = cheack.token(password);
            Assert.AreEqual(actual, expented4);
        }
        [TestMethod]
        public void length_WhiteMry13_1return()
        {
            string expented4 = "1";
            string actual = cheack.lingth(password);
            Assert.AreEqual(actual, expented4);
        }
    }
}

