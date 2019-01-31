using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAL;
using System.Collections.Generic;
using BLL.ViewModel;
using Controllers;
using System.Diagnostics;

namespace UnitTests.DALTest
{
    [TestClass]
    public class QuestionViewModelTest
    {
        [TestMethod, Ignore]
        public void QuestionInstance()
        {
            // Quiz needs to be updated, maybe use a rollback and make its own quiz and questions to test
            Guid guid = new Guid("fc259572-55c4-4f80-b50c-19d14e0e420c");
            List<QuestionViewModel> model = new DBQuestionInstance().SeeQuestionsOnQuiz(guid, 1);
            Assert.IsTrue(model.Count==6);
            Assert.IsTrue(model[0].Header == "hat" && model[0].QuestionId==79 && model[0].State==State.CORRECT);
            Assert.IsTrue(model[1].Header == "hest" && model[1].QuestionId == 80 && model[1].State == State.PENDING);
            Assert.IsTrue(model[2].Header == "Søren" && model[2].QuestionId == 96 && model[2].State == State.OPEN);
            Assert.IsTrue(model[3].Header == "Kasper" && model[3].QuestionId == 110 && model[3].State == State.LOCKED);
            Assert.IsTrue(model[4].Header == "Thure" && model[4].QuestionId == 115 && model[4].State == State.WRONG);
            Assert.IsTrue(model[5].Header == "Jesper" && model[5].QuestionId == 120 && model[5].State == State.WRONG);
        }

        [TestMethod, Ignore]
        public void QuestionViewModelPerformanceTest()
        {
            //TestPerson "ab70f9aa-1109-4e22-a3a8-1f23d65ad7a3"
            //QuizInstanceId = 80
            Guid guid = new Guid("ab70f9aa-1109-4e22-a3a8-1f23d65ad7a3");
            int count = 1000;
            int amount = 0;
            for(int i = 0; i < count; i++)
            {
                List<QuestionViewModel> model = new DBQuestionInstance().SeeQuestionsOnQuiz(guid, 80);
                amount += model.Count;
            }
            Assert.AreEqual(25*count, amount);
        }

        [TestMethod, Ignore]
        public void QuestionViewModelPerformanceTest2()
        {
            //TestPerson "ab70f9aa-1109-4e22-a3a8-1f23d65ad7a3"
            //QuizInstanceId = 80
            Guid guid = new Guid("ab70f9aa-1109-4e22-a3a8-1f23d65ad7a3");
            int count = 1;
            int amount = 0;
            for (int i = 0; i < count; i++)
            {
                List<QuestionViewModel> model = new QuestionInstanceCtr().SeeQuestionsOnQuiz(guid, 80);
                amount += model.Count;
            }
            Assert.AreEqual(25 * count, amount);
        }

    }
}
