using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LifeExpentencyApplication
{
   
   public class QuestionLogic
    {
        public List<Question> QuestionLists { get; set; }

        public QuestionLogic()
        {
            QuestionLists = new List<Question>
            {
                new Question
                {
                    QuestionID="Q1",
                    Questions="Do you Smoke",
                    QuestionPoint=4,
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
                    QuestionPoint=10,
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
                    QuestionPoint=12,
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
                    QuestionPoint=10,
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

        //public int DecreaseAgeBasedOnBMI(Person person) 
        //{
        //    double bmi = BMI.BMI.GetPersonsBMI(person);
        //    int age = DateTime.Now.Year-(person.YearofBirth);

        //    if (bmi>30) 
        //    {

        //    }
        //    else 
        //    { 
            
            
        //    }
            


        //}


     
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
             

                Console.WriteLine( "Question " + QuestionLenght +" "+question.Questions);
                string answer = Console.ReadLine().ToUpper();
                bool result = answer.All(Char.IsLetter);
                if (result==false) 
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("***Please Enter in Letters only***");
                    break;
                
                }
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
