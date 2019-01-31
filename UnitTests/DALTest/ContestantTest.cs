using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL.Model;
using DAL;

namespace UnitTests.DALTest
{
    [TestClass]
    public class ContestantTest
    {
        [TestMethod, Ignore]
        public void TestInsertContestant()
        {
            Contestant contestant = new Contestant("Ole", 1);
            var DB = new DBContestant();
            DB.InsertContestant(contestant, 1017);
        }
    }
}
