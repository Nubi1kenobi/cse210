using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        RunWelcome();
        Console.WriteLine("Hello Develop05 World!");
        User newUser = new User();
        newUser.Login(newUser);
        newUser.Load(newUser);
        RunProgram(newUser);
    }

    static void RunProgram(User newUser)
    {
        while (true)
        {
            Menu_Main mainMenu = new Menu_Main();
            //mainMenu.AutoLoad(newUser);
            mainMenu.Display(newUser);
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
