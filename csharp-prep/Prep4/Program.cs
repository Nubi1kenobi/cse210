using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> integerList = new List<int>();
        int enteredNumber;

        Console.Clear(); //clears the console for a fresher look
        Console.WriteLine("Hello Prep4 World!");
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        Console.Write("Enter number: ");
        enteredNumber = int.Parse(Console.ReadLine());

        do while (enteredNumber != 0)
        {
            integerList.Add(enteredNumber);
            Console.Write("Enter number: ");
            enteredNumber = int.Parse(Console.ReadLine());
        }
    }
}