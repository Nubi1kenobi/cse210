using System;
using System.Collections;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
public class Entry
    {

        public string _now = DateTime.Now.ToString("yyyy/MM/dd - HH:mm:ss");
        public string _userPrompt;
        public string _userEntry;

        public string Write()
        {
            _userPrompt = Prompts();
            Console.Write($"{_userPrompt}\n> ");
            _userEntry = Console.ReadLine();
            // string _userCombined = _userPrompt + _userEntry;
            Console.Clear();
            return _userEntry;    
        }

        public static string Prompts() 
            {
                string _userPrompt;
                var _randomizer = new Random();
                int _theRandomNumber = _randomizer.Next(1,6);
                
                if (_theRandomNumber == 1) 
                    {
                        _userPrompt = "Quick! What is the weather condition like right now?";
                    }
                else if (_theRandomNumber == 2) 
                    {
                        _userPrompt = "What thought has pre-occupyied your mind since your last entry?";
                    }
                else if (_theRandomNumber == 3) 
                    {
                        _userPrompt = "What are you planning for tomorrow?";
                    }
                else if (_theRandomNumber == 4) 
                    {
                        _userPrompt = "What was the last kind thing that you did?";
                    }
                else if (_theRandomNumber == 5) 
                    {
                        _userPrompt = "Tell me about one of your goals:";
                    }
                else
                    {
                        _userPrompt = $"ERROR 0002 - INVALID INT: The random number: {_theRandomNumber} is out of range, in Entry.Prompts()";  // Above and beyond, used to test Randomizer(), in case something come in out of range.
                    }
                return _userPrompt;
            }
            public string Serialize()
                {
                    return $"{_now}-|-{_userPrompt}-|-{_userEntry}";
                }
            public void Deserialize(string journalEntry)
                {
                    string[] segment = journalEntry.Split("-|-");
                    
                    if (journalEntry.Length < 4)
                        {
                            Console.WriteLine("ERROR 0004 - Missing line segments, in Entry.Deserialize.");
                        }
                    else
                        {
                            _now = segment[0];
                            _userPrompt = segment[1];    
                            _userEntry = segment[2];
                        }
                }
                public void Display()
                    {
                        Console.WriteLine($"DateTime: {_now} - Prompt: {_userPrompt}\n{_userEntry}");
                        Console.WriteLine("");
                        Console.WriteLine("<Press any key to return to the Main Menu.>");    //Above and beyond, makes it appear cleaner.
                    }



                
    }