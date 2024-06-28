using System;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

class Program
{


    static void Main(string[] args)
    {
        int delay = 100;
        int fade = 10;
        int count = 10;
        string[] arrayOfStrings = {"\\", "|", "/", "-"};
        Console.WriteLine("Hello Sandbox World!");
        Animation countDown = new Animation(delay, fade, count, arrayOfStrings);
        // countDown.Animate();
        ProgramRun();        
    }
    static public void ProgramRun()
        {
            do
                {
                    Console.Clear();
                    MainMenu mainMenu = new MainMenu();       
                    mainMenu.Display();
                    Console.Clear();
                    Console.WriteLine(mainMenu.GetMenuSelection());
                    Console.ReadKey();
                } while (true);
        }

}