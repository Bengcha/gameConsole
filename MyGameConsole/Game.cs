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
        List<string> choices = new List<string> { "rock", "paper", "scissors", "spock", "lizard" };


        public void RunGame()
        {
            DisplayIntroduction();
            DisplayGameRules();
            ChooseGameType();
            ChoosePlayerNames();
            playerStartGame();
            

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


        public void playerStartGame()
        {


            while (player1.RetrieveScore() < 3 && player2.RetrieveScore() < 3)
            {
                GameStart();

            }



                ShowWinner();
                ChooseRestart();
            }

        


        public void ShowWinner()
        {
            if (player1.RetrieveScore() > player2.RetrieveScore())
            {
                Console.WriteLine("Congratz {0} , you are better than {1}!", player1.name, player2.name);
            }
            else if (player1.RetrieveScore() < player2.RetrieveScore())
            {
                Console.WriteLine("Congratz {0}, you are better than {1}", player2.name, player1.name);
            }

            else if (player1.RetrieveScore() == player2.RetrieveScore())
            {
                Console.WriteLine("You both are amazing");
            }

        }

        public void ChooseRestart()
        {
            Console.WriteLine("Game Over! Would you like to play again? Yes | No \n");
            string userInput = Console.ReadLine().ToLower();
            if (userInput == "yes")
            {
                ChoosePlayerNames();
            }
            else if (userInput == "no")
            {
                Console.WriteLine("Hope you enjoy the game. Goobye! \n");
                Console.Read();
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Please enter a valid answer \n");
                ChooseRestart();
            }
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
            else if (player1.choice == "spock" && player2.choice == "paper" || player2.choice == "lizard")
            {
                Console.WriteLine(player2.name + win);
                Console.ReadLine();
                player2.score++;
            }
            else if (player1.choice.Equals("") || player2.choice.Equals(""))
            {

                GameStart();

            }

        }




        }
    }
           

    
