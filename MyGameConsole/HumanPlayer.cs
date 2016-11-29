using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameConsole
{
    class HumanPlayer : GameRule
    {
        public string player2;
        public bool again;
        public int player2Score;

        public HumanPlayer() : base (3, "Player One")
        {


        }

        public void PlayerVsPlayerIntro()
        {
            Console.WriteLine("What is your name Player One? \n");
            player = Console.ReadLine();
            Console.WriteLine("What is your name Player Two? \n");
            player2 = Console.ReadLine();
            Console.WriteLine("{0} VS {1}, goodluck to both of you! \n", player, player2);
            Console.WriteLine("press enter to continue");
            Console.ReadLine();

        }
        public void pvpGameStart()

        { 



            while (player2Score < 3 || playerscore < 3)

            {
                playerscore = 0;
                player2Score = 0;
                string draw = "Its a draw this round";
                string win = " win this round";

                Console.WriteLine("{0} chose first : rock, paper, scissor, lizard, spock ", player);
                string playerInput = Console.ReadLine();
                Console.WriteLine("{0} its your turn: rock, paper, scissor, lizard, spock", player2);
                string player2Input = Console.ReadLine();

                if (playerInput == "rock" && player2Input == "rock")
                {
                    Console.WriteLine(draw);
                    Console.ReadLine();
                }
                else if (playerInput == "rock" && player2Input == "paper" || player2Input == "spock")
                {
                    Console.WriteLine(player2 + win);
                    Console.ReadLine();
                    player2Score++;
                }
                else if (playerInput == "rock" && player2Input == "scissor" || player2Input == "lizard")
                {
                    Console.WriteLine(player + win);
                    Console.ReadLine();
                    playerscore++;
                }
                else if (playerInput == "paper" && player2Input == "paper")
                {
                    Console.WriteLine(draw);
                    Console.ReadLine();
                }
                else if (playerInput == "paper" && player2Input == "scissor" || player2Input == "lizard")
                {
                    Console.WriteLine(player2 + win);
                    Console.ReadLine();
                    player2Score++;
                }
                else if (playerInput == "paper" && player2Input == "rock" || player2Input == "spock")
                {
                    Console.WriteLine(player + win);
                    Console.ReadLine();
                    playerscore++;
                }
                else if (playerInput == "scissor" && player2Input == "scissor")
                {
                    Console.WriteLine(draw);
                    Console.ReadLine();
                }
                else if (playerInput == "scissor" && player2Input == "paper" || player2Input == "lizard")
                {
                    Console.WriteLine(player + win);
                    Console.ReadLine();
                    playerscore++;
                }
                else if (playerInput == "scissor" && player2Input == "rock" || player2Input == "spock")
                {
                    Console.WriteLine(player2 + win);
                    Console.ReadLine();
                    player2Score++;
                }
                else if (playerInput == "lizard" && player2Input == "lizard")
                {
                    Console.WriteLine(draw);
                    Console.ReadLine();
                }
                else if (playerInput == "lizard" && player2Input == "paper" || player2Input == "spock")
                {
                    Console.WriteLine(player + win);
                    Console.ReadLine();
                    playerscore++;
                }
                else if (playerInput == "lizard" && player2Input == "rock" || player2Input == "scissor")
                {
                    Console.WriteLine(player2 + win);
                    Console.ReadLine();
                    player2Score++;
                }
                else if (playerInput == "spock" && player2Input == "spock")
                {
                    Console.WriteLine(draw);
                    Console.ReadLine();
                }
                else if (playerInput == "spock" && player2Input == "scissor" || player2Input == "rock")
                {
                    Console.WriteLine(player + win);
                    Console.ReadLine();
                    playerscore++;
                }
                else if (playerInput == "spock" && player2Input == "paper" || player2Input == "lizard")
                {
                    Console.WriteLine(player2 + win);
                    Console.ReadLine();
                    player2Score++;
                }
                else if (playerInput == "" || player2Input == "")
                {
                    Console.WriteLine("invalid answer");
                    Console.ReadLine();
                    pvpGameStart(); 
                
                }


            } if (playerscore == 3)
            {
                Console.WriteLine("{0} win the Game!", player);
                Console.WriteLine();
            }
            else if (player2Score == 3)
            {
                Console.WriteLine("{} win the Game!", player2);
                Console.ReadLine();
            }
        }
        }
    }
