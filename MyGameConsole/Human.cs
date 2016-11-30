using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameConsole
{
    public class Human : Player
    {




        public override void GetName()
        {
            
            Console.WriteLine("What is your player name? \n");
            name = Console.ReadLine().ToLower();
            if (name.Equals(""))
            {
                Console.WriteLine("Invalid! please enter a name \n");
                GetName();
            }


        }
        public override void MakeChoice()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("{0} what will you pick : rock , paper , scissor , lizard , spock \n", name);
            choice = Console.ReadLine().ToLower();
            Console.ResetColor();
            if (choice.Equals(""))
            {
                Console.WriteLine("Invalid answer, please re-enter");
                MakeChoice();
                    
            }

        }
        }
    }
