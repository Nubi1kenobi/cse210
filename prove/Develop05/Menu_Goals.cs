using System;

public class Menu_Goals
{
    private List<string> menuOptions = new List<string>  
    {
        "Simple Goal",
        "Eternal Goal",
        "Checklist Goal",
    };

    public void Display(string userName, List<string> allGoals)
    {
        string _userName = userName;  
        while (true)
        {
            DisplayMenu(_userName);
            int userInput = InputHandler(_userName);
            if (MenuFunctions(userInput, _userName, allGoals))
                break;
        }
    }

    private void DisplayMenu(string userName)
    {
        string _username = userName;  
        Console.Clear();
        Console.WriteLine("The types of goals are:");
        for (int i = 0; i < menuOptions.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {menuOptions[i]}");
            }
        Console.Write($"{userName}, which type of goal would you like to create? ");
    }

    private int InputHandler(string userName)
    {
        string _userName = userName;  
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int userInput) && userInput >= 1 && userInput <= menuOptions.Count)
                return userInput;
            InvalidInputMessage();
            DisplayMenu(_userName);
        }
}

    private void InvalidInputMessage()
    {
        Console.Clear();
        Console.WriteLine($"Invalid input. Please enter an integer between 1 and {menuOptions.Count}.");
        PressAnyKey();
    }

    private bool MenuFunctions(int userInput, string userName, List<string> allGoals)
    {
        string _userName = userName;
        switch (userInput)
        {
            case 1:
            Console.Clear();
            Goal simpleGoal = new Goal();
            simpleGoal.SetGoal(_userName);
            string goal = simpleGoal.GetGoal();
            allGoals.Add(goal);
            PressAnyKey();
            break;  

            case 2:
            Console.Clear();
            DebugUtility.Debug("Eternal Goal Created");
            PressAnyKey();
            break;  
                            
            case 3:
            Console.Clear();
            DebugUtility.Debug("Checklist Goal Created");
            PressAnyKey();
            break;
            default:
                return false; // Return false to indicate not quitting to Menu_Main
        }
        return true; // Return true to indicate returning to Menu_Main
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
