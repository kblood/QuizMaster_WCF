using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAL;
using BLL.Model;
using System.Transactions;

namespace UnitTests.DALTest
{
    [TestClass]
    public class StressTest
    {
        [TestMethod]
        public void QuizInstanceRun()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                for (int i = 0; i < 1; i++)
                {
                    var quizInstance = new QuizInstance()
                    {
                        Id = 118,
                        Running = true,
                        Open = false
                    };
                    DBQuiz hest = new DBQuiz();
                    hest.RunQuiz(quizInstance);
                }
                scope.Dispose();
            }
        }
    }
}
