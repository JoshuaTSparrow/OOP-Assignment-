using OOP_Assignment;
using System;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }
        static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to My Maths Game Program");
            Console.WriteLine("1) Start Game");
            Console.WriteLine("2) Tutorial");
            Console.WriteLine("3) Exit");
            Console.WriteLine("");
            Console.WriteLine("Please Enter a number to select it on the menu");
            string UserChoice;
            UserChoice = Console.ReadLine();

            switch (UserChoice)
            {
                case "1":
                    StartGame();
                    break;
                case "2":
                    Tutorial();
                    break;
                case "3":
                    Quit();
                    break;
            }
            MainMenu();
        }



        static void StartGame()
        {
            Console.Clear();
            {
                Deck deck = new Deck();
                Card card1 = deck.DrawCard();
                Card card2 = deck.DrawCard();

                int number1 = card1.Rank switch
                {
                    "Ace" => 1,
                    "Jack" => 11,
                    "Queen" => 12,
                    "King" => 13,
                    _ => int.Parse(card1.Rank)
                };

                int number2 = card2.Rank switch
                {
                    "Ace" => 1,
                    "Jack" => 11,
                    "Queen" => 12,
                    "King" => 13,
                    _ => int.Parse(card2.Rank)
                };

                string operation = card1.Suit switch
                {
                    "Spades" => "+",
                    "Hearts" => "-",
                    "Diamonds" => "*",
                    "Clubs" => "/"
                };

                Console.WriteLine($"What is {number1} {operation} {number2}?");

                string userAnswer = Console.ReadLine();

                if (int.TryParse(userAnswer, out int result))
                {
                    int answer = operation switch
                    {
                        "+" => number1 + number2,
                        "-" => number1 - number2,
                        "*" => number1 * number2,
                        "/" => number1 / number2,
                        _ => throw new InvalidOperationException($"Invalid operator: {operation}")
                    };

                    if (result == answer)
                    {
                        Console.WriteLine("Correct!");
                    }
                    else
                    {
                        Console.WriteLine($"Incorrect. The answer is {answer}.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer");
                }

                Console.WriteLine("Would you like to play again? (y/n)");
                string UserChoice;
                UserChoice = Console.ReadLine();

                switch (UserChoice)
                {
                    case "y":
                        StartGame();
                        break;
                    case "n":
                        MainMenu();
                        break;

                }
            }
        }

        static void Tutorial()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the tutorial");
            Console.WriteLine("This Program is very simple to use.");
            Console.WriteLine("Input the anwser to the equation");
            Console.WriteLine("Then you will be right or wrong and asked to play again");
            Console.WriteLine();
            Console.WriteLine("To go back to the Menu Press Enter");
            Console.ReadLine();
        }

        static void Quit()
        {
            Console.Clear();
            Console.WriteLine("Are you Sure you want to Leave (Y/N)");
            string UserChoice;
            UserChoice = Console.ReadLine();

            switch (UserChoice)
            {
                case "y":
                    Console.WriteLine("Goodbye");
                    Environment.Exit(0);
                    break;
                case "n":
                    MainMenu();
                    break;

            }
        }

    }

} 
