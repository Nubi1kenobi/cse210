using System;
public class DebugUtility
{
//object variables***********************************

//contructors**************************************

//methods**************************************************
    // Static Debug methods
    public static void Debug()
    {
        Console.WriteLine("Debug();");
        Console.WriteLine("<Press Any Key>");
        Console.ReadKey();
    }

    public static void Debug(bool parameter)
    {
        Console.WriteLine($"Debug(bool parameter); {parameter}");
        Console.WriteLine("<Press Any Key>");
        Console.ReadKey();
    }
    public static void Debug(string parameter)
    {
        Console.WriteLine($"Debug(string parameter); {parameter}");
        Console.WriteLine("<Press Any Key>");
        Console.ReadKey();
    }

    public static void Debug(int parameter)
    {
        Console.WriteLine($"Debug(int parameter); {parameter}");
        Console.WriteLine("<Press Any Key>");
        Console.ReadKey();
    }

//methods******************************************************
 


}