using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class Menu_Main
    {
        private string[] goodByeStuff = {"Goodbye, ", "Au revoir, ", "Auf Wiedersehen, ", "Yasou, ", "L'hitraot,\n", "Namaste, ", "Viszlát!, ", "Vertu Saeill!, ", "Atsiprasau, ", "Zài jiàn,\n", "Ha det bra, ", "Khodaa haafez, ", "Żegnaj, ", "Adeus, ", "Adiós, ", "Chao,\n", "Dasvidaniya, ", "Poka, ", "Bài bài, ", "Zàijiàn, ", "Arrivederci, ", "Ciao,\n", "Sayonara, ", "Ja nee, ", "Farvel, ", "Kwaheri, ", "Baadaye\n\n"};
        private List<string> menuOptions = new List<string>
            {
                "Create New Goal",
                "List Goals",
                "Save Goals",
                "Load Goals",
                "Record Event",
                "Quit"
            };

        public void Display(string userName)
            {
                string _userName = userName;  
                while (true)
                    {
                        Console.Clear();
                        DisplayMenu(_userName);
                        int userInput = InputHandler(_userName);
                        if (MenuFunctions(userInput, _userName))
                            break;
                    }
            }

        private void DisplayMenu(string username)
            {
                string _userName = username;
                Console.Clear();
                Console.WriteLine("MenuCommand Option:");
                for (int i = 0; i < menuOptions.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {menuOptions[i]}");
                    }
                Console.Write($"{_userName}, please select a choice from the menu: ");
            }

        private int InputHandler(string userName)
            {
                string _username = userName;  
                while (true)
                    {
                        if (int.TryParse(Console.ReadLine(), out int userInput) && userInput >= 1 && userInput <= menuOptions.Count)
                            return userInput;
                        InvalidInputMessage();
                        DisplayMenu(_username);
                    }
            }

        private void InvalidInputMessage()
            {
                Console.Clear();
                Console.WriteLine($"Invalid input. Please enter an integer between 1 and {menuOptions.Count}.");
                Console.WriteLine("<Press Any Key>");
                Console.ReadKey();
            }

        private bool MenuFunctions(int userInput, string userName)
            {
                string _userName = userName;
                switch (userInput)
                    {
                        case 1:
                            Console.Clear();
                            Menu_Goals goalsMenu = new Menu_Goals();
                            goalsMenu.Display(userName);
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
                            GoodByeAnimation goodBye = new GoodByeAnimation(350, 100, 1, goodByeStuff);
                            goodBye.Animate();
                            return true;
                    }
                return false;
            }
}
