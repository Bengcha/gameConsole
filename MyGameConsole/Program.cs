using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowWidth = 180;
            GameRule rule = new GameRule(3, "Player One");
            rule.IntroToGameRule();
            rule.ChooseGameType();
        }
    }




}
