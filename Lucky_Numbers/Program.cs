﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucky_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numLow, numHigh;
            int[] guesses = new int[6];
            int[] luckyNumbers = new int[6];
            int jackpot = 0;
            int numMatched = 0;
            double winnings = 0;

            Random numGen = new Random();

            String playAgain = "YES";
            Boolean play = true;

            while (play == true)
            {

                numMatched = 0;


                Console.WriteLine("Please enter a starting number.");
                numLow = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter an ending number.");
                numHigh = int.Parse(Console.ReadLine());

                int highLowSplit = numHigh - numLow;
                if (highLowSplit == 0)
                {
                    jackpot = 0;
                }
                else if (highLowSplit <= 10)
                {
                    jackpot = numGen.Next(10, 100) * 100;
                }
                else if (highLowSplit <= 20)
                {
                    jackpot = numGen.Next(100, 500) * 100;
                }
                else
                {
                    jackpot = numGen.Next(1000, 10000) * 100;
                }



                for (int i = 0; i < 6; i++)
                {
                    Console.WriteLine("Please enter your guess for number " + (i + 1) + ".(between " + numLow + " and " + numHigh + ")");
                    guesses[i] = int.Parse(Console.ReadLine());
                    while (guesses[i] < numLow || guesses[i] > numHigh)
                    {
                        Console.WriteLine("Please enter a valid number (between " + numLow + " and " + numHigh + ")");
                        guesses[i] = int.Parse(Console.ReadLine());
                    }
                }

                for (int i = 0; i < 6; i++)
                {
                    luckyNumbers[i] = numGen.Next(numLow, numHigh + 1);
                    Console.WriteLine("Lucky Number: " + luckyNumbers[i]);
                }

                for (int i = 0; i < 6; i++)
                {
                    Console.WriteLine("Lucky Number: " + luckyNumbers[i]);
                }

                for (int i = 0; i < 6; i++)
                {
                    if (guesses[i] == luckyNumbers[i])
                    {
                        numMatched++;
                    }
                }


                Console.WriteLine("The jackpot is " + jackpot + ".");

                switch (numMatched)
                {
                    case 0:
                        Console.WriteLine("You didnt guess any numbers. Beter luck next time!");
                        break;

                    case 1:
                        winnings = Math.Round(jackpot * .01, 0);
                        Console.WriteLine("You matched " + numMatched + " correctly! you win $" + winnings);
                        break;

                    case 2:
                        winnings = Math.Round(jackpot * .05, 0);
                        Console.WriteLine("You matched " + numMatched + " correctly! you win $" + winnings);
                        break;

                    case 3:
                        winnings = Math.Round(jackpot * .1, 0);
                        Console.WriteLine("You matched " + numMatched + " correctly! you win $" + winnings);
                        break;

                    case 4:
                        winnings = Math.Round(jackpot * .21, 0);
                        Console.WriteLine("You matched " + numMatched + " correctly! you win $" + winnings);
                        break;

                    case 5:
                        winnings = Math.Round(jackpot * .40, 0);
                        Console.WriteLine("You matched " + numMatched + " correctly! you win $" + winnings);
                        break;

                    case 6:
                        Console.WriteLine("JACKPOT!!! Congratulations, you win $" + jackpot + ".");
                        if (jackpot == 0) Console.WriteLine("filthy cheater.");
                        break;
                }

                Console.WriteLine("Would you like to play again?(YES/NO)");
                playAgain = Console.ReadLine().ToUpper();
                if (playAgain == "YES")
                {
                    Console.WriteLine("Good Luck");
                }
                else
                {
                    play = false;
                    Console.WriteLine("Thanks for playing!");
                }
            }

        }



    }
}
