using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13_RockPaperScissors
{
    class UserPlayer:Player
    {

        public override Roshambo GenerateRoshambo()
        {
            int userThrow = Validator.TryParseInt("What do you want to throw:\n1.Rock\n2.Paper\n3.Scissors\nPlease enter a number:");
            while (!(userThrow >= 1 && userThrow < 5))
            {
                userThrow = Validator.TryParseInt("Please enter 1 for Rock,2 for Paper,3 for Scissors: ");
            }
            if (userThrow == 1)
            {
                return Roshambo.rock;
            }
            else if (userThrow == 2)
            {
                return Roshambo.paper;
            }
            else
            {
                return Roshambo.scissors;
            }
            //return RoValue;

        }

    }
}
