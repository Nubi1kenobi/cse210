using System;
using System.Reflection;

class Program
{


    static void Main(string[] args)
    {
        int delay = 1000;
        int fade = 50;
        int count = 500;
        string[] arrayOfStrings = {"\\", "|", "/", "-"};
        Console.WriteLine("Hello Sandbox World!");
        Animation countDown = new Animation(delay, fade, count, arrayOfStrings);
        Console.Clear();
        countDown.Animate();

    }
}