using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        List<int> integerList = new List<int>();
        int enteredNumber;
        //int sumList = 0;
        //int averageList;
        //int largestNumber;
        
        Console.Clear(); //clears the console for a fresher look
        Console.WriteLine("Hello Prep4 World!");
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        Console.Write("Enter number: ");
        enteredNumber = int.Parse(Console.ReadLine());

        while (enteredNumber != 0)
        {
            integerList.Add(enteredNumber);
            Console.Write("Enter number: ");
            enteredNumber = int.Parse(Console.ReadLine());
        }
        
        Console.WriteLine($"The sum is: {integerList.Sum()}");
        Console.WriteLine($"The averge is: {integerList.Average()}");
        Console.WriteLine($"The largest number is: {integerList.Max()}");
    }
}