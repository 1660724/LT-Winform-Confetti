using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShowMC
{
    public class Question
    {
        public string Content { get; set; }
        public string ImageLink { get; set; }
        public List<string> ListAnswers = new List<string>();
        public string CorrectAnswer { get; set; }
    }
}
