using System;
using System.Collections.Generic;
using System.Text;

namespace LifeExpentencyApplication.BMI
{
    public static class MainCalculator
    {

        public static BmiCalculator GetBmiCalculator(this Person person)
        {
            if (person.Gender==Gender.Female)
            {
                return new Male(person, 20, 25);
            }
            else 
            {
                return new Female(person, 18, 22);
            }
        }

    }
}
