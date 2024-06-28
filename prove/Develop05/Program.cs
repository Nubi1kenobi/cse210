using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Program
    {       
        static void Main(string[] args)
            {
                string userName = "";
                Console.WriteLine("Hello Develop05 World!");   
                RunWelcome();
                Login(userName);
                RunProgram(userName);        
            }
        
        static public void RunProgram(string userName)
            {
                string _userName = userName;
                while (true)
                    {   
                        Menu_Main mainMenu = new Menu_Main();
                        mainMenu.Display(_userName);
                        Console.Clear();
                    }
            }
        
        static public void Login(string userName)
            {
                string _userName = userName;
                bool acceptedUsername = false;
                while (!acceptedUsername)
                    {
                        Console.Clear();
                        Console.WriteLine("Welcome to your Eternal Goals!!!!!");
                        Console.Write("Please Enter your username: ");
                        userName = Console.ReadLine();
                        acceptedUsername = InputHandler(_userName); // Check if input is valid
                        if (!acceptedUsername)
                            {
                                InvalidInputMessage();
                            }
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
                string _userName = userName;
                if (!string.IsNullOrWhiteSpace(_userName) && _userName.Length >= 4 && _userName.Length <= 16)
                    {
                        return true;
                    }
                InvalidInputMessage();
                return false;
            }
        
        static private void InvalidInputMessage()
            {
                Console.CursorVisible = false;
                Console.Clear();
                Console.WriteLine("Invalid input. Please enter a string between 4 and 16 characters long.");
                Console.WriteLine("<Press Any Key>");
                Console.ReadKey();
                Console.CursorVisible = true;
            }
        
        

}