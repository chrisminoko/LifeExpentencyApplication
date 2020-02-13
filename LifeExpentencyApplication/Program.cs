using LifeExpentencyApplication.BMI;
using System;

namespace LifeExpentencyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
         
            var person = new Person("Chris",1998,55,1.7F,Gender.Male);
            BMI.BMI.GetPersonsBMI(person);

            Male male = new Male(person,30,40);
            Console.WriteLine(male.Comment);

            Console.WriteLine(BMI.BMI.GetPersonsBMI(person));

            var QuestionLogic = new QuestionLogic();
            QuestionLogic.UserInput(person);
            Console.ReadKey();


        }
    }
}
