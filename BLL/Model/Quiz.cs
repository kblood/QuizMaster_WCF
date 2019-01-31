using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Model
{
    public class Quiz
    {
        private string title;
        private string description;

        public List<Question> Questions { get; set; }

        public int Id { get; set; }
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                if (value != "")
                {
                    title = value;
                }
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                if (value != "")
                {
                    description = value;
                }
            }
        }

        public DateTime CreateDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public User Author { get; set; }
        // Makes sure the reflection object builder can get the AuthorId to later get the Author
        public int AuthorId { get; set; }

        public Quiz()
        {
            this.CreateDate = DateTime.Now;
            this.UpdatedDate = DateTime.Now;
            this.Questions = new List<Question>();
        }
    }
}
