using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LifeExpentencyApplication
{
   
   public class QuestionLogic
    {
        public int _age;
        
        public List<Question> QuestionLists { get; set; }
        public QuestionLogic()
        {
            _age = 65;
            QuestionLists = new List<Question>
            {
                new Question
                {
                    QuestionID="Q1",
                    Questions="Do you Smoke",
                    QuestionPoint=8,
                    PossibleAnswers= new List<string>
                    
                    {
                    "Yes",
                    "No"
                    },
                    TypeOfQuestion=TypeOfQuestion.Health
                },
                new Question
                {  
                    QuestionID="Q2",
                    Questions="Do you Drink",
                    QuestionPoint=8,
                    PossibleAnswers= new List<string>
                    {
                    "YES",
                    "NO"
                   
                    }
                    ,
                    TypeOfQuestion=TypeOfQuestion.Health

                },
                new Question
                {
                    QuestionID="Q3",
                    Questions="Do you Exercise",
                    QuestionPoint=4,
                    PossibleAnswers= new List<string>
                    {
                    "YES",
                    "NO"

                    }
                    ,
                    TypeOfQuestion=TypeOfQuestion.Fitness
                },
                new Question
                {
                    QuestionID="Q4",
                    Questions="Do you have Blood Pressure",
                    QuestionPoint=4,
                    PossibleAnswers= new List<string>
                    {
                    "YES",
                    "NO"

                    }
                    ,
                    TypeOfQuestion=TypeOfQuestion.Fitness
                },
                new Question
                {
                    QuestionID="Q5",
                    Questions="DO you have heart issues",
                    QuestionPoint=4,
                    PossibleAnswers= new List<string>
                    {
                    "YES",
                    "NO"

                    }
                    ,
                    TypeOfQuestion=TypeOfQuestion.Fitness
                },
                                new Question
                {
                    QuestionID="Q6",
                    Questions="Have you ever been fined for reckless driving",
                    QuestionPoint=2,
                    PossibleAnswers= new List<string>
                    {
                    "YES",
                    "NO"

                    }
                    ,
                    TypeOfQuestion=TypeOfQuestion.Fitness
                }


            };
           
        }

        public int Age(Person person) 
        {
           return DateTime.Now.Year - (person.YearofBirth);
        }
      
        public void UserInput(Person person) 
        {
            int QuestionLenght = 1;
          
            int points = 0;
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("********* Welcome to the Life Expertence Calculator ******** \n");
            Console.WriteLine(" Please Answer the Following Questions \n");
            Console.ForegroundColor = ConsoleColor.Blue;

            foreach (var question in QuestionLists) 
            {
                Console.WriteLine("Question " + QuestionLenght + " " + question.Questions);
                string answer = Console.ReadLine().ToUpper();


                if (question.Postive == answer)
                {

                    points += question.QuestionPoint;

                }
                else
                {
                    points -= question.QuestionPoint;
                }
                QuestionLenght++;
            }
           

            Console.WriteLine("Your Life Expentency is : "+Age(person)+points);
        
        }


        
    }
}
