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

    public void Display(User newUser)
    {
        while (true)
        {
            Console.Clear();
            DisplayMenu(newUser);
            int userInput = InputHandler();
            if (MenuFunctions(userInput, newUser)) break;
        }
    }

    private void DisplayMenu(User newUser)
    {
        Console.Clear();
        Console.WriteLine($"{newUser.GetUser()}, your score is: {newUser.GetScore():N0}.\n");
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

    private bool MenuFunctions(int userInput, User newUser)
    {
        switch (userInput)
        {
            case 1:
                new Menu_Goals().Display(newUser);
                break;
            case 2:
                ListGoals(newUser);
                break;
            case 5:
                Console.WriteLine("Recorded an Event");
                PressAnyKey();
                break;
            case 6:
                Save(newUser);
                Environment.Exit(0);
                //GoodByeAnimation(350, 100, 1)
                return true;
        }
        return false;
    }

    private void ListGoals(User newUser)
    {
        Console.Clear();
        Console.WriteLine("The goals are: ");
        int i = 0;
        foreach (string myListOfGoals in newUser.GetUserGoals())
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

    //public void AutoLoad(User newUser) => Load(newUser);

    private void Save(User newUser)
    {
        Console.Clear();
        newUser.Save();
        PressAnyKey();
    }

    private void Load()
    {
        Console.Clear();

        PressAnyKey();
    }
}
