using System;

class Program
    {       
        static void Main(string[] args)
            {
                List<string> allGoals = new List<string>();
                Console.WriteLine("Hello Develop05 World!");   
                //RunWelcome();
                string userName = Login();
                RunProgram(userName, allGoals);        
            }
        
        static public void RunProgram(string userName, List<string> allGoals)
            {
                string _userName = userName;
                while (true)
                    {   
                        Menu_Main mainMenu = new Menu_Main();
                        mainMenu.Display(_userName, allGoals);
                        Console.Clear();
                    }
            }
        
        static public string Login()
            {
                

                while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("Welcome to your Eternal Goals!!!!!");
                        Console.Write("Please Enter your username: ");
                        string userName = Console.ReadLine();
                        if (InputHandler(userName))
                            {
                                return userName;
                            }
                        InvalidInputMessage(userName);
                    }
            }  
        
        static public void RunWelcome()
            {
                string[] welcomeScreenStrings = {"Welcome","to","your","Eternal","Goals"};
                string[] welcomeScreenStringsContinued = {"Tracker!","!","!","!","!", "!"};
                WelcomeAnimation welcomeScreen = new WelcomeAnimation(350, 25, 1, welcomeScreenStrings, welcomeScreenStringsContinued);
                welcomeScreen.Animate();
            }
        
        static private bool InputHandler(string userName)
            {
                return !string.IsNullOrWhiteSpace(userName) && userName.Length >= 3 && userName.Length <= 16;
            }
        
        static private void InvalidInputMessage(string userName)
            {
                Console.CursorVisible = false;
                Console.Clear();
                Console.WriteLine($"{userName} is an invalid Username. It must be between 3 and 16 characters long.");
                Console.WriteLine("<Press Any Key>");
                Console.ReadKey();
                Console.CursorVisible = true;
            }
        
        

}