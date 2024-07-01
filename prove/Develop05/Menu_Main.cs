using System;
using System.Collections.Generic;

public class Menu_Main
{
    private readonly List<string> menuOptions = new List<string>
    {
        "Create New Goal",
        "List Goals",
        "Save Goals ***This feature is disabled because 'Auto Save' is ON.",
        "Load Goals ***This feature is disabled because 'Auto Load' is ON.",
        "Record Event",
        "Quit"
    };

    public void Display(string userName, List<string> allGoals, User newUser)
    {
        while (true)
        {
            Console.Clear();
            DisplayMenu(userName, newUser);
            int userInput = InputHandler();
            if (MenuFunctions(userInput, userName, allGoals, newUser)) break;
        }
    }

    private void DisplayMenu(string userName, User newUser)
    {
        Console.Clear();
        Console.WriteLine($"{userName}, your score is: {newUser.GetScore():N0}.\n");
        Console.WriteLine("MenuCommand Option:");
        for (int i = 0; i < menuOptions.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {menuOptions[i]}");
        }
        Console.Write("Please select a choice from the menu: ");
    }

    private int InputHandler()
    {
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int userInput) && userInput >= 1 && userInput <= menuOptions.Count)
                return userInput;

            InvalidInputMessage();
        }
    }

    private void InvalidInputMessage()
    {
        Console.Clear();
        Console.WriteLine("Invalid input. Please enter an integer between 1 and 6.");
        Console.WriteLine("<Press Any Key>");
        Console.ReadKey();
    }

    private bool MenuFunctions(int userInput, string userName, List<string> allGoals, User newUser)
    {
        switch (userInput)
        {
            case 1:
                new Menu_Goals().Display(userName, allGoals);
                break;
            case 2:
                ListGoals(allGoals, newUser);
                break;
            case 5:
                Console.WriteLine("Recorded an Event");
                PressAnyKey();
                break;
            case 6:
                Save(allGoals);
                allGoals.Clear();
                Environment.Exit(0);
                //GoodByeAnimation(350, 100, 1)
                return true;
        }
        return false;
    }

    private void ListGoals(List<string> allGoals, User newUser)
    {
        Console.Clear();
        Console.WriteLine("The goals are: ");
        int i = 0;
        foreach (string myListOfGoals in allGoals)
        {
            Goal goal = new Goal();
            Console.WriteLine($"{i + 1}. {goal.Deserialize(myListOfGoals, newUser)}");
            i++;
        }
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

    public void AutoLoad(List<string> allGoals, string userName, User newUser) => Load(allGoals, userName, newUser);

    private void Save(List<string> allGoals)
    {
        Console.Clear();
        Goal savingGoals = new Goal();
        savingGoals.Save(allGoals);
        PressAnyKey();
    }

    private void Load(List<string> allGoals, string userName, User newUser)
    {
        Console.Clear();
        allGoals.Clear();
        Goal loadingGoals = new Goal();
        loadingGoals.Load(allGoals, userName, newUser);
        PressAnyKey();
    }
}
