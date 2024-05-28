using System;
using System.Diagnostics;

/// <summary>
/// note for later - this is not a true object yet. I want to use this as a similar idea behind the journal program to create
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
            // variable declarations and initializations
            bool _validInput = false;
            int _menuSelect;  

            //error checking loop
                // this behaves differently if a non-integer is enetered from entering something out of range (<> a number). 
                // To correct this to get an out of range interger to behave similarly to a string, add a do while loop in the 
                // main program for the out of range config.
                
            do  // This loop provides the non-integer part of the error checking. This is an attempt to exceed the core requirements.
                {
                    _validInput = int.TryParse(Console.ReadLine(), out _menuSelect);
                    if (!_validInput) 
                        {
                            Console.Clear();    // Above and beyond, makes it appear cleaner.
                            Console.WriteLine("");
                            Console.WriteLine("ERROR 0002 - INVALID INPUT: Please select a number between 1 and 5, in Menu.MenuUserInput()");
                            Console.WriteLine("");
                            MainMenu();
                        }
                }   while (!_validInput);
            return _menuSelect;
        }
        
    public static void MenuSelect(int userInput, Journal newJournal)       
        {
            // variable declarations and initializations
            int _menuSelect = userInput;
            Entry newEntry = new Entry(); 
            if (_menuSelect == 1)
                {
                    //Entry newEntry = new Entry();   
                    Console.Clear();    // Above and beyond, makes it appear cleaner.
                    newEntry.Write();
                    newJournal._journalEntry.Add(newEntry);
                    //Console.Clear();    // Above and beyond, makes it appear cleaner.
                }

            else if (_menuSelect == 2)
                {
                    Console.Clear();    // Above and beyond, makes it appear cleaner.
                    newJournal.Display();
                    Console.ReadKey();    // Above and beyond, makes it appear cleaner.
                    Console.Clear();    // Above and beyond, makes it appear cleaner.
                }

            else if (_menuSelect == 3)
                {
                    Console.Clear();    // Above and beyond, makes it appear cleaner.
                    newJournal.Load();
                    Console.Clear();    // Above and beyond, makes it appear cleaner.
                }

            else if (_menuSelect == 4)
                {
                    Console.Clear();    // Above and beyond, makes it appear cleaner.
                    //newJournal.Save(newJournal, newEntry);
                    Console.Clear();    // Above and beyond, makes it appear cleaner.
                }
        }
}
