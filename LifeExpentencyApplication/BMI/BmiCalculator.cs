using System;
using System.Collections.Generic;
using System.Text;

namespace LifeExpentencyApplication.BMI
{
    public abstract class BmiCalculator
    {
        private Person _person;
        public double MinBMI { get; set; }
        public double MaxBMI { get; set; }
        public double _PersonBMI { get; set; }
        public double PersonBmi
        {
            get
            {
                if (IsCalculated)
                {
                    IsCalculated = true;
                    _PersonBMI = BMI.GetPersonsBMI(_person);
                }

                return _PersonBMI;
            }
        }
        public bool IsCalculated { get; set; }
        public BmiCalculator(Person person)
        {
            _person = person;
        }

        public string Comment 
        {
            get 
            {
                return GetComment();
            }
        }
        private string GetComment() 
        {
            if (_PersonBMI < MinBMI)
            {
                return "You are terribly underweight";
            } 
            else if (_PersonBMI > MinBMI) 
            {
                return "You are over weight";
            }
            return "You got the correct weight";
        }

       
    }
}
