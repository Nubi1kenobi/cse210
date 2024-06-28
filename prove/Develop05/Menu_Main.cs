using System;
using System.Collections.Generic;

public class Menu_Main
    {
        private List<string> menuOptions = new List<string>
            {
                "Create New Goal",
                "List Goals",
                "Save Goals",
                "Load Goals",
                "Record Event",
                "Quit"
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
                Console.WriteLine("MenuCommand Option:");
                for (int i = 0; i < menuOptions.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {menuOptions[i]}");
                    }
                Console.Write("Select a choice from the menu: ");
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
                            Menu_Goals goalsMenu = new Menu_Goals();
                            goalsMenu.Display();
                            break;
                        case 2:
                            Console.Clear();
                            DebugUtility.Debug("Listed Goals");
                            break;
                        case 3:
                            Console.Clear();
                            DebugUtility.Debug("Saved Goals");
                            break;
                        case 4:
                            Console.Clear();
                            DebugUtility.Debug("Loaded Goals");
                            break;
                        case 5:
                            Console.Clear();
                            DebugUtility.Debug("Recorded an Event");
                            break;
                        case 6:
                            Console.Clear();
                            Console.WriteLine("Goodbye, Au revoir, Auf Wiedersehen, Yasou, L'hitraot, Namaste, Viszlát!, Vertu Saeill!, Atsiprasau, Zài jiàn, Namaste, Ha det bra, Khodaa haafez, Żegnaj, Adeus , Adiós, Chao, Dasvidaniya, Poka, Bài bài, Zàijiàn, Arrivederci, Ciao, Sayonara, Ja nee, Farvel, Kwaheri, Baadaye");
                            Environment.Exit(0);
                            return true;
                    }
                return false;
            }
}
