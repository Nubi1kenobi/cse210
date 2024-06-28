using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");
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