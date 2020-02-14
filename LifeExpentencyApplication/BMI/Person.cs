using System;
using System.Collections.Generic;
using System.Text;

namespace LifeExpentencyApplication
{
    public enum Gender 
    {
    Male=0,
    Female=1
    }
    public class Person
    {
        public string PersonName { get; set; }
        public int YearofBirth { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public Gender Gender { get; set; }
        public Person()
        {
        }
        public Person(string name,int yearofbirth,double weight,double height ,Gender gender)
        {
            PersonName = name;
            YearofBirth = yearofbirth;
            Weight = weight;
            Height = height;
            Gender = gender;
        }

     
    }
}
