using OOP_Assignment;
using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Dynamic;
using static Main.Program;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu(); // Launches the main program (MainMenu)
        }
        static void MainMenu()
        {   
            Console.Clear();                                                                //Makes the Main menu text 
            Console.WriteLine("Welcome to My Maths Game Program");                      
            Console.WriteLine("1) Start Game");
            Console.WriteLine("2) Tutorial");
            Console.WriteLine("3) Exit");
            Console.WriteLine("");
            Console.WriteLine("Please Enter a number to select it on the menu");
            string UserChoice;
            UserChoice = Console.ReadLine();

            switch (UserChoice)  //Creates the User choice 
            {
                case "1":
                    StartGame(); //Starts the Game
                    break;
                case "2":
                    Tutorial(); //Goes to the tutorial
                    break;
                case "3":
                    Quit(); //Quits the Program
                    break;
            }
            MainMenu();
        }



        static void StartGame() // Starts the game 
        {
            Console.Clear(); //Clears the console. This makes the the game clear the console making it cleaner
            {
                Counter myCounter = new Counter(); // Creates a counter for the scorboard
                int Score = myCounter.GetCount(); // Makes a Varible for the counter


                Deck deck = new Deck(); //Makes a new deck and draws 2 cards
                Card card1 = deck.DrawCard();
                Card card2 = deck.DrawCard();

                int number1 = card1.Rank switch //Changes the Rank of the J,Q,K,A into numbers. This is reaped twice
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

                string operation = card1.Suit switch // Changes the suit of the first card and thi will be the eqution 
                {
                    "Spades" => "+",
                    "Hearts" => "-",
                    "Diamonds" => "*",
                    "Clubs" => "/"
                };

                Console.WriteLine($"Your Score is - {Score}"); //This is the counter for the user
                Console.WriteLine($"What is {number1} {operation} {number2}?"); //Shows the eqution for user and the prompt to awnser

                string userAnswer = Console.ReadLine();

                if (int.TryParse(userAnswer, out int result)) //Calculates the eqution for the awnser 
                {
                    int answer = operation switch
                    {
                        "+" => number1 + number2,
                        "-" => number1 - number2,
                        "*" => number1 * number2,
                        "/" => number1 / number2,
                        _ => throw new InvalidOperationException($"Invalid operator: {operation}")
                    };

                    if (result == answer) //Makes the else if for if the awnser is correct and contine the game
                    {
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
                    else //When the awnser is wrong the game returns to the main menu
                    {
                        Console.WriteLine($"Incorrect. The answer is {answer}.");
                        Console.WriteLine("Press enter to go baxk to menu");
                        Console.ReadLine();
                    }
                }
                else //This is for errors when they dont input a number
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer"); 
                }

            }
        }

        static void Tutorial()  // This is the toutorial for the program
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

        static void Quit() // This is what quits the program. 
        {
            Console.Clear();
            Console.WriteLine("Are you Sure you want to Leave (Y/N)"); //Makes a a prompt for the user to quit 
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

        public class Counter
        {
            private int count = 0; // Declare and initialize the private counter variable

            public void Increment() // Method to increment the counter
            {
                count++;
            }

            public int GetCount() // Method to get the current value of the counter
            {
                return count;
            }
        }

    }

} 
