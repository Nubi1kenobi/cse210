using System;

class Program
{
    static void Main(string[] args)
    {
        int magicNumber;
        int guessedNumber;   
        do
        {
            Console.Clear(); //clears the console for a fresher look
            Console.WriteLine("Hello Prep3 World!");
            Console.Write("What is the magic number? ");
            magicNumber = int.Parse(Console.ReadLine());
            
            Console.Write("What is guess? ");
            guessedNumber = int.Parse(Console.ReadLine());

            if (guessedNumber > magicNumber)
            {
                Console.Clear(); //clears the console for a fresher look
                Console.WriteLine("Lower");
            }

            else if (guessedNumber < magicNumber)
            {
                Console.Clear(); //clears the console for a fresher look
                Console.WriteLine("Higher");
            }

            else if (guessedNumber == magicNumber)
            {
                Console.Clear(); //clears the console for a fresher look
                Console.WriteLine("Congratulations, you are the winner!");
            }
        } while (magicNumber != guessedNumber);
    }
}