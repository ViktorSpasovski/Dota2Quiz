using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dota2_Quiz
{
    public partial class Question
    {
        private string question { get; set; }
        private string[] answers { get; set; }
        public string answer { get; set; }
        
        public Question() { }

        public Question(string question, string[] answers, string answer)
        {
            this.question = question;
            this.answers = answers;
            this.answer = answer;
        }

        public override string ToString()
        {
            return question;
        }

        public string getAnswer1()
        {
            return answers[0];
        }

        public string getAnswer2()
        {
            return answers[1];
        }

        public string getAnswer3()
        {
            return answers[2];
        }
    }
}
