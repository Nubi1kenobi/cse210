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
            int loopCount = newScripture.GetWordCount();   

            do
                {
                    loopCount--;
                    Thread.Sleep(250); //0.25s delay
                    Console.Clear();
                    Console.WriteLine($"{newReference.GetReference()} {newScripture.GetScripture()}\n\nPress enter to continue or type 'quit' to finish:");
                    //Console.WriteLine($"{newReference.GetReference()} {newScripture.GetScripture()}\n\nPress enter to continue or type 'quit' to finish:");
                    userInput = Console.ReadLine();
                    inputValidation = handleInput(userInput);
                    if (inputValidation == true || loopCount < 0) { break; }
                    newScripture = new Scripture(mainScripture);

                    //DebugUtility.Debug();

                }
            while (!inputValidation);
            Console.Clear();
            Console.WriteLine("Goodbye, Au revoir, Auf Wiedersehen, Yasou, L'hitraot, Namaste, Viszlát!, Vertu Saeill!, Atsiprasau, Zài jiàn, Namaste, Ha det bra, Khodaa haafez, Żegnaj, Adeus , Adiós, Chao, Dasvidaniya, Poka, Bài bài, Zàijiàn, Arrivederci, Ciao, Sayonara, Ja nee, Farvel, Kwaheri, Baadaye");
            for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("");
                }
        }

        static bool handleInput(string userInput)
            {
                string _userInput = userInput;
                if (_userInput == "quit") { return true; }
                return false;
            }
}