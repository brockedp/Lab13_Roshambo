using System;

namespace Lab13_RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring variables
            bool again = true;
            int win = 0;
            int lose = 0;
            int tie = 0;
            int games = 0;

            //Welcome user
            Console.WriteLine("Welcome to the Thunder Dome!!");
            //receive user name
            string userName = GetInput("Please enter your name: ");
            Player player = new UserPlayer();
            player.Name = userName;

            while (again)
            {
                //find who the user wants to play against
                Console.WriteLine("Which opponent would you like to face");
                string opponent = "";
                while(opponent != "m" && opponent != "n")
                {
                    opponent = GetInput("Mohawk Punk(m) or  Noodle Arm Nerd(n): ").ToLower();
                }

                
                player.RoValue = player.GenerateRoshambo();

                // Roshambo battle 
                int battle;
                if (opponent == "m")
                {
                    Player punk = new MohawkPunk();
                    punk.RoValue = punk.GenerateRoshambo();
                    battle = RoshamboApp.RoshamboBattle(player, punk);
                }
                else
                {
                    Player nerd = new NoodleArmNerd();
                    
                    nerd.RoValue = nerd.GenerateRoshambo();
                    battle = RoshamboApp.RoshamboBattle(player, nerd);

                }

                // Tally up wins and loses
                if (battle == 1)
                {
                    Console.WriteLine("You won! :D");
                    win++;
                }
                else if(battle == 2)
                {
                    Console.WriteLine("You lost! :(");
                    lose++;
                }
                else
                {
                    Console.WriteLine("You tied :/");
                    tie++;
                }

                // ask user if they want to play again 
                again = ThrowAgain("Would you like to play again(y/n): ");
                games++;

                Console.Clear();
                if (!again)
                {
                    Console.WriteLine($"{userName}: You played {games} games. Your record is {win}-{lose}-{tie}");
                    Console.WriteLine("Goodbye");
                }

            }
        }

        
        public static string GetInput(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }
        public static bool ThrowAgain(string message)
        {
            string input = "";
            while (input != "y" && input != "n")
            {
                Console.Write(message);
                input = Console.ReadLine();
            }
            if (input == "y")
            {
                return true;
            }
            else
            {
                return false;

            }
        }
    }
}
