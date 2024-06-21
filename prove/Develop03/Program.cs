using System;
using System.Security.Cryptography.X509Certificates;

class Program
    {
        static void Main(string[] args)
            {
                Start();
            }
                static void Start()
                    {
                        bool scriptureLoopInputValidation = false;
                        string userScriptureLoopInput = "";
                        int unHiddenWordsRemainging = 0;
                        string mainScripture = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";       
                        Reference newReference = new Reference("Proverbs", "3", "5", "6");   
                        Scripture newScripture = new Scripture(mainScripture);
                        int loopCount = newScripture.GetWordCount();   
                        Thread.Sleep(250); //0.25s delay
                        Console.Clear();
                        Console.WriteLine($"{newReference.GetReference()} {newScripture.GetScripture()}\n\nPress enter to continue or type 'quit' to finish:");
                        Console.WriteLine($"There are {newScripture.GetWordCount()} words in this scripture.");
                            do
                                {
                                    loopCount = newScripture.GetWordCount() - newScripture.GetFlaggedWordCount();
                                    //DebugUtility.Debug(loopCount);
                                    userScriptureLoopInput = Console.ReadLine();
                                    scriptureLoopInputValidation = handleScriptureLoopInput(userScriptureLoopInput);
                                    if (scriptureLoopInputValidation || loopCount < 1) { Quit(mainScripture); }
                                    Thread.Sleep(250); //0.25s delay
                                    Console.Clear();
                                    Console.WriteLine($"{newReference.GetReference()} {newScripture.GetUpdatedScripture()}\n\nPress enter to continue or type 'quit' to finish:");
                                    unHiddenWordsRemainging = newScripture.GetWordCount() - newScripture.GetFlaggedWordCount();
                                    Console.WriteLine($"There are {unHiddenWordsRemainging} unhidden word(s) remaining.");
                                    //DebugUtility.Debug(userScriptureLoopInput);                         
                                }   while (!scriptureLoopInputValidation );
                
                            bool handleScriptureLoopInput(string userInput)
                                {
                                    string _userInput = userInput;
                                    if (_userInput == "quit") { Quit(mainScripture); }
                                    return false;
                                }
                    }
                    
                static void Quit(string scripture)
                    {
                        Console.Clear();
                        Console.WriteLine("If you would like to try again, press 'y'. Press any other key and enter to quit.");
                        string _userInput2 = Console.ReadLine();
                        if (_userInput2 == "y") { Start(); }
                        else    {
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


