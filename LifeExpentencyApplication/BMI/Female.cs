using System;
using System.Collections.Generic;
using System.Text;

namespace LifeExpentencyApplication.BMI
{
    public class Female:BmiCalculator
    {
        public Female(Person person , double minbmi,double maxbmi) :base(person)
        {
            MinBMI = minbmi;
            MaxBMI = maxbmi;
        }
    }
}
