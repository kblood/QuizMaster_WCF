using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL.Model;

namespace UnitTests.BLLTest
{
    [TestClass]
    public class AnswerTest
    {
        [TestMethod]
        public void TestEquals()
        {
            Answer answer1 = new Answer() { Id = 4 , Text = "answer"};
            Answer answer2 = new Answer() { Id = 4,  Text = "answer"};

            Assert.IsTrue(answer1.Equals(answer2));

        }
    }
}
