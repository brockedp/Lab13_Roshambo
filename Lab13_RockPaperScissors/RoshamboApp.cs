using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13_RockPaperScissors
{
    class RoshamboApp
    {
        
        public static int RoshamboBattle(Player player, Player opponent)
        {
            string playerThrow = Enum.GetName(typeof(Roshambo), player.RoValue);
            string opponentThrow = Enum.GetName(typeof(Roshambo), opponent.RoValue);
            Console.WriteLine("You threw: {0}", playerThrow);
            Console.WriteLine("Your opponent threw: {0}", opponentThrow);
            return PlayRPS(playerThrow, opponentThrow);
            
        }
        
        public static int PlayRPS(string player,string opponent)
        {
            if(player == opponent)
            {
                return 0;
            }
            else if (((player == "rock") && (opponent == "scissors")) || ((player == "scissors") && (opponent == "paper")) || ((player == "paper") && (opponent == "rock")))
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }
    }
}
