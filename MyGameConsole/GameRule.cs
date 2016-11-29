using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameConsole
{
    class GameRule
    {
        public int playerscore;
        public string player;

        public GameRule(int PlayerScore, string player1)
        {
            playerscore = PlayerScore;
            player = player1;
        }



        public void IntroToGameRule()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissor, Lizard, Spock Game! \n \n");
            Console.WriteLine("Game Rules: Scissors cuts Paper, Paper covers Rock, Rock crushes Lizard, Lizard poisons Spock, Spock smashes Scissors");
            Console.WriteLine("Scissors decapitates Lizard, Lizard eats Paper, Paper disproves Spock, Spock vaporizes Rock, Rock crushes Scissors ");
            Console.WriteLine("press enter to continue");
            Console.ReadLine();
        }
        public void ChooseGameType()
        {
            Console.WriteLine("Chose a game types: PVP (Player vs Player) | PVE (Player Vs Computer)");
            string gametype = Console.ReadLine().ToLower();
            if (gametype == "pvp")
            {
                HumanPlayer player = new HumanPlayer();
                player.PlayerVsPlayerIntro();
                player.pvpGameStart();

            }
            else if (gametype == "pve")
            {

            }
        }

    }
}