﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameConsole
{
    public class Player
    {
        public string choice;
        public string name;
        public int score = 0;

        public Player()
        {
        }
        public virtual void GetName()
        {

        }
        public virtual void MakeChoice()
        {
         
        }
        public string retrieveChoice()
        {
            return choice;
        }
        public void AddPointToScore()
        {
            score++;
        }
        public int RetrieveScore()
        {
            return score;
        }
    }

}
           

            
    

    
    

    
