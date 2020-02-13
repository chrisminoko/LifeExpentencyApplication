using System;
using System.Collections.Generic;
using System.Text;

namespace LifeExpentencyApplication
{
   public class Effects
    {
        public int defaultAge { get; set; }
        public int PointEffects { get; set; }
        public Effects()
        {
            defaultAge = 18;
        }
        public Effects(int pointincreasse, QuestionLogic question)
        {
            PointEffects = pointincreasse;
            question = new QuestionLogic();
        }

        public int AgeIncreas() 
        {

            return defaultAge + PointEffects;
        }
    }
}
