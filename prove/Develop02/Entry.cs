using System;

public class Entry
    {
        //variable declarations
        private string _dateTime = DateTime.Now.ToString("yyyy/MM/dd - HH:mm:ss");    //my DateTime format is this way because this is the way I prefer to see it on everything. I chose this.
        private string _userPrompt;
        private string _userEntry;
        private string _combinedEntry;
        private string _deserializedEntry;

//private methods
        /// <summary>
        /// randomizes an integer within a given range, then displays that prompt for the user;
        /// </summary>
        private static string Prompts() 
            {
                var _randomizer = new Random();
                int _theRandomNumber = _randomizer.Next(1,6);
                
            switch (_theRandomNumber)
                {
                    case 1:
                        return "Quick! What is the weather condition like right now?";
                    case 2:
                        return "What thought has preoccupied your mind since your last entry?";
                    case 3:
                        return "What are you planning for tomorrow?";
                    case 4:
                        return "What was the last kind thing that you did?";
                    case 5:
                        return "Tell me about one of your goals:";
                    default:
                        return $"ERROR - INVALID INT: The random number: {_theRandomNumber} is out of range, in Entry.Prompts()";
                }

            }

//public methods
        /// <summary>
        /// calles for a prompt, then writes a new entry and serializes it.
        /// </summary>
        public void WriteUserPrompts()
            {
                Console.Clear();    //above and beyond, makes it cleaner.
                _userPrompt = Prompts();
                Console.Write($"{_userPrompt}\n> ");
                _userEntry = Console.ReadLine();
                _combinedEntry = Serialize();
            }
        /// <summary>
        /// takes the serialized line from the text file and loads it as a new entry.
        /// </summary>
        public void WriteTextFilePrompts(string combinedEntry)
            {
                _combinedEntry = combinedEntry;
            }
        public string Serialize()
            {
                return $"{_dateTime}-|-{_userPrompt}-|-{_userEntry}";
            }

        /// <summary>
        /// used to prepar text for an output (screen/console);
        /// </summary>
        public string Deserialize(string journalEntry)
            {
                string[] segment = journalEntry.Split("-|-");
                
                if (journalEntry.Length < 3)
                    {
                        Console.WriteLine("ERROR - Missing line segments, in Entry.Deserialize.");
                    }
                else
                    {
                        _dateTime = segment[0];
                        _userPrompt = segment[1];    
                        _userEntry = segment[2];
                    }
                return $"DateTime: {_dateTime} - Prompt: {_userPrompt}\n{_userEntry}";
            }

            /// <summary>
            /// this is used for displaying the contents to the console or output.
            /// </summary>
            
            public void Display()
                {
                    _deserializedEntry = Deserialize(_combinedEntry);
                    Console.WriteLine($"{_deserializedEntry}\n");
                } 

            public string OutToFile()
                {
                    return _combinedEntry;
                }       
    }