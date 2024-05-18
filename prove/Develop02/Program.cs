using System;

    class Program
    {
        static void Main(string[] args)
        {
            //variable declarations and initializations
            int userInput;
            
            
            Console.Clear();    //clears the console for a fresher look.
            Console.WriteLine("Hello Develop02 World!");
            
        
            do
                {
                    Menu.MainMenu();    //displays the main menu.
                    userInput = Menu.MenuUserInput();   //this is the main menu, menu prompt /w error checking.
                    Menu.MenuSelect(userInput); //this method launches the desired methods.
                    if (userInput < 0 || userInput > 5)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("ERROR 0001 - INVALID INPUT: Please select an integer between 1 and 5.");
                            Console.WriteLine("");
                        }
                }   while (userInput != 5);  // this loop keeps the main menu looping until the user decides they are finished
            
            //exiting the program when the menu loop ends
            Console.WriteLine("Have a nice day, goodby.");
            System.Environment.Exit(0);
        
        }        
       
       
       
    }