using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        RunWelcome();
        List<string> allGoals = new List<string>();
        Console.WriteLine("Hello Develop05 World!");
        User newUser = new User();
        newUser.Login();
        string userName = newUser.GetUser();
        RunProgram(userName, allGoals, newUser);
    }

    static void RunProgram(string userName, List<string> allGoals, User newUser)
    {
        while (true)
        {
            Menu_Main mainMenu = new Menu_Main();
            mainMenu.AutoLoad(allGoals, userName, newUser);
            mainMenu.Display(userName, allGoals, newUser);
            Console.Clear();
        }
    }

     static public void RunWelcome()
            {
                string[] welcomeScreenStrings = {"Welcome","to","your","Eternal","Goals"};
                string[] welcomeScreenStringsContinued = {"Tracker!","!","!","!","!", "!"};
                WelcomeAnimation welcomeScreen = new WelcomeAnimation(350, 25, 1, welcomeScreenStrings, welcomeScreenStringsContinued);
                //welcomeScreen.Animate();
            }
}
