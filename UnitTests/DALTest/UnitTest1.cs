using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;

namespace UnitTests.DALTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestScore()
        {
            Guid id = new Guid("be26953d-016d-454a-80b8-d08e6c8cf9ba");
            List<string> highscore = new Controllers.ContestantCtr().GetScoreTable(id);
            foreach(String score in highscore)
            {
                Debug.WriteLine(score);
            }
        }
    }
}
