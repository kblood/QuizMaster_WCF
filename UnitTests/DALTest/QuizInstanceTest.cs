using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL.Model;
using DAL;
using System.Data.SqlClient;
using System.Data;
using Controllers;
using System.Transactions;

namespace UnitTests.DALTest
{
    [TestClass]
    public class QuizInstanceTest
    {
        [TestMethod, Ignore]
        public void OpenQuizTest()
        {
            Repository<Quiz> rep = new Repository<Quiz>();

            // Begin a transaction
            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection db = new SqlConnection(rep.ConnectionString))
                {
                    db.Open();
                    SqlCommand command = db.CreateCommand();

                    Quiz quiz = new Quiz();
                    quiz.Id = 1;
                    User user = new User();
                    user.Id = 1;
                    QuizInstance quizInstance = new DBQuiz().OpenQuiz(quiz, user);
                    Assert.IsTrue(quizInstance != null);
                    if (quizInstance != null)
                    {
                        Assert.IsTrue(quizInstance.Open);
                    }
                    // Attempt to roll back the transaction.
                }
                scope.Dispose();
            }
        }

        [TestMethod, Ignore]
        public void GetActiveQuiz()
        {
            // Checks if quizInstance is !open
            QuizCtr quizCtr = new QuizCtr();
            var quizInstans = quizCtr.GetActiveQuizByUserId(28);
            Assert.IsNull(quizInstans);



        }
    }

   

}
