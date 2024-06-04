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
//New program - trying a different way.
                int userInput = 0;
                bool neverTrue = false;
                bool validInput = false;
                bool intInRange = false;
                Journal newJournal = new Journal();
                Entry newEntry = new Entry();
                do //infinite menu loop until program manually ends
                {
                    do //loop with error checking
                    {
                        do  //more error checking
                        {
                            Console.Clear();
                            Console.WriteLine("Please select on of the following choices:");
                            Console.WriteLine("1. Write");
                            Console.WriteLine("2. Display");
                            Console.WriteLine("3. Load");
                            Console.WriteLine("4. Save");
                            Console.WriteLine("5. Quit");
                            Console.Write("What would you like to do? ");
                            validInput = int.TryParse(Console.ReadLine(), out userInput);
                            if (!validInput)
                                {
                                    Console.WriteLine("The input is not an integer, please try again.");
                                    Console.WriteLine("<Press Any Key>");
                                    Console.ReadKey();
                                }
                            } while (!validInput);
                    
                        if (userInput < 1 || userInput > 5)
                            {
                                Console.WriteLine("Please select an integer input between 1 and 5.");
                                Console.WriteLine("<Press Any Key>");
                                Console.ReadKey();
                            } 
                        
                        else{
                            intInRange = true;
                        }
                    } while (!intInRange);
                    //Console.WriteLine("Error Checking is complete.");
                    //Console.WriteLine("<Press Any Key>");
                    //Console.ReadKey();  
                    if (userInput == 1)
                        {
                            newEntry.Write(newJournal, newEntry);
                        }

                else if (userInput == 2)
                    {
                        newJournal.Display();
                    }
                else if (userInput == 5)
                    {
                        Console.Clear();    // Above and beyond, makes it appear cleaner.
                        Console.WriteLine("Goodbye, Au revoir, Auf Wiedersehen, Yasou, L'hitraot, Namaste, Viszlát!, Vertu Saeill!, Atsiprasau, Zài jiàn, Namaste, Ha det bra, Khodaa haafez, Żegnaj, Adeus , Adiós, Chao, Dasvidaniya, Poka, Bài bài, Zàijiàn, Arrivederci, Ciao, Sayonara, Ja nee, Farvel, Kwaheri, Baadaye");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        System.Environment.Exit(0);
                    }
                } while (!neverTrue);

/* old program
                do  // this loop provides the Out of Range error checking on the integers. This is an attempt to exceed the core requirements.
                    {
                        Menu.MainMenu();    //displays the main menu.
                        userInput = Menu.MenuUserInput();   //this is the main menu, menu prompt /w error checking.
                        Menu.MenuSelect(userInput, newJournal); //this method launches the desired methods.
                        if (userInput < 1 || userInput > 5)
                            {
                                Console.Clear();    // Above and beyond, makes it appear cleaner.
                                Console.WriteLine("");
                                Console.WriteLine("ERROR 0001 - INVALID INPUT: Please select an integer between 1 and 5, in Main(string[] args)");
                                Console.WriteLine("");
                            }
                    }   while (userInput != 5);  // this loop keeps the main menu looping until the user decides they are finished
*/                
                //exiting the program when the menu loop ends

                // end of static void Main(string[] args) ***********************************************************************************
          
           
            } //end of Main()




        
        
        }