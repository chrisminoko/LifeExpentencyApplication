using System;
using System.Collections.Generic;
using System.Text;

namespace LifeExpentencyApplication.BMI
{
   public class PersonLogic
    {
       public Person person;
        public PersonLogic()
        {
            person = new Person();
        }

        public void EnterDetails()
        {


            Console.WriteLine("**Welcome To the The Life Expentency Application*** \n");

            Console.WriteLine("Please Enter your name");
            string Name = Console.ReadLine();


            Console.WriteLine("**Part 1 --- BMI Calculator---*** \n");

            Console.WriteLine("Please Enter your Year of Birth");
            int YearOfbirth = int.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter your Weight");
            double Weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter your Height");
            double Height = double.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter your Gender : Male=0 or Female=1");
            int GenderCode = int.Parse(Console.ReadLine());
            if (GenderCode == 0)
            {
                person = new Person(Name, YearOfbirth, Weight, Height, Gender.Male);
            }
            else if (GenderCode == 1)
            {
               person = new Person(Name, YearOfbirth, Weight, Height, Gender.Female);
            }





        }
    }
}
