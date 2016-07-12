using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 /* 
  *Author: Md Mamunur Rahman 
  * Student ID: 300872772  
  * 
  * Date: July 11, 2016 
  * Description: This program demonstrates a Dice Rolling Simulation  
  *  
  * Version: 0.0.2 - call object in driver class 
  */ 

namespace COMP123_DiceRolling
{
    class Program
    {
        static void Main(string[] args)
        {
            Random diceRoll = new Random();

             diceRoll.BuildDisplay();
            

        }
    }
}
