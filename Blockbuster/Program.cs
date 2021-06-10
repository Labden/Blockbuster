using System;
using System.Collections.Generic;

namespace Blockbuster
{
    class Program
    {
        static void Main(string[] args)
        {
            bool goOn = true;
            while (goOn == true)
            {
                Console.WriteLine("Welcome to GC Blockbuster");

                Console.WriteLine();
                Console.WriteLine("Please Select a Movie from the List:");

                double movieIndex = GetUserInput();

                List<Movie> Movies = new List<Movie>();
                //we're making a new BlockBusterVideo object, the constructor populates my movieList property of BlockBusterVideo object
                BlockbusterVideo movieList = new BlockbusterVideo();

                movieList.PrintMovies();



                goOn = GetContinue();
            }
        }
        public static double GetUserInput()
        {
            double result = 0;
            bool goOn = true;
            while (goOn)
            {

                Console.WriteLine("Please select a movie you want to watch:");
                double userInput = Int32.Parse(Console.ReadLine());

                if (userInput == 0 || userInput == 1 || userInput == 2 || userInput == 3|| userInput == 5|| userInput == 6)
                {
                    result = userInput;
                    goOn = false;
                }
                else
                {
                    Console.WriteLine("Please enter a valid integer");
                }
            }
            return result;
        }
        static bool GetContinue()
        {
            Console.WriteLine("Do you want to watch the movie? (y/n)");
            string answer = Console.ReadLine().ToUpper();

            if (answer == "Y")
            {
                return true;
            }
            else if (answer == "N")
            {
                Console.WriteLine("Goodbye!");
                return false;
            }
            else
            {
                Console.WriteLine("I didn't understand that, please try again");
                return GetContinue();

            }
        }
        static bool AnotherScene()
        {
            Console.WriteLine("Watch another scene? (y/n)");
            string answer = Console.ReadLine().ToUpper();

            if (answer == "Y")
            {
                return true;
            }
            else if (answer == "N")
            {
                Console.WriteLine("Goodbye!");
                return false;
            }
            else
            {
                Console.WriteLine("I didn't understand that, please try again");
                return AnotherScene();

            }
        }
    }
}
