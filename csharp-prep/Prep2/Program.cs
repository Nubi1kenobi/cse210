using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear(); //clears the console for a fresher look
        Console.WriteLine("Hello Prep2 World!");
        var classGrade = 0;
        
        string letter;
        string sign = "";
        string endStatement = "";
        int lastDigit = 7;
        
            Console.Write("Using integers, what is your grade percentage? ");
            classGrade = int.Parse(Console.ReadLine());     // I was struggling with the input, it kept changing on me usingf Console.Read(), used the current to get around the issue. 
            lastDigit = classGrade % 10;

            if (classGrade >= 90)
            {
                letter = "A";    
            }

            else if (classGrade >= 80)
            {
                letter = "B";    
            }

            else if (classGrade >= 70)
            {
                letter = "C";    
            }

            else if (classGrade >= 60)
            {
                letter = "D";    
            }

            else
            {
                letter = "F";    
            }

        switch(lastDigit)
        {
            case < 3:
                sign = "-";
            break;

            case >= 7:
                sign = "+";
            break;
         }

        if (classGrade >= 94) 
        {
            letter = "A";
            sign = "";
            endStatement = " What a FANTASTC grade, congrats!";
        }

        else if (classGrade < 60)
        {
            sign = "";
            endStatement = " Mistakes were made. Better luck next time.";
        }

        Console.WriteLine($"Your grade, {classGrade}% equals a(n) {letter}{sign}.{endStatement}");    
    }   
}