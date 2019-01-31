using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAL;
using BLL.Model;

namespace UnitTests.DALTest
{
    [TestClass]
    public class QuizTest
    {
        [TestMethod]
        public void FindQuizTest()
        {
            DBQuiz dbquiz = new DBQuiz();
            var quizzes = dbquiz.GetAll();
            Assert.IsTrue(quizzes.Count >= 2);
            foreach (Quiz quiz in quizzes)
            {
                Assert.IsTrue(quiz != null, "Quiz is null");
                Assert.IsTrue(quiz.CreateDate != null,"Quiz has no create date");
                Assert.IsTrue(quiz.UpdatedDate != null,"Quiz has no updated date");
                Assert.IsTrue(quiz.Id != 0, "Quiz id is 0");
                Assert.IsTrue(quiz.Title != null, "Quiz has no title.");
            }
        }

        [Ignore]
        [TestMethod]
        public void CreateQuizTest()
        {
            DBQuiz dbquiz = new DBQuiz();

            Quiz quiz = new Quiz();
            quiz.Title = "New Quiz";
            quiz.Description = "New quiz for students";
            quiz.Author = new User();
            quiz.Author.Id = 1;
            
            dbquiz.SaveQuiz(quiz);
        }

        //[Ignore]
        //[TestMethod]
        //public void OpenQuizTest()
        //{
        //    DBQuiz dbquiz = new DBQuiz();
        //    var quizzer = dbquiz.GetAll();

        //    Quiz quiz = quizzer[0];
        //    quiz.Open = true;
        //    dbquiz.OpenQuiz(quiz);

        //    quizzer = dbquiz.GetAll();
        //    quiz = quizzer[0];
        //    Assert.IsTrue(quiz.Open);

        //    quiz.Open = false;
        //    dbquiz.OpenQuiz(quiz);
        //    quizzer = dbquiz.GetAll();
        //    quiz = quizzer[0];
        //    Assert.IsFalse(quiz.Open);
        //}

        //[TestMethod, Ignore]
        //public void StopQuiz()
        //{
        //    Quiz testQuiz = new Quiz();
        //    testQuiz.Id = 4;
        //    testQuiz.Running = true;
        //    DBQuiz dbQuiz = new DBQuiz();
        //    dbQuiz.RunQuiz(testQuiz);
        //    Assert.IsTrue(dbQuiz.GetQuizRunningById(testQuiz.Id));
        //    DBQuestionInstance dbQI = new DBQuestionInstance();
        //    Guid guid = new Guid("8ee21ba7-629c-4572-b308-3b6acdbb8b41");
        //    Assert.IsTrue(dbQI.SeeQuestionsOnQuiz(guid, testQuiz.Id).Count==3);

        //    testQuiz.Running = false;
        //    dbQuiz.RunQuiz(testQuiz);
        //    Assert.IsFalse(dbQuiz.GetQuizRunningById(testQuiz.Id));
        //    Assert.IsTrue(dbQI.SeeQuestionsOnQuiz(guid, testQuiz.Id).Count == 0);
        //}

        [TestMethod, Ignore]
        public void AddQuestion()
        {
            //These values may become invalid, making the test fail!
            int quizId = 1;
            //This value must change every time!
            int questionId = 85;

            new DBQuiz().AddQuestion(quizId, questionId);
        }
    }
}
