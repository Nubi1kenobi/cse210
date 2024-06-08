using System;
using System.IO;
public class Journal
{
    //object variables
        private string _journalName; 
        private List<Entry> _journalEntry = new List<Entry>();

    //constructors
        public Journal()
            {
                _journalName =  "Unsaved Jounral";;
            }

    //methods
        /// <summary>
        /// calles for a prompt, then writes a new entry and serializes it;
        /// </summary>
        public void Write()
            {
                Entry newEntry = new Entry();
                newEntry.Write(); // Prompt the user and get the entry
                _journalEntry.Add(newEntry);

                Console.CursorVisible = false;  //above and beyond, makes it cleaner.
                Console.Clear();    //above and beyond, makes it cleaner.
                Console.WriteLine("Entry added.");  //above and beyond, makes it cleaner.
                Console.WriteLine("<Press Any Key>");   //above and beyond, makes it cleaner.
                Console.ReadKey();  //above and beyond, makes it cleaner.
            }
    
        /// <summary>
        /// save newJournal to a text file;
        /// </summary>
        public void Save()
            {
                Console.Write("Please declare a filename to use for this journal (without the extension): ");
                _journalName = Console.ReadLine() + ".txt";
                using (StreamWriter _outputFile = new StreamWriter(_journalName, true))
                    {                     
                        foreach (Entry journalEntry in _journalEntry)
                            {
                                _outputFile.WriteLine($"{journalEntry.OutToFile()}-||-");
                            }
                    }

                Console.CursorVisible = false;  //above and beyond, makes it cleaner.
                Console.Clear();    //above and beyond, makes it cleaner.
                Console.WriteLine($"{_journalName} has been saved.");  //above and beyond, makes it cleaner.
                Console.WriteLine("<Press Any Key>");   //above and beyond, makes it cleaner.
                Console.ReadKey();  //above and beyond, makes it cleaner.
        
            }
        
        /// <summary>
        /// Load() method takes a text file and chuncks into a string and pieces the string into an array.
        /// </summary>
        public string[] Load()
            {
                Console.Write("Please type a filename for the journal you would like to load. ): ");
                _journalName = Console.ReadLine() + ".txt";
                // <reserved slot for error detection to see if the file really exists>
                Console.WriteLine($"You are loading {_journalName}");
                string _loadedStringFile = File.ReadAllText(_journalName); 
                Console.WriteLine("\n<Press Any Key to Continue>"); //above and beyond, makes it cleaner.Console.ReadKey();
                Console.ReadKey();
                //Console.WriteLine(_stringFile);
                //Console.WriteLine("\n<Press Any Key to Continue>"); //above and beyond, makes it cleaner.Console.ReadKey();
                string[] _loadedArrayEntries = _loadedStringFile.Split("-||-");
                Console.WriteLine($"loadedArrayEntries Length = :{_loadedArrayEntries.Length}"); //above and beyond, makes it cleaner.Console.ReadKey();
                Console.WriteLine("\n<Press Any Key to Continue>"); //above and beyond, makes it cleaner.Console.ReadKey();
                Console.ReadKey();
                Console.WriteLine("");
                for (int i = 0; i < (_loadedArrayEntries.Length - 1); i++) 
                    {
                    Console.WriteLine($"<journal> {i} - {_loadedArrayEntries[i]}"); 
                    }
                Console.WriteLine("\n<Press Any Key to Continue>"); //above and beyond, makes it cleaner.Console.ReadKey();
                Console.ReadKey();

                return _loadedArrayEntries;

            }

        /// <summary>
        /// Load() method takes a text file and chuncks into a string and pieces the string into an array.
        /// </summary>
        public void Display()
            {
                
                Console.WriteLine($"Journal Name: {_journalName}\n");
                Console.WriteLine("Entry List: ");
                
                
                foreach (Entry journalEntry in _journalEntry)
                    {
                        journalEntry.Display();
                    }
                
                Console.WriteLine("\n<Press Any Key to Continue>"); //above and beyond, makes it cleaner.
            }



}

