using BLL.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBContestant
    {
        Repository<Contestant> repository = new Repository<Contestant>();

        /// <summary>
        /// Inserts the given contestant into the database. 
        /// </summary>
        /// <param name="Contestant">The contestant that is to be inserted</param>
        public void InsertContestant(Contestant contestant, int quizInstanceId)
        {
            SqlCommand command = new SqlCommand();

            //contestant.Name = Repository.TrimString(contestant.Name);
            //string commandText = @"INSERT INTO Contestant (Id, Name, QuizInstanceId) 
            //VALUES ('"+contestant.Id+"', '"+contestant.Name+"', "+quizInstanceId+");";

            command.CommandText = "INSERT INTO Contestant (Id, Name, QuizInstanceId) VALUES (@Id, @Name, @QuizInstanceId);";

            //command.Parameters.Add("@Id", SqlDbType.UniqueIdentifier);
            //command.Parameters["@Id"].Value = Guid.NewGuid();
            command.Parameters.AddWithValue("@Id", contestant.Id);
            command.Parameters.AddWithValue("@Name", contestant.Name);
            command.Parameters.AddWithValue("@QuizInstanceId", quizInstanceId);

            repository.ExecuteStatement(command);
        }

        public int GetQuizInstanceIdByContestantId(Guid contestantId)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT QuizInstanceId FROM Contestant where Id=@id";
            command.Parameters.AddWithValue("@id", contestantId);

            return (int)repository.SimpleRead(command);
        }

        /// <summary>
        /// Gets a contestant by contestantId(Guid)
        /// </summary>
        /// <param name="contestantId"></param>
        /// <param name="transaction"></param>
        /// <returns></returns>
        //public Contestant GetContestant(Guid contestantId)
        //{
        //    SqlCommand command = new SqlCommand();
        //    command.CommandText = "SELECT * FROM Contestant where Id=@ContestantId";
        //    command.Parameters.AddWithValue("@ContestantId", contestantId);
        //    return repository.SingleRead(command);
        //}

        /// <summary>
        /// Retuns the contest who gave the correct answer for a question instance
        /// </summary>
        /// <param name="quizInstanceId"></param>
        /// <returns>Contestant</returns>
        internal Contestant GetContestant(int quizInstanceId, int questionId)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM Contestant where Id=(SELECT CorrectAnswer FROM QuestionInstance WHERE QuizInstanceId = @quizInstanceId AND QuestionId = @questionId)";
            command.Parameters.AddWithValue("@quizInstanceId", quizInstanceId);
            command.Parameters.AddWithValue("@questionId", questionId);
            //Contestant contestant = repository.SingleRead(command);

            return repository.SingleRead(command);
        }

        /// <summary>
        /// Returns the contestants on the "Wrong answers list" for a QuestionInstance
        /// </summary>
        /// <param name="quizInstanceId"></param>
        /// <param name="questionId"></param>
        /// <returns></returns>
        public List<Contestant> GetContestants(int quizInstanceId, int questionId)
        {
            List<Contestant> contestants = new List<Contestant>();
            SqlCommand command = new SqlCommand();
            command.CommandText =
            @"SELECT Id, Name, Contestant.QuizInstanceId 
                FROM Contestant INNER JOIN ContestantQuestionInstance 
                ON Contestant.Id = ContestantQuestionInstance.ContestantId 
                WHERE ContestantQuestionInstance.QuizInstanceId = @QuizInstanceId 
                AND ContestantQuestionInstance.QuestionId = @QuestionId";
            command.Parameters.AddWithValue("@QuizInstanceId", quizInstanceId);
            command.Parameters.AddWithValue("@QuestionId", questionId);

            return repository.MultiRead(command);
            //string commandText =
            //    @"SELECT Id, Name, Contestant.QuizInstanceId 
            //    FROM Contestant INNER JOIN ContestantQuestionInstance 
            //    ON Contestant.Id = ContestantQuestionInstance.ContestantId 
            //    WHERE ContestantQuestionInstance.QuizInstanceId = "+quizInstanceId+@" 
            //    AND ContestantQuestionInstance.QuestionId = "+questionId;
            //foreach(Object obj in Repository.MultiRead(commandText, new Contestant()))
            //{
            //    contestants.Add((Contestant)obj);
            //}
        }

        internal List<Contestant> GetContestants(int quizInstanceId)
        {
            List<Contestant> contestants = new List<Contestant>();
            SqlCommand command = new SqlCommand();
            command.CommandText = @"SELECT * FROM Contestant WHERE QuizInstanceId = @QuizInstanceId";
            command.Parameters.AddWithValue("@QuizInstanceId", quizInstanceId);

            return repository.MultiRead(command);
        }
    }
}
