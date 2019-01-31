using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Model
{
    public class Answer
    {
        public int Id { get; set; }

        public string Text { get; set; }

        /// <summary>
        /// Basic Answer constructor
        /// </summary>
        public Answer()
        {

        }

        /// <summary>
        /// Answer contructor that adds the answer text 
        /// </summary>
        /// <param name="text">answer text</param>
        public Answer(string text)
        {
            Text = text;
        }
        /// <summary>
        /// Checks if text equals text and id
        /// Caster obj to Answer
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            
            Answer answer = obj as Answer;
            return answer.Id == this.Id && answer.Text == this.Text;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
