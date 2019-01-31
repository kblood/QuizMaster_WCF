using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL.Model;
using Controllers;

namespace UnitTests.BLLTest
{
    [TestClass]
    public class QuestionTest
    {
        [TestMethod]
        public void CreateQuestionTest()
        {
            Question question = new Question();
            Assert.IsTrue(question.CreateDate > DateTime.MinValue && question.CreateDate < DateTime.MaxValue);
            //question = new Question("2-3 træer", "Hvad er 2-3 træer?");
            question.Header = "2-3 træer";
            question.Text = "Hvad er 2-3 træer?";
            Assert.IsTrue(question.Header == "2-3 træer" && question.Text == "Hvad er 2-3 træer?");

            question.AddAnswer("Det er ikke relateret til programming men botani.");
            question.AddAnswer("Et sangomspundet træ der skulle gro i Babylons hængende haver");
            question.AddCorrectAnswer("En form graph der er forbundet der er et balanceret træ.");
            question.AddAnswer("En form graph der er ikke er forbundet men er et træ.");

            Assert.IsTrue(question.Answers.Count == 4);
            Assert.IsTrue(question.CorrectAnswer == question.Answers[2] && question.CorrectAnswer.Text == "En form graph der er forbundet der er et balanceret træ.");
        }

        [TestMethod]
        public void CreateAnswerTest()
        {
            Answer answer = new Answer("Rød");
            Assert.IsTrue(answer.Text == "Rød");
        }

        //[TestMethod]
        //public void GetQuizByUsername()
        //{
        //    QuizCtr ctr = new QuizCtr();
        //    Quiz yo = ctr.GetQuizByUserID(0);

        //    Assert.IsTrue(yo.Id == 0);
        //}
    }
}
