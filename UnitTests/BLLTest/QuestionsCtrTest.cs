using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL.Model;
using Controllers;

namespace UnitTests.BLLTest
{
    [TestClass]
    public class QuestionsCtrTest
    {
        [TestMethod, Ignore]
        public void SaveQuestionCtrTest()
        {
            QuestionCtr ctr = new QuestionCtr();
            Question question = new Question();
            //Question question = new Question("2-3 træer", "Hvad er 2-3 træer?");
            question.Header = "2-3 træer";
            question.Text = "Hvad er 2-3 træer?";
            Assert.IsTrue(question.Header == "2-3 træer" && question.Text == "Hvad er 2-3 træer?");

            question.AddAnswer("Det er ikke relateret til programming men botani.");
            question.AddAnswer("Et sangomspundet træ der skulle gro i Babylons hængende haver");
            question.AddCorrectAnswer("En form graph der er forbundet der er et balanceret træ.");
            question.AddAnswer("En form graph der er ikke er forbundet men er et træ.");

            Assert.IsTrue(question.Answers.Count == 4);
            Assert.IsTrue(question.CorrectAnswer == question.Answers[2] && question.CorrectAnswer.Text == "En form graph der er forbundet der er et balanceret træ.");
            question.Answers[2].Id = 1337;
            ctr.SaveQuestion(question);
        }

        [TestMethod, Ignore]
        public void findQuestionsTest()
        {
            QuestionCtr ctr = new QuestionCtr();
            var questions = ctr.GetQuestions();
            Assert.IsTrue(questions.Count >= 2);
            foreach (Question question in questions)
            {
                Assert.IsTrue(question != null, "Question is null");
                Assert.IsTrue(question.CreateDate != null, "Question has no create date");
                Assert.IsTrue(question.Id != 0, "Question id is 0");
                Assert.IsTrue(question.Text != null, "Question has no text.");
            }
        }
    }
}
