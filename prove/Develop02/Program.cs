using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

class Program
        {
            static void Main(string[] args)
            {
                // variable declarations and initializations for static void Main(string[] args)
                // beginning of static void Main(string[] args) programming *****************************************************************
                Console.Clear();    //clears the console for a fresher look.
                Console.WriteLine("Hello Develop02 World!");
                int userInput = 0;
                bool validInput = false;
                bool intInRange = false;
                Journal newJournal = new Journal();
                //Entry newEntry = new Entry();
                do //infinite menu loop until program manually ends with a "System.Environment.Exit(0);"
                {
                    do //loop with error checking
                    {
                        do  //more error checking
                        {
                            Console.CursorVisible = true;   //Above and beyond, makes it appear cleaner. Brings the curser back.
                            Console.Clear();
                            Console.WriteLine("Please select one of the following choices:");
                            Console.WriteLine("1. Write");
                            Console.WriteLine("2. Display");
                            Console.WriteLine("3. Load");
                            Console.WriteLine("4. Save");
                            Console.WriteLine("5. Quit");
                            Console.Write("What would you like to do? ");
                            validInput = int.TryParse(Console.ReadLine(), out userInput);
                            if (!validInput)
                                {
                                    Console.CursorVisible = false;  //Above and beyond, makes it appear cleaner.
                                    Console.Clear();    //Above and beyond, makes it appear cleaner.
                                    Console.WriteLine("The input is not an integer. Please select an integer input between 1 and 5.");
                                    Console.WriteLine("<Press Any Key>");
                                    Console.ReadKey();
                                }
                            } while (!validInput);
                    
                        if (userInput < 1 || userInput > 5)
                            {
                                Console.CursorVisible = false;  //Above and beyond, makes it appear cleaner.
                                Console.Clear();    //Above and beyond, makes it appear cleaner.
                                Console.WriteLine("The input integer is out of range. Please select an integer between 1 and 5.");
                                Console.WriteLine("<Press Any Key>");
                                Console.ReadKey();
                            } 
                        
                        else{
                            intInRange = true;
                        }
                       } while (!intInRange);

            switch (userInput)
            {
                case 1:
                    newJournal.Write();
                    break;
                case 2:
                    newJournal.Display();
                    break;
                case 3:
                    newJournal.Load();
                    break;
                case 4:
                    newJournal.Save();
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("Goodbye!");
                    System.Environment.Exit(0);
                    break;
            }
        } while (true);
    }
}