using System;
using System.Reflection.Metadata.Ecma335;

public class Menu_Goals
{
    private int userInput = 0;
    private string menuOutput = "";
    private bool validInput = false;
    private bool intInRange = false;

    public string Display()
    {
        DisplayMenu(); // Display the menu options
        userInput = InputHandler();

        // Process user input
        switch (userInput)
        {
            case 1:
                menuOutput = "Simple Goal Created";
                break;                
            case 2:
                menuOutput = "Eternal Goal Created";
                break;                
            case 3:
                menuOutput = "Checklist Goal Created";
                break;                
        }
        return menuOutput;
    }

    private void DisplayMenu()
        {
            Console.WriteLine("The types of goals are:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.Write("Which type of goal would you like to create? ");
        }

    public string GetMenuSelection() 
        {
            return menuOutput;
        }
    
    private int InputHandler()
        {
            do
                {
                    Console.Clear(); // Clears the console for a fresher look.
                    DisplayMenu(); // Display the menu options
                    // Attempt to read and parse user input
                    string inputString = Console.ReadLine();
                    validInput = int.TryParse(inputString, out userInput);
                    if (!validInput)
                        {
                            Console.CursorVisible = false; // Makes console appearance cleaner.
                            Console.Clear(); // Clears the console for a fresher look.
                            Console.WriteLine("The input is not an integer. Please enter a valid integer between 1 and 6.");
                            Console.WriteLine("<Press Any Key>");
                            Console.ReadKey();
                            continue; // Restart the loop to prompt for input again
                        }
                    // Check if input is in range
                    if (userInput < 1 || userInput > 3)
                        {
                            Console.CursorVisible = false; // Makes console appearance cleaner.
                            Console.Clear(); // Clears the console for a fresher look.
                            Console.WriteLine("The input integer is out of range. Please select an integer between 1 and 6.");
                            Console.WriteLine("<Press Any Key>");
                            Console.ReadKey();
                            continue; // Restart the loop to prompt for input again
                        }
                    intInRange = true; // Set flag to exit the loop
                } while (!intInRange);
            return userInput; // Return valid user input
        }
}