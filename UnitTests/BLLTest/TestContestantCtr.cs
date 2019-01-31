using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Controllers;


namespace UnitTests.BLLTest
{
    [TestClass]
    public class TestContestantCtr
    {
        [TestMethod,Ignore]
        public void InsertContestantCtrl()
        {
            ContestantCtr ContestantCtr = new ContestantCtr();
            ContestantCtr.InsertContestant("Knud", 1013);


        }
    }
    
}
