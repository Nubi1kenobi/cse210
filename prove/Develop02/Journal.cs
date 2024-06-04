using System;
using System.IO;
public class Journal
{
   //object variables
    private string _journalName = "Unsaved Jounral";
    public List<Entry> _journalEntry = new List<Entry>();

//constructors
    public Journal()
    {
        _journalName = "";
    }

//methods
    public void Save()
        {
            Console.Write("Please declare a filename to use for this journal (without the extension): ");
            _journalName = Console.ReadLine() + ".txt";
            Console.WriteLine($"Your filename is {_journalName}");
            Console.WriteLine("\n<Press Any Key to Continue>"); //above and beyond, makes it cleaner.Console.ReadKey();
            Console.ReadKey();
            using (StreamWriter _outputFile = new StreamWriter(_journalName, true))
                {                     
                    foreach (Entry journalEntry in _journalEntry)
                        {
                            _outputFile.WriteLine($"{journalEntry.OutToFile()}-||-");
                        }
                }
            Console.ReadKey();
            Console.WriteLine("\n<Press Any Key to Continue>"); //above and beyond, makes it cleaner.
       
        }
    /// <summary>
    /// Load() method takes a text file and chuncks into a string and pieces the string into an array.
    /// </summary>
    /// <returns></returns>
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

            /*
foreach (string line in lines) 
            {
                string parts = line.Split("-||-");
            }
            */
            

                
            //Console.ReadKey();
            //Console.WriteLine("\n<Press Any Key to Continue>"); //above and beyond, makes it cleaner.
        }
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

