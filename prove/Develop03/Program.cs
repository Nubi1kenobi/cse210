using System;

class Program
{
    static void Main(string[] args)
        {
            bool inputValidation = false;
            
            string userInput = "";
            string mainScripture = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";       
            //string mainReference = "Proverbs 3:5-6";
            Reference newReference = new Reference("Proverbs", "3", "5", "6");
            Scripture newScripture = new Scripture(mainScripture);
               

            //do
            foreach ( )
                {
                    Console.Clear();
                    
                    Console.WriteLine($"{newReference.GetReference()} {newScripture.GetScripture()}\n\nPress enter to continue or type 'quit' to finish:");
                    newScripture.CountArray();
                    userInput = Console.ReadLine();
                    inputValidation = handleInput(userInput);
                    if (inputValidation == true) { break; }


                    //DebugUtility.Debug();

                }
            //while (!inputValidation);
        }

        static bool handleInput(string userInput)
            {
                string _userInput = userInput;
                if (_userInput == "quit") { return true; }
                return false;
            }
}