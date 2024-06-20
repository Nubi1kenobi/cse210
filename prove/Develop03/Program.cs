using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
        {
            bool inputValidation1 = false;
            bool inputValidation2 = false;
            string userInput2 = "";
            do
                {
                    //string mainScripture = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";       
                    string mainScripture = "In all thy ways acknowledge him, and he shall direct thy paths.";       
                    Reference newReference = new Reference("Proverbs", "3", "5", "6");   
                    Scripture newScripture = new Scripture(mainScripture);
                    int loopCount = newScripture.GetWordCount();   
                    Thread.Sleep(250); //0.25s delay
                    Console.Clear();
                    Console.WriteLine($"{newReference.GetReference()} {newScripture.GetScripture()}\n\nPress enter to continue or type 'quit' to finish:");
                        do
                            {
                                loopCount--;                    
                                userInput1 = Console.ReadLine();
                                inputValidation1 = handleInput1(userInput1);
                                if (inputValidation1 == true || loopCount < 0) { break; }
                                Thread.Sleep(250); //0.25s delay
                                //Console.Clear();
                                Console.WriteLine($"{newReference.GetReference()} {newScripture.GetUpdatedScripture()}\n\nPress enter to continue or type 'quit' to finish:");
                                DebugUtility.Debug(inputValidation1);
                            }   while (!inputValidation1);
                            DebugUtility.Debug();
                    Console.WriteLine("Would you like to try again? 'y' for yes.> ");
                    userInput2 = Console.ReadLine();
                    inputValidation1 = handleInput2(userInput2);
                } while (!inputValidation2);

                static bool handleInput1(string userInput)
                        {
                            string _userInput = userInput;
                            if (_userInput == "quit") { Quit(); }
                            return false;
                        }
                    
                static bool handleInput2(string userInput)
                    {
                        string _userInput2 = userInput;
                        if (_userInput2 != "y") { return false; }
                        else { Quit(); }
                        return false;
                    }

                static void Quit()
                    {
                        Console.Clear();
                        Console.WriteLine("Goodbye, Au revoir, Auf Wiedersehen, Yasou, L'hitraot, Namaste, Viszlát!, Vertu Saeill!, Atsiprasau, Zài jiàn, Namaste, Ha det bra, Khodaa haafez, Żegnaj, Adeus , Adiós, Chao, Dasvidaniya, Poka, Bài bài, Zàijiàn, Arrivederci, Ciao, Sayonara, Ja nee, Farvel, Kwaheri, Baadaye");
                        for (int i = 0; i < 10; i++)
                            {
                                Console.WriteLine("");
                            }
                        System.Environment.Exit(0);
                    }
            }
}


