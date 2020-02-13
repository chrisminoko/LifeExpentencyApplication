using System;
using System.Collections.Generic;
using System.Text;

namespace LifeExpentencyApplication.BMI
{
   public static class BMI
    {
        public static double GetPersonsBMI(Person person) 
        {
            return person.Weight / Math.Pow(person.Height, 2);
        }
    }
}
