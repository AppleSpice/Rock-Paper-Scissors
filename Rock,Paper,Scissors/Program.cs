﻿using System;

namespace Rock_Paper_Scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCPU;
            int randomInt;
            int scorePlayer = 0;
            int scoreCPU = 0;
            bool playAgain = true;

            while (playAgain == true)
            {





                while (scorePlayer < 3 && scoreCPU < 3)
                {

                    Console.WriteLine("Choose ROCK, PAPER, SCISSORS:     ");
                    inputPlayer = Console.ReadLine();

                    Random rnd = new Random();

                    randomInt = rnd.Next(1, 4);

                    switch (randomInt)
                    {
                        case 1:
                            inputCPU = "ROCK";
                            Console.WriteLine("Computer Chose ROCK");
                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("DRAW!!\n\n");

                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("PLAYER WINS!!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("CPU WINS!!\n\n");
                                scoreCPU++;
                            }
                            break;

                        case 2:
                            inputCPU = "PAPER";
                            Console.WriteLine("Computer Chose PAPER");
                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("CPU WINS!!\n\n");
                                scoreCPU++;
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("DRAW!!\n\n");

                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("PLAYER WINS!!\n\n");
                                scorePlayer++;
                            }
                            break;

                        case 3:
                            inputCPU = "SCISSORS";
                            Console.WriteLine("Computer Chose SCISSORS");
                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("PLAYER WINS!!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("CPU WINS!!\n\n");
                                scoreCPU++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("DRAW!!\n\n");

                            }
                            break;

                        default:
                            Console.WriteLine("Invalid entry!");
                            break;
                    }
                }

                if (scorePlayer == 3)
                {
                    Console.WriteLine("PLAYER WINS!!");
                }
                else if (scoreCPU == 3)
                {
                    Console.WriteLine("CPU WON!!")
                }
                else
                {

                }

                Console.WriteLine("Do you want to play again? (y/n)");
                string loop = Console.ReadLine();
                if (loop == "y")
                {
                    playAgain = true;
                }
                else if (loop == "n")
                {
                    playAgain = false;
                }
                else
                {

                }
            }
        }
    }
}
