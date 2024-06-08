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
                newEntry.WriteUserPrompts(); // Prompt the user and get the entry
                _journalEntry.Add(newEntry);
            }
    
        /// <summary>
        /// save newJournal to a text file;
        /// </summary>
        public void Save()
            {
                Console.Clear();    //above and beyond, makes it cleaner.
                Console.Write("Please declare a filename to use for this journal (without the extension): ");
                _journalName = Console.ReadLine() + ".txt";
                using (StreamWriter _outputFile = new StreamWriter(_journalName, true))
                    {                     
                        foreach (Entry journalEntry in _journalEntry)
                            {
                                _outputFile.WriteLine(journalEntry.OutToFile());
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
        public void Load()
            {
                Console.Clear();
                Console.Write("Please type a filename for the journal you would like to load, without the extension.\n> ");
               _journalName = Console.ReadLine() + ".txt";
               
                string[] fileLines = File.ReadAllLines(_journalName);              
                
                foreach (string fileLine in fileLines) 
                    {
                        Entry newEntry = new Entry();
                        newEntry.WriteTextFilePrompts(fileLine);
                        _journalEntry.Add(newEntry);
                    } 

                Console.Clear();    //above and beyond, makes it cleaner.
                Console.WriteLine($"{_journalName} has been loaded.");  //above and beyond, makes it cleaner.
                Console.WriteLine("<Press Any Key>");   //above and beyond, makes it cleaner.
                Console.ReadKey();  //above and beyond, makes it cleaner.
            }

        /// <summary>
        /// Load() method takes a text file and chuncks into a string and pieces the string into an array.
        /// </summary>
        public void Display()
            {
                Console.Clear();    //above and beyond, makes it cleaner.
                Console.WriteLine("Entry List: ");
                
                
                foreach (Entry journalEntry in _journalEntry)
                    {
                        journalEntry.Display();
                    }
                
                Console.CursorVisible = false;  //above and beyond, makes it cleaner.
                Console.WriteLine($"The contents of {_journalName} have been displayed.");  //above and beyond, makes it cleaner.
                Console.WriteLine("<Press Any Key>");   //above and beyond, makes it cleaner.
                Console.ReadKey();  //above and beyond, makes it cleaner.
            }



}

