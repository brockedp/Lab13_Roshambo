using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13_RockPaperScissors
{
    enum Roshambo { rock=1,paper,scissors }
    abstract class Player
    {
        
        public string Name { get; set; }
        public Roshambo RoValue { get; set; }

        public abstract Roshambo GenerateRoshambo();


        

    }
}
