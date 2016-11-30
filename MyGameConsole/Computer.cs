using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameConsole
{
    class Computer : Player
    {

        public override void GetName()
        {
            name = "iRobot";
            Console.WriteLine("Hello my name is {0} and I'll be your opponent \n", name);

            
        }
        public override void MakeChoice()
        {
            Random random = new Random();
            List<string> choices = new List<string> { "rock", "paper", "scissor", "lizard", "spock" };
            choice = choices[random.Next(0, 4)];
            Console.WriteLine(choice);

        }
    }
}
