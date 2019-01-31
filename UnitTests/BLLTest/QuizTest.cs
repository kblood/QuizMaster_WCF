using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL.Model;
namespace UnitTests.BLLTest
{
    [TestClass]
    public class QuizTest
    {
        [TestMethod]
        public void TestTitle()
        {
            Quiz quiz = new Quiz();
            quiz.Title = "testQuiz";
            Assert.AreEqual(quiz.Title, "testQuiz");
        }

        [TestMethod]
        public void TestValidTitle()
        {
            Quiz quiz = new Quiz();
            quiz.Title = "";            
            Assert.IsNull(quiz.Title);
        }


        [TestMethod]
        public void TestDescription()
        {
            Quiz quiz = new Quiz();
            quiz.Description = "testDescription";
            Assert.AreEqual(quiz.Description, "testDescription");
        }

        [TestMethod]
        public void TestValidDescription()
        {
            Quiz quiz = new Quiz();
            quiz.Description = "";
            Assert.IsNull(quiz.Description);
        }

        [TestMethod]
        public void TestCreateDate()
        {
            Quiz quiz = new Quiz();
            DateTime date = DateTime.Now;
            quiz.CreateDate = date;
            Assert.AreEqual(quiz.CreateDate, date);
        }

        [TestMethod]
        public void TestCreateDate2()
        {
            Quiz quiz = new Quiz();
            Assert.IsNotNull(quiz.CreateDate);
        }

        [TestMethod]
        public void TestUpdatedDate()
        {
            Quiz quiz = new Quiz();
            DateTime date = DateTime.Now;
            quiz.UpdatedDate = date;
            Assert.AreEqual(quiz.UpdatedDate, date);
        }

        [TestMethod]
        public void TestUpdatedDate2()
        {
            Quiz quiz = new Quiz();
            Assert.IsNotNull(quiz.UpdatedDate);
        }

        [TestMethod]
        public void TestUser()
        {
            Quiz quiz = new Quiz();
            User user = new User();
            quiz.Author = user;        
            Assert.AreEqual(quiz.Author, user);
        }

        [TestMethod]
        public void TestAddQuestion()
        {
            Quiz quiz = new Quiz();
            Question question1 = new Question();
            Question question2 = new Question();
            quiz.Questions.Add(question1);
            quiz.Questions.Add(question2);
            Assert.IsTrue(quiz.Questions.Contains(question1) && quiz.Questions.Contains(question2));
        }


    }
}
