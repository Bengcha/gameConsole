using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameConsole
{
    public class Game
    {
        Player player1;
        Player player2;


        public void RunGame()
        {
            DisplayIntroduction();
            DisplayGameRules();
            ChooseGameType();
            ChoosePlayerNames();
            //loop
            GameStart();
        }




        public void DisplayIntroduction()
        {
            Console.WriteLine("Welcome to the RPSLS (Rock, Paper, Scissor, Lizard, Spock) Game! \n");
        }

        public void DisplayGameRules()
        {
            Console.WriteLine("Game Rules: Scissors cuts Paper, Paper covers Rock, Rock crushes Lizard, Lizard poisons Spock, Spock smashes Scissors");
            Console.WriteLine("Scissors decapitates Lizard, Lizard eats Paper, Paper disproves Spock, Spock vaporizes Rock, Rock crushes Scissors \n");
            Console.WriteLine("press enter to continue...");
            Console.ReadLine();
        }

        public void ChooseGameType()
        {
            Console.WriteLine("Choose your number of players: 1 or 2 \n");
            string gametype = Console.ReadLine().ToLower();
            if (gametype == "1")
            {
                player1 = new Human();
                player2 = new Computer();

            }
            else if (gametype == "2")
            {
                player1 = new Human();
                player2 = new Human();
            }
            else
            {
                Console.WriteLine("Incorrect choice. Please enter a valid choice");
                ChooseGameType();
            }
        }
        public void ChoosePlayerNames()
        {
            player1.GetName();
            player2.GetName();
        }

        public void GameStart()
        {
            player1.MakeChoice();
            player2.MakeChoice();
            string draw = "Its a draw this round";
            string win = " win this round";

            if (player1.choice == "rock" && player2.choice == "rock")
            {
                Console.WriteLine(draw);
                Console.ReadLine();
            }
            else if (player1.choice == "rock" && player2.choice == "paper" || player2.choice == "spock")
            {
                Console.WriteLine(player2.name + win);
                Console.ReadLine();
                player2.score++;
            }
            else if (player1.choice == "rock" && player2.choice == "scissor" || player2.choice == "lizard")
            {
                Console.WriteLine(player1.name + win);
                Console.ReadLine();
                player1.score++;
            }
            else if (player1.choice == "paper" && player2.choice == "paper")
            {
                Console.WriteLine(draw);
                Console.ReadLine();
            }
            else if (player1.choice == "paper" && player2.choice == "scissor" || player2.choice == "lizard")
            {
                Console.WriteLine(player2.name + win);
                Console.ReadLine();
                player2.score++;
            }
            else if (player1.choice == "paper" && player2.choice == "rock" || player2.choice == "spock")
            {
                Console.WriteLine(player1.name + win);
                Console.ReadLine();
                player1.score++;
            }
            else if (player1.choice == "scissor" && player2.choice == "scissor")
            {
                Console.WriteLine(draw);
                Console.ReadLine();
            }
            else if (player1.choice == "scissor" && player2.choice == "paper" || player2.choice == "lizard")
            {
                Console.WriteLine(player1.name + win);
                Console.ReadLine();
                player1.score++;
            }
            else if (player1.choice == "scissor" && player2.choice == "rock" || player2.choice == "spock")
            {
                Console.WriteLine(player2.name + win);
                Console.ReadLine();
                player2.score++;
            }
            else if (player1.choice == "lizard" && player2.choice == "lizard")
            {
                Console.WriteLine(draw);
                Console.ReadLine();
            }
            else if (player1.choice == "lizard" && player2.choice == "paper" || player2.choice == "spock")
            {
                Console.WriteLine(player1.name + win);
                Console.ReadLine();
                player1.score++;
            }
            else if (player1.choice == "lizard" && player2.choice == "rock" || player2.choice == "scissor")
            {
                Console.WriteLine(player2.name + win);
                Console.ReadLine();
                player2.score++;
            }
            else if (player1.choice == "spock" && player2.choice == "spock")
            {
                Console.WriteLine(draw);
                Console.ReadLine();
            }
            else if (player1.choice == "spock" && player2.choice == "scissor" || player2.choice == "rock")
            {
                Console.WriteLine(player1.name + win);
                Console.ReadLine();
                player1.score++;
            }
            else if (player1.choice == "spock" && player2.choice== "paper" || player2.choice == "lizard")
            {
                Console.WriteLine(player2.name + win);
                Console.ReadLine();
                player2.score++;
            }
            else
            {
                Console.WriteLine("invalid answer");
                GameStart();

            }


            if (player1.score == 3)
            {
                Console.WriteLine("{0} win the Game!", player1);
                Console.WriteLine();
            }
            else if (player2.score == 3)
            {
                Console.WriteLine("{} win the Game!", player2);
                Console.ReadLine();
            }
        }
    }
}            

    
