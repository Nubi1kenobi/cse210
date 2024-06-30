using System;
using System.Diagnostics;

class Program
    {       
        static void Main(string[] args)
            {
                List<string> allGoals = new List<string>();
                Console.WriteLine("Hello Develop05 World!");   
                //RunWelcome();
                User newUser = new User();
                newUser.Login();
                string userName = newUser.GetUser();
                RunProgram(userName, allGoals, newUser);        
            }
        
        static public void RunProgram(string userName, List<string> allGoals, User newUser)
            {
                string _userName = userName;
                while (true)
                    {   
                        Menu_Main mainMenu = new Menu_Main();
                        mainMenu.Display(_userName, allGoals);
                        Console.Clear();
                    }
            }
                  
        
        static public void RunWelcome()
            {
                string[] welcomeScreenStrings = {"Welcome","to","your","Eternal","Goals"};
                string[] welcomeScreenStringsContinued = {"Tracker!","!","!","!","!", "!"};
                WelcomeAnimation welcomeScreen = new WelcomeAnimation(350, 25, 1, welcomeScreenStrings, welcomeScreenStringsContinued);
                welcomeScreen.Animate();
            }
        
        
        
        

}