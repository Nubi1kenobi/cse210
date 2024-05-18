using System;
/// <summary>
/// note for later - this is not a tru object yet. I want to use a similar idea behind the journal program to create
/// a real menu object I can use in any program - use deserialize like the journal. I just cannot spend anymore time on this 
/// part - will need to be in two parts, A - menu options and B - menu outputs.
/// </summary>
public class Menu
{
    public static void MainMenu()       
        {                                
            Console.WriteLine("Please select on of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
        }
    public static int MenuUserInput()
        { 
            //variable declarations and initializations
            bool _validInput = false;
            int _menuSelect;  

            //error checking loop
                // this behaves differently if a non-integer is enetered from entering something out of range (<> a number). 
                // To correct this to get an out of range interger to behave similarly to a string, add a do while loop in the 
                // main program for the out of range config.
            do 
                {
                    _validInput = int.TryParse(Console.ReadLine(), out _menuSelect);
                    if (!_validInput) 
                        {
                            Console.WriteLine("");
                            Console.WriteLine("ERROR 0001 - INVALID INPUT: Please select a number between 1 and 5.");
                            Console.WriteLine("");
                            MainMenu();
                        }
                }   while (!_validInput);
            return _menuSelect;
        }
        
    public static void MenuSelect(int userInput)       
        {
            //variable declarations and initializations
            int _menuSelect = userInput;


            if (_menuSelect == 1)
                {
                    Console.Clear();    //clears the console for a fresher look.
                    Console.WriteLine($"You selected : {_menuSelect}");
                }

            else if (_menuSelect == 2)
                {
                    Console.Clear();    //clears the console for a fresher look.
                    Console.WriteLine($"You selected : {_menuSelect}");
                }

            else if (_menuSelect == 3)
                {
                    Console.Clear();    //clears the console for a fresher look.
                    Console.WriteLine($"You selected : {_menuSelect}");
                }

            else if (_menuSelect == 4)
                {
                    Console.Clear();    //clears the console for a fresher look.
                    Console.WriteLine($"You selected : {_menuSelect}");
                }
        }
}
