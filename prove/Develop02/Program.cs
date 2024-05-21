using System;

    class Program
        {
            static void Main(string[] args)
            {
                // variable declarations and initializations for static void Main(string[] args)
                int userInput;
                // beginning of static void Main(string[] args) programming *****************************************************************
                Console.Clear();    //clears the console for a fresher look.
                Console.WriteLine("Hello Develop02 World!");
                Journal newJournal = new Journal(); 
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
                
                //exiting the program when the menu loop ends
                Console.Clear();    // Above and beyond, makes it appear cleaner.
                Console.WriteLine("Goodbye, Au revoir, Auf Wiedersehen, Yasou, L'hitraot, Namaste, Viszlát!, Vertu Saeill!, Atsiprasau, Zài jiàn, Namaste, Ha det bra, Khodaa haafez, Żegnaj, Adeus , Adiós, Chao, Dasvidaniya, Poka, Bài bài, Zàijiàn, Arrivederci, Ciao, Sayonara, Ja nee, Farvel, Kwaheri, Baadaye");
                System.Environment.Exit(0);
                // end of static void Main(string[] args) ***********************************************************************************
            }        
        
        
        
        }