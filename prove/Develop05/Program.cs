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
                
                Console.Clear();
                do
                    {
                        Menu_Main mainMenu = new Menu_Main();
                        mainMenu.Display();
                        Console.Clear();
                    } while (true);
                
            }

}