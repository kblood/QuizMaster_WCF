using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Model
{
    public class Question
    {
        public int Id { get; set; }

        public string Header { get; set; }

        public string Text { get; set; }

        public List<Answer> Answers { get; set; }

        public Answer CorrectAnswer { get; set; }

        public DateTime CreateDate { get; set; }

        /// <summary>
        /// Basic Question constructor
        /// </summary>
        public Question()
        {
            Answers = new List<Answer>();
            CreateDate = DateTime.Now;
        }

        /// <summary>
        /// Question constructor that sets the question text
        /// </summary>
        /// <param name="text">question text</param>
        //public Question(string header, string text) : this()
        //{
        //    Header = header;
        //    Text = text;
        //}

        /// <summary>
        /// Adds an incorrect answer to the question
        /// </summary>
        /// <param name="text"></param>
        public void AddAnswer(string text)
        {
            Answers.Add(new Answer(text));
        }

        /// <summary>
        /// Add a correct answer to the question 
        /// </summary>
        /// <param name="text"></param>
        public void AddCorrectAnswer(string text)
        {
            Answers.Add(new Answer(text));
            CorrectAnswer = Answers[Answers.Count - 1];
        }

        //public override bool Equals(object obj)
        //{
        //    try
        //    {
        //        return obj.GetType() == typeof(Question) && this.Id == ((Question)obj).Id;
        //    }
        //    catch(Exception ex)
        //    {
        //        return false;
        //    }
        //}

    }
}
