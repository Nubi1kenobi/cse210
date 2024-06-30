using System;

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

        public void Display(string userName, List<string> allGoals, User newUser)
            {
                string _userName = userName;  
                while (true)
                    {
                        Console.Clear();
                        DisplayMenu(_userName, newUser);
                        int userInput = InputHandler(_userName, newUser);
                        if (MenuFunctions(userInput, _userName, allGoals, newUser));
                            break;
                    }
            }

        private void DisplayMenu(string username, User newUser)
            {
                string _userName = username;
                Console.Clear();
                Console.WriteLine($"Your current score is: {newUser.GetScore()}.");
                Console.WriteLine("MenuCommand Option:");
                for (int i = 0; i < menuOptions.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {menuOptions[i]}");
                    }
                Console.Write($"{_userName}, please select a choice from the menu: ");
            }

        private int InputHandler(string userName, User newUser)
            {
                string _username = userName;  
                while (true)
                    {
                        if (int.TryParse(Console.ReadLine(), out int userInput) && userInput >= 1 && userInput <= menuOptions.Count)
                            return userInput;
                        InvalidInputMessage();
                        DisplayMenu(_username, newUser);
                    }
            }

        private void InvalidInputMessage()
            {
                Console.Clear();
                Console.WriteLine($"Invalid input. Please enter an integer between 1 and {menuOptions.Count}.");
                Console.WriteLine("<Press Any Key>");
                Console.ReadKey();
            }

        private bool MenuFunctions(int userInput, string userName, List<string> allGoals, User newUser)
            {
                string _userName = userName;
                switch (userInput)
                    {
                        case 1:
                            Console.Clear();
                            Menu_Goals goalsMenu = new Menu_Goals();
                            goalsMenu.Display(userName, allGoals);
                            break;
                        case 2:
                            Console.Clear();    //above and beyond, makes it cleaner.
                            Console.WriteLine("The goals are: ");
                            int i = 0;
                            foreach (string myListOfGoals in allGoals)
                            {
                                Goal goal = new Goal();
                                Console.WriteLine($"{i + 1}. {goal.Deserialize(myListOfGoals, newUser)}");
                                i++;
                            }
                            PressAnyKey();
                            break;
                        case 3:
                            Console.Clear();
                            Goal savingGoals = new Goal();
                            savingGoals.Save(allGoals);
                            PressAnyKey();
                            break;
                        case 4:
                            Console.Clear();
                            allGoals.Clear();
                            Goal loadingGoals = new Goal();
                            loadingGoals.Load(allGoals, userName, newUser);

                            PressAnyKey();
                            break;
                        case 5:
                            Console.Clear();
                            DebugUtility.Debug("Recorded an Event");
                            PressAnyKey();
                            break;
                        case 6:
                            GoodByeAnimation goodBye = new GoodByeAnimation(350, 100, 1, goodByeStuff);
                            goodBye.Animate();
                            return true;
                    }
                return false;
            }
        private void PressAnyKey()
        {
            Console.CursorVisible = false;  //above and beyond, makes it cleaner.
            Console.WriteLine("<Press Any Key>");   //above and beyond, makes it cleaner.
            Console.ReadKey();
            Console.Clear();    //above and beyond, makes it cleaner.
            Console.CursorVisible = true;  //above and beyond, makes it cleaner.
        }
}
