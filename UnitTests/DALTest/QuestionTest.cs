using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL.Model;
using DAL;
using System.Collections.Generic;

namespace UnitTests.DALTest
{
    [TestClass]
    public class QuestionTest
    {
        /// <summary>
        /// Warning: This method alters the DB
        /// Inserts a Question with two Answers to test "insert question"
        /// </summary>
        [TestMethod, Ignore]
        public void CreateQuestionTest()
        {
            DBQuestion dbquestion = new DBQuestion();

            Question question = new Question();
            question.Header = "TestQuestion";
            question.Text = "What is your favorite colour?";
            question.CreateDate = DateTime.Now;

            Answer answer = new Answer();
            answer.Text = "blue";

            Answer correct = new Answer();
            correct.Text = "yellow";

            Answer answer2 = new Answer();
            answer2.Text = "green";

            Answer answer3 = new Answer();
            answer3.Text = "red";

            question.Answers.Add(answer);
            question.Answers.Add(correct);
            question.Answers.Add(answer2);
            question.Answers.Add(answer3);

            question.CorrectAnswer = correct;

            dbquestion.SaveQuestion(question);
        }

        [TestMethod, Ignore]
        public void findQuestionsTest()
        {
            DBQuestion dbQuestion = new DBQuestion();
            var questions = dbQuestion.GetAll();
            Assert.IsTrue(questions.Count >= 2);
            foreach (Question question in questions)
            {
                Assert.IsTrue(question != null, "Question is null");
                Assert.IsTrue(question.CreateDate != null, "Question has no create date");
                Assert.IsTrue(question.Id != 0, "Question id is 0");
                Assert.IsTrue(question.Text != null, "Question has no text.");
            }
        }

        [TestMethod, Ignore]
        public void getQuestionWithAnswers()
        {
            DBQuestion dbQuestion = new DBQuestion();
            Question question = dbQuestion.GetQuestionWithAnswers(239);
            Assert.IsTrue(question != null);
            Assert.IsTrue(question.CorrectAnswer==null);
            Assert.IsTrue(question.Answers.Count==4);
            Assert.AreEqual(question.Answers[0].Text, "England");
        }

        /// <summary>
        /// This method is obsolete and should not be run. 
        /// To run it anyway, insert a valid questionID (and remove [ignore])
        /// </summary>
        /*[TestMethod, Ignore]
        public void InsertAnswerTest()
        {
            List<Answer> answers = new List<Answer>();
            answers.Add(new Answer("Hat1"));
            answers.Add(new Answer("Hat2"));
            answers.Add(new Answer("Hat3"));
            Answer correct = new Answer("Correct");
            answers.Add(correct);
            var con = new Repository().GetConnection();
            var trans = con.BeginTransaction();
            int returnKey = new DBAnswer().SaveAnswers(con, trans, "This value needs to be a valid QuestionId", answers, correct);
            trans.Commit();
            Assert.IsTrue(returnKey > 0);
        }*/
    }
}
