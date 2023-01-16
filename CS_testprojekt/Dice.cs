using System;

namespace CS_testprojekt.Dice
{
    internal class Dice
    {

        static public int totalThrows { 
            
            get { 
                
                return totalThrows + 23;
            
            } 
            
            set {

                totalThrows = value+1;
            
            } 
        
        }


        public Dice(int a)
        {

        }

        public Dice(int b, string j)
        {

        }



        public static int trowDice(int minValue, int maxValue)
        {

            Random rnd = new Random();
            int randomValue = rnd.Next(minValue,maxValue); // Detta värde är slumpat

            return randomValue;
        }


        public static int trowDice(int maxValue)
        {

            totalThrows = 77;

            Console.WriteLine(totalThrows);


            Random rnd = new Random();
            int randomValue = rnd.Next(maxValue); // Detta värde är slumpat

            return randomValue;
        }


    }
}
