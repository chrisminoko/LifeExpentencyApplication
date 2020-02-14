 using System;
using System.Collections.Generic;
using System.Text;

namespace LifeExpentencyApplication.BMI
{
   public class BMIBrackts
    {
        public double UunderweightBracket { get; set; }
        public double NormalghtBracket { get; set; }
        public double Overheightbracket { get; set; }
        public double ObesityBracket { get; set; }
        public BMIBrackts()
        {
        }
        public BMIBrackts(double underwight,double normalweightbracket,double heightbracket,double obesitybrackt)
        {
            UunderweightBracket = underwight;
            NormalghtBracket = normalweightbracket;
              
        }

    }
}
