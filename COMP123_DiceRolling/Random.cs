using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_DiceRolling
{
    public class Random
    {
        private System.Random _random;
        private int _dice;
        private const int _defaultCount = 36000 ;
        private List<int[]> _diceCount = new List<int[]>(); 

        public int Dice
        {
            get {
                this._dice = _random.Next(1, 7);
                return this._dice;
            }
        }



        public Random(int count = 2)
        {
            _random = new System.Random();

            for (int i = 0; i < count; i++)
            {
                _diceCount.Add(this.DiceRoll());
            }
            
        }

        public int[] DiceRoll(int count = _defaultCount)
        {
            int[] diceRoll = new int[count];

            for (int i = 0; i < count; i++)
            {
                diceRoll[i] = this.Dice;
            }
            return diceRoll;
        }

        public int[] SumOfDicesResults(int count = _defaultCount)
        {
            int[] result = new int[count];
            
            for (int i = 0; i < count ; i++)
            {
                foreach (int[] item in _diceCount)
                {
                    result[i] += item[i] ;
                }
                
                
            }

            return result;
        }


        public void BuildDisplay(int count = _defaultCount)
        {
            int[,] displaTable = new int[6, 6];

                
            for (int i = 0; i < 6; i++)
            {
                for (int ii = 0; ii < 6; ii++)
                {

                        displaTable[i, ii] =i+1+ii+1;
                    
                }
                
            }
           

            int[,] indexSum = new int[6,6];
            int[,] repeatTime = new int[6,6];

            foreach (int value in this.SumOfDicesResults(count))
            {
                 for (int i = 0; i < 6; i++)
                    {
                        for (int ii = 0; ii < 6; ii++)
                        {

                        if (displaTable[i,ii] == value)
                            {
                                //indexSum[i,ii] += displaTable.ElementAt(i)[ii];
                                repeatTime[i,ii]++;
                            }

                        }

                }
                
            }

            display(displaTable, repeatTime);
            
        }

        public void display(int[,] indexSum, int[,] repeatTime)
        {

            for (int i = 0; i < 6; i++)
            {
                for (int ii = 0; ii < 6; ii++)
                {
                    if (indexSum[i, ii] > 9 && repeatTime[i, ii] > 9)
                    {
                        Console.Write("Sum " + indexSum[i, ii] + ", " + repeatTime[i, ii] + " Time| ");

                    }
                    else if (indexSum[i, ii] > 9 && repeatTime[i, ii] < 10)
                    {
                        Console.Write("Sum " + indexSum[i, ii] + ",  " + repeatTime[i, ii] + " Time| ");
                    }
                    else if (indexSum[i, ii] < 10 && repeatTime[i, ii] > 9)
                    {
                        Console.Write("Sum  " + indexSum[i, ii] + ", " + repeatTime[i, ii] + " Time| ");

                    }
                    else if (indexSum[i, ii] < 10 && repeatTime[i, ii] < 10)
                    {
                        Console.Write("Sum  " + indexSum[i, ii] + ",  " + repeatTime[i, ii] + " Time| ");

                    }

                }
                Console.WriteLine();
            }
        }

        public void display1()
        {
            int[,] indexSum = new int[6,6];
            int[,] repeatTime = new int[6,6];


                for (int i = 0; i < 6; i++)
                {
                
                
                    for (int ii = 0; ii < 6; ii++)
                    {

                            indexSum[i,ii] ++;
                    repeatTime[i,ii]++;
                       

                    }
                


            }

            for (int i = 0; i < 6; i++)
            {
                for (int ii = 0; ii < 6; ii++)
                {
                    Console.Write("Sum " + indexSum[i,ii] + ", " + repeatTime[i,ii] + " Times| ");
                }
                Console.WriteLine();
            }
        }

    }
}