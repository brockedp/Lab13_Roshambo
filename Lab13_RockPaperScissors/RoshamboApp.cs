using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13_RockPaperScissors
{
    class RoshamboApp
    {
        
        public static int NerdBattle(UserPlayer player, NoodleArmNerd nerd)
        {
            string playerThrow = Enum.GetName(typeof(Roshambo), player.RoValue);
            string nerdThrow = Enum.GetName(typeof(Roshambo), nerd.RoValue);
            Console.WriteLine("You threw :{0}", playerThrow);
            Console.WriteLine("The Punk threw:{0}", nerdThrow);
            return PlayRPS(playerThrow, nerdThrow);
            
        }
        public static int PunkBattle(UserPlayer player, MohawkPunk punk)
        { 

            string playerThrow = Enum.GetName(typeof(Roshambo), player.RoValue);
            string punkThrow = Enum.GetName(typeof(Roshambo), punk.RoValue);
            Console.WriteLine("You threw :{0}",playerThrow);
            Console.WriteLine("The Punk threw:{0}",punkThrow);
            return PlayRPS(playerThrow, punkThrow);
        
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
