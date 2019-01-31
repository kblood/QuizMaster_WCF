using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL.Model;
using DAL;
using System.Data.SqlClient;
using System.Data;
using Controllers;

namespace UnitTests.BLLTest
{
    [TestClass]
    public class UserTest
    {
        [TestMethod]
        public void CreateUser()
        {
            User user = new User("Knud", "1234");
            Assert.AreEqual(user.Username, "Knud");
            Assert.AreEqual(user.Password, "1234");
        }

        [TestMethod]
        public void HashPassword()
        {
            User user = new User("Knud", "1234");
            user.HashPassword();
            Assert.IsTrue(user.Password.Equals(User.HashThisPassword(user.Salt+"1234")));
        }
        
        [TestMethod]
        public void ValidateUser()
        {
            UserCtr userCtr = new UserCtr();
            User returnUser = userCtr.ValidateUser("Knud", "1234");
            Assert.AreEqual(returnUser.Username, "Knud");
            Assert.IsTrue(returnUser.Password.Equals(User.HashThisPassword("1234")));
        }

        [TestMethod]
        public void TestGetUserIDByName()
        {
            UserCtr ctrl = new UserCtr();
            int id = ctrl.GetUserID("knud98y234d");
            Assert.IsTrue(0 == id);
        }

        [TestMethod, Ignore]
        public void InsertUserCtrl()
        {
            User user = new User("ThureKasperJesperHenrikOle1234", "03AC674216F3E15C761EE1A5E255F067953623C8B388B4459E13F978D7C846F4");
            UserCtr userCtr = new UserCtr();
            userCtr.InsertUser(user.Username, user.Password);

            var extractedUser = userCtr.ValidateUser(user.Username, user.Password);
            Assert.IsTrue(user.Username == extractedUser.Username);
        }
    }
}