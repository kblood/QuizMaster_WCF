using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Controllers;
using BLL.Model;

namespace UnitTests.BLLTest
{
    [TestClass]
    public class QuizCtrTest
    {
        [TestMethod]
        public void TestCreateQuiz()
        {
            QuizCtr quizCtr = new QuizCtr();
            User author = new User();
            Quiz quiz = quizCtr.CreateQuiz("testTitle", "testDescription", author);
            Assert.IsNotNull(quiz);
            Assert.AreEqual(quiz.Title, "testTitle");
            Assert.AreEqual(quiz.Description, "testDescription");
            Assert.AreEqual(quiz.Author, author);
        }
    }
}
