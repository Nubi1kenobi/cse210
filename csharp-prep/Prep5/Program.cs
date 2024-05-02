using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;


class Program
{
    static void Main(string[] args)
    {
        Console.Clear(); //clears the console for a fresher look
        Console.WriteLine("Hello Prep5 World!");
        string userName;
        int favNumber;
        int squaredNumber;

        DisplayWelcome();
        userName = PromptUserName();
        favNumber = PromptUserNumber();
        squaredNumber = SquareNumber(favNumber);
        DisplayResult(userName, squaredNumber);


        //Static Functions
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine(); 
            return name;
        }
        
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int aNumber = int.Parse(Console.ReadLine()); 
            return aNumber;
        }
        
        static int SquareNumber(int a)
        {
            int square = (a * a);
            return square;
        }
        
        static void DisplayResult(string a, int b)
        {
            Console.WriteLine($"{a}, the square of your number is {b}");
        }
 
    }
}