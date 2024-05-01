using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        int magicNumber;
        int guessedNumber;   
        int loopCounter = 0;
        string response;

            Console.Clear(); //clears the console for a fresher look
            
            Console.WriteLine("Hello Prep3 World!");
            
            //Console.Write("What is the magic number? "); //Randomizing the magicNumber now.
            //magicNumber = int.Parse(Console.ReadLine()); //Randomizing the magicNumber now.            


        do
        {
            Random randomGenerator = new Random();
            magicNumber = randomGenerator.Next(1,100);          

            Console.Write("Pick a number between 1 and 100: ");
            guessedNumber = int.Parse(Console.ReadLine());

            do
            {
                loopCounter = ++loopCounter;
                if (guessedNumber > magicNumber)
                {
                    Console.WriteLine("Lower");
                }

                else if (guessedNumber < magicNumber)
                {
                    Console.WriteLine("Higher");   
                }

                Console.Write("What is your guess? ");
                guessedNumber = int.Parse(Console.ReadLine());

            } while (magicNumber != guessedNumber);
            Console.Clear(); //clears the console for a fresher look
            Console.WriteLine($"You guessed the Magic Number in {loopCounter + 1} tries.");
            Console.WriteLine("Would you like to play again? (yes/no)");
            response = Console.ReadLine();
        } while (response == "yes");
    }
}