using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_DiceRolling
{
    public class Random
    {
        private System.Random random = new System.Random();

        public Random()
        {
            DisplayResult();
        }

        private int dice()
        {
            return random.Next(1, 7);
        }
        public int DiceRoll()
        {
            int diceRoll =  dice() + dice();
            return diceRoll;
        }

        public void DisplayResult()
        {
            Console.WriteLine(DiceRoll()); 
        }
    }
}