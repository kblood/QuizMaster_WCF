using BLL.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace DAL
{
    public class DBAnswer
    {
        private Repository<Answer> repository = new Repository<Answer>();

        /// <summary>
        /// Saves recieved Answers and returns the id of the correct Answer.
        /// </summary>
        /// <param name="question">The question the answers are connected to</param>
        /// <returns>The id of the correct answer</returns>
        public int SaveAnswers(Question question)
        {
            int returnKey = -1;
            using (TransactionScope scope = new TransactionScope())
            {
                foreach (Answer answer in question.Answers)
                {
                    SqlCommand command = new SqlCommand();
                    command.CommandText = @"INSERT INTO Answer(Text, QuestionId) VALUES (@Text, @QuestionId);";
                    SetParametres(command, question.Id, answer);

                    if (answer.Equals(question.CorrectAnswer))
                    {
                        command.CommandText += " Select Scope_Identity()";

                        //The Id of the correct Answer is saved
                        returnKey = repository.ExecuteStatement(command);
                    }
                    else
                    {
                        repository.ExecuteStatement(command);
                    }
                }
                    // The Complete method commits the transaction. If an exception has been thrown,
                    // Complete is not  called and the transaction is rolled back.
                    scope.Complete();
            }
            return returnKey;
        }

        /// <summary>
        /// Extracted duplicate code. 
        /// Inserts values into the parameter.
        /// *** not used anymore
        /// </summary>
        /// <param name="command">The command that is in use</param>
        /// <param name="questionId">The relevant question</param>
        /// <param name="answer">The relevant answer</param>
        private void SetParametres(SqlCommand command, int questionId, Answer answer)
        {
            command.Parameters.AddWithValue("@Text", answer.Text);
            command.Parameters.AddWithValue("@QuestionId", questionId);
        }

        /// <summary>
        /// Returns all answers for a question
        /// </summary>
        internal List<Answer> GetAnswers(int questionId)
        {
            List<Answer> answers = new List<Answer>();

            SqlCommand command = new SqlCommand();
            command.CommandText = @"SELECT * FROM Answer WHERE QuestionId = @id";
            command.Parameters.AddWithValue("@id", questionId);

            answers = repository.MultiRead(command);

            //foreach (Object obj in repository.MultiRead(command))
            //{
            //    answers.Add((Answer)obj);
            //}
            return answers;
        }
    }
}
