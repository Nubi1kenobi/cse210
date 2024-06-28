using System;
using System.Reflection.Metadata.Ecma335;

public class MainMenu
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
                menuOutput = "Create New Goal Menu";
                break;                
            case 2:
                menuOutput = "List Goals";
                break;                
            case 3:
                menuOutput = "Save Goals";
                break;                 
            case 4:
                menuOutput = "Load Goals";
                break;                
            case 5:
                menuOutput = "Record Event";
                break;
            case 6:
                Console.Clear();
                Console.WriteLine("Goodbye, Au revoir, Auf Wiedersehen, Yasou, L'hitraot, Namaste, Viszlát!, Vertu Saeill!, Atsiprasau, Zài jiàn, Namaste, Ha det bra, Khodaa haafez, Żegnaj, Adeus , Adiós, Chao, Dasvidaniya, Poka, Bài bài, Zàijiàn, Arrivederci, Ciao, Sayonara, Ja nee, Farvel, Kwaheri, Baadaye");
                Environment.Exit(0);
                break;
        }
        return menuOutput;
    }

    private void DisplayMenu()
        {
            Console.WriteLine("MenuCommand Option:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
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
                    if (userInput < 1 || userInput > 6)
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