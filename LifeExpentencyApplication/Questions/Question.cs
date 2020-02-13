using System;
using System.Collections.Generic;
using System.Text;

namespace LifeExpentencyApplication
{
    public enum TypeOfQuestion
    {
        Fitness,
        General,
        Health
    }
    public class Question
    {
       
        public string QuestionID { get; set; }
        public string Questions { get; set; }
        public int QuestionPoint { get; set; }
        public TypeOfQuestion TypeOfQuestion { get; set; }
        public List<string> PossibleAnswers { get; set; }
        public string Postive { get; set; }
        public string Negative { get; set; }

        public Question()
        {
            Postive = "YES";
            Negative = "NO";
        }

        public Question(string questionid, string questions, string postive, string negative, TypeOfQuestion typeOfQuestion)
        {
            QuestionID = questionid;
            Questions = questions;
            Postive = postive;
            Negative = negative;
            TypeOfQuestion = typeOfQuestion;
        }



    }
}
