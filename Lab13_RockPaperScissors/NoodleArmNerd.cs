using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13_RockPaperScissors
{
    class NoodleArmNerd : Player
    {
        public override Roshambo GenerateRoshambo()
        {
            
            Random rand = new Random();
            int nerdNum = rand.Next(1, 4);
            if (nerdNum == 1)
            {
                return Roshambo.rock;
            }
            else if (nerdNum == 2)
            {
                return Roshambo.paper;
            }
            else
            {
                return Roshambo.scissors;
            }
        }
    }
    
}
