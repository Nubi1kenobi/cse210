using System;
using System.Collections.Generic;

public class Menu_Goals
    {
        private List<string> menuOptions = new List<string>
            {
                "Simple Goal",
                "Eternal Goal",
                "Checklist Goal",
            };

        public void Display()
            {
                while (true)
                    {
                        DisplayMenu();
                        int userInput = InputHandler();
                        if (MenuFunctions(userInput))
                            break;
                    }
            }

        private void DisplayMenu()
            {
                Console.Clear();
                Console.WriteLine("The types of goals are:");
                for (int i = 0; i < menuOptions.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {menuOptions[i]}");
                    }
                Console.Write("Which type of goal would you like to create? ");
            }

        private int InputHandler()
            {
                while (true)
                    {
                        if (int.TryParse(Console.ReadLine(), out int userInput) && userInput >= 1 && userInput <= menuOptions.Count)
                            return userInput;

                        InvalidInputMessage();
                        DisplayMenu();
                    }
            }

        private void InvalidInputMessage()
            {
                Console.Clear();
                Console.WriteLine($"Invalid input. Please enter an integer between 1 and {menuOptions.Count}.");
                Console.WriteLine("<Press Any Key>");
                Console.ReadKey();
            }

        private bool MenuFunctions(int userInput)
            {
                switch (userInput)
                    {
                        case 1:
                            Console.Clear();
                            DebugUtility.Debug("Simple Goal Created");
                            break;                
                        case 2:
                            Console.Clear();
                            DebugUtility.Debug("Eternal Goal Created");
                            break;                
                        case 3:
                            Console.Clear();
                            DebugUtility.Debug("Checklist Goal Created");
                            break;
                        default:
                            return false; // Return false to indicate not quitting to Menu_Main
                    }
                return true; // Return true to indicate returning to Menu_Main
            }
    }
