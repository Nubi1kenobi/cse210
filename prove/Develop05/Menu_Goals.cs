using System;
using System.Collections.Generic;

public class Menu_Goals
{
    private readonly List<string> menuOptions = new List<string>
    {
        "Simple Goal",
        "Eternal Goal",
        "Checklist Goal",
    };

    public void Display(User newUser)
    {
        while (true)
        {
            DisplayMenu(newUser);
            int userInput = InputHandler(newUser);
            if (MenuFunctions(userInput, newUser)) break;
        }
    }

    private void DisplayMenu(User newUser)
    {
        Console.Clear();
        Console.WriteLine("The types of goals are:");
        for (int i = 0; i < menuOptions.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {menuOptions[i]}");
        }
        Console.Write($"{newUser.GetUser()}, which type of goal would you like to create? ");
    }

    private int InputHandler(User newUser)
    {
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int userInput) && userInput >= 1 && userInput <= menuOptions.Count)
            return userInput;
            InvalidInputMessage();
            DisplayMenu(newUser);
        }
    }

    private void InvalidInputMessage()
    {
        Console.Clear();
        Console.WriteLine($"Invalid input. Please enter an integer between 1 and {menuOptions.Count}.");
        PressAnyKey();
    }

    private bool MenuFunctions(int userInput, User newUser)
    {
        switch (userInput)
        {
            case 1:
                CreateGoal(newUser.GetUser(), newUser.GetUserGoals());
                break;
            case 2:
                DebugUtility.Debug("Eternal Goal Created");
                PressAnyKey();
                break;
            case 3:
                DebugUtility.Debug("Checklist Goal Created");
                PressAnyKey();
                break;
            default:
                return false; // Return false to indicate not quitting to Menu_Main
        }
        return true; // Return true to indicate returning to Menu_Main
    }

    private void CreateGoal(string userName, List<string> allGoals)
    {
        Goal simpleGoal = new Goal();
        simpleGoal.SetGoal(userName);
        allGoals.Add(simpleGoal.GetGoal());
        PressAnyKey();
    }

    private void PressAnyKey()
    {
        Console.CursorVisible = false;
        Console.WriteLine("<Press Any Key>");
        Console.ReadKey();
        Console.Clear();
        Console.CursorVisible = true;
    }
}
