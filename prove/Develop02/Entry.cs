using System;

public class Entry
    {

        public string _dateTime = DateTime.Now.ToString("yyyy/MM/dd - HH:mm:ss");    //my DateTime format is this way because this is the way I prefer to see it on everything. I chose this.
        public string _userPrompt;
        public string _userEntry;

        public string Write()
        {
            _userPrompt = Prompts();
            Console.Write($"{_userPrompt}\n> ");
            _userEntry = Console.ReadLine();
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
            
            /// <summary>
            /// serializes the data so that it can be stored and saved into a file.
            /// </summary>
            /// <returns></returns>
            public string Serialize()
                {
                    return $"{_dateTime}-|-{_userPrompt}-|-{_userEntry}";
                }

            /// <summary>
            /// used to prepar text for an output (screen/console);
            /// </summary>
            /// <param name="journalEntry"></param>
            public void Deserialize(string journalEntry)
                {
                    string[] segment = journalEntry.Split("-|-");
                    
                    if (journalEntry.Length < 3)
                        {
                            Console.WriteLine("ERROR 0004 - Missing line segments, in Entry.Deserialize.");
                        }
                    else
                        {
                            _dateTime = segment[0];
                            _userPrompt = segment[1];    
                            _userEntry = segment[2];
                        }
                }

                /// <summary>
                /// this is used for displaying the contents to the console or output.
                /// </summary>
                public void Display()
                    {
                        Console.WriteLine($"DateTime: {_dateTime} - Prompt: {_userPrompt}\n{_userEntry}\n");
                    }



                
    }