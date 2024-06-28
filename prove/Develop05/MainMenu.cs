 using System;
 public class MainMenu
    {
        {
            private int userInput = 0;
    private string mainMenuOutput = "";
    private bool validInput = false;
    private bool intInRange = false;
            Console.Clear();    //clears the console for a fresher look.
            do //infinite menu loop until program manually ends with a "System.Environment.Exit(0);"
                {
                    Console.Clear();    //clears the console for a fresher look.
                    do //loop with error checking
                        {
                            Console.Clear();    //clears the console for a fresher look.
                            do  //more error checking
                                {
                                    Console.WriteLine("MenuCommand Option:");
                                    Console.WriteLine("1. Create New Goal");
                                    Console.WriteLine("2. List Goals");
                                    Console.WriteLine("3. Save Goals");
                                    Console.WriteLine("4. Load Goals");
                                    Console.WriteLine("5. Record Event");
                                    Console.WriteLine("6. Quit");
                                    Console.Write("Select a choice from the menu: ");
                                    validInput = int.private TryParse(Console.ReadLine(), out userInput);
                                    if (!validInput)
                                        {
                                            Console.CursorVisible = false;  //Above and beyond, makes it appear cleaner.
                                            Console.Clear();    //Above and beyond, makes it appear cleaner.
                                            Console.WriteLine("The input is not an integer. Please select an integer input between 1 and 5.");
                                            Console.WriteLine("<Press Any Key>");
                                            Console.ReadKey();
                                        }
                                } while (!validInput);

                                    if (userInput < 1 || userInput > 5)
                                        {
                                            Console.CursorVisible = false;  //Above and beyond, makes it appear cleaner.
                                            Console.Clear();    //Above and beyond, makes it appear cleaner.
                                            Console.WriteLine("The input integer is out of range. Please select an integer between 1 and 5.");
                                            Console.WriteLine("<Press Any Key>");
                                            Console.ReadKey();
                                    } 
                            
                                    else    {
                                                intInRange = true;
                                            }
                        } while (!intInRange);

                        switch (userInput)
                            {
                                case 1:
                                mainMenuOutput = "Create New Goal Menu";
                                DebugUtility.Debug();
                                return mainMenuOutput;
                                
                                case 2:
                                Console.WriteLine("");
                                DebugUtility.Debug();
                                return mainMenuOutput;
                                
                                case 3:
                                Console.WriteLine("");
                                DebugUtility.Debug();
                                return mainMenuOutput;

                                case 4:
                                Console.WriteLine("");
                                DebugUtility.Debug();
                                return mainMenuOutput;

                                case 5:
                                Console.Clear();
                                Console.WriteLine("Goodbye, Au revoir, Auf Wiedersehen, Yasou, L'hitraot, Namaste, Viszlát!, Vertu Saeill!, Atsiprasau, Zài jiàn, Namaste, Ha det bra, Khodaa haafez, Żegnaj, Adeus , Adiós, Chao, Dasvidaniya, Poka, Bài bài, Zàijiàn, Arrivederci, Ciao, Sayonara, Ja nee, Farvel, Kwaheri, Baadaye");
                                System.Environment.Exit(0);
                                return "";
                            }
                } while (true);
        }
    }