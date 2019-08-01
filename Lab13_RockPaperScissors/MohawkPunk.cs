using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13_RockPaperScissors
{
    class MohawkPunk : Player
    {
        
        public override Roshambo GenerateRoshambo()
        {
            return Roshambo.rock;
        }
    }
}
