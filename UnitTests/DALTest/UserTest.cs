using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAL;
using BLL.Model;
using Controllers;

namespace UnitTests.DALTest
{
    [TestClass]
    public class UserTest
    {
        [TestMethod]
        public void FindUser()
        {
            User user = new DBUser().GetById(1);
            Assert.IsTrue(user.Id == 1);
            user = new DBUser().GetByName(user.Username);
            Assert.IsTrue(user.Username != "" && user.Username != null);
        }

        [TestMethod]
        public void InsertUser()
        {
            User user = new User("ThureKasperJesperHenrikOle1234", User.HashThisPassword("4321"));
            var dbUser = new DBUser();
            //var userCtr = new UserCtr();
        
            //userCtr.InsertUser("ThureKasperJesperHenrikOle1234", user.Password);
            dbUser.InsertUser(user);
            User extractedUser = dbUser.GetByName(user.Username);
            //Assert.IsTrue(extractedUser.Password.Equals(user.Password));
            Assert.IsTrue(extractedUser.Username.Equals(user.Username));
        }
    }
}