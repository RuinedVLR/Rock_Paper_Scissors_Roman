using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors_Roman
{
    internal class Program
    {
        static Random random = new Random();
        static string[] option = { "rock", "paper", "scissors", "dynamite" };
        static string userInput = " ";
        static int userWins = 0;
        static int computerWins = 0;
        static int computerChoice;


        static void Main(string[] args)
        {

            while(userWins < 3 && computerWins < 3)
            {
                Console.WriteLine("Write an option: ");
                Console.WriteLine("1. Rock");
                Console.WriteLine("2. Paper");
                Console.WriteLine("3. Scissors");
                Console.WriteLine("4. Dynamite");

                computerChoice = random.Next(0, 4);

                userInput = Console.ReadLine().ToLowerInvariant();

                Console.Clear();

                if (string.IsNullOrWhiteSpace(userInput) || userInput != "rock" && userInput != "paper" && userInput != "scissors" && userInput != "dynamite")
                {
                    Console.WriteLine("Invalid input, try again");
                    Console.ReadKey(true);
                    Console.Clear();
                    continue;
                }
                else if (option[computerChoice] == "dynamite" && userInput == "dynamite")
                {
                    Console.WriteLine("You chose: " + userInput);
                    Console.WriteLine("Computer chose: " + option[computerChoice]);
                    Console.WriteLine("You both chose Dynamite! Game ends.");
                    Console.ReadKey(true);
                    Console.Clear();

                    if(userWins > computerWins)
                    {
                        Console.WriteLine("You are the winner! Score is " + userWins + " - " + computerWins);
                        Console.ReadKey(true);
                    }
                    else if(computerWins > userWins)
                    {
                        Console.WriteLine("Computer is the winner! Score is " + userWins + " - " + computerWins);
                        Console.ReadKey(true);
                    }
                    else
                    {
                        Console.WriteLine("Draw! Score is " + userWins + " - " + computerWins);
                        Console.ReadKey();
                    }

                    break;
                }
                else if (option[computerChoice] == userInput)
                {
                    Console.WriteLine("You chose: " + userInput);
                    Console.WriteLine("Computer chose: " + option[computerChoice]);
                    Console.WriteLine("Draw. No points earned.");
                }
                else if (option[computerChoice] == "rock" && userInput == "paper")
                {
                    UserWins();
                }
                else if (option[computerChoice] == "rock" && userInput == "scissors")
                {
                    ComputerWins();
                }
                else if (option[computerChoice] == "paper" && userInput == "scissors")
                {
                    UserWins();
                }
                else if (option[computerChoice] == "scissors" && userInput == "paper")
                {
                    ComputerWins();
                }
                else if (option[computerChoice] == "paper" && userInput == "rock")
                {
                    ComputerWins();
                }
                else if (option[computerChoice] == "scissors" && userInput == "rock")
                {
                    UserWins();
                }
                else if (option[computerChoice] == "dynamite" && userInput == "rock")
                {
                    ComputerWins();
                }
                else if (option[computerChoice] == "dynamite" && userInput == "paper")
                {
                    ComputerWins();
                }
                else if (option[computerChoice] == "dynamite" && userInput == "scissors")
                {
                    ComputerWins();
                }
                else if (option[computerChoice] == "rock" && userInput == "dynamite")
                {
                    UserWins();
                }
                else if (option[computerChoice] == "paper" && userInput == "dynamite")
                {
                    UserWins();
                }
                else if (option[computerChoice] == "scissors" && userInput == "dynamite")
                {
                    UserWins();
                }
                Console.ReadKey(true);
                Console.Clear();
            }
            
            if(userWins == 3)
            {
                Console.WriteLine("You are the winner! Score is " + userWins + " - " + computerWins);
                Console.ReadKey(true);
            }

            if(computerWins == 3)
            {
                Console.WriteLine("Computer is the winner! Score is " + userWins + " - " + computerWins);
                Console.ReadKey(true);
            }
        }

        static void UserWins()
        {
            

            Console.WriteLine("You chose: " + userInput);
            Console.WriteLine("Computer chose: " + option[computerChoice]);
            userWins++;
            Console.WriteLine($"You win! Score is now: You {userWins} - Computer {computerWins}");
        }

        static void ComputerWins()
        {
            Console.WriteLine("You chose: " + userInput);
            Console.WriteLine("Computer chose: " + option[computerChoice]);
            computerWins++;
            Console.WriteLine($"Computer win! Score is now: You {userWins} - Computer {computerWins}");
        }
    }
}
