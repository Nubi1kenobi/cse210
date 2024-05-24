using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello Learning03 World!");
        Fraction one = new Fraction();             
        Console.WriteLine(one.GetFractionString());
        Console.WriteLine(one.GetDecimalValue());
   
        Fraction two = new Fraction(6/1);             
        Console.WriteLine(two.GetFractionString());
        Console.WriteLine(two.GetDecimalValue());

        Fraction three = new Fraction(6,7);             
        Console.WriteLine(three.GetFractionString());
        Console.WriteLine(three.GetDecimalValue());

        Fraction four = new Fraction(1,3);             
        Console.WriteLine(four.GetFractionString());
        Console.WriteLine(four.GetDecimalValue());
   
    }

}