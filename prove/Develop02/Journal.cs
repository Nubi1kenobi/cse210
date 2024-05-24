using System;
public class Journal
{
    public string _journalName = "Something Dumb";
    public List<Entry> _entry = new List<Entry>();

    public void Save(Journal newJournal, Entry newEntry)
        {
            Console.Write("Please declare a filename to use for this journal (without the extension): ");
            _journalName = Console.ReadLine() + ".txt";
            Console.WriteLine($"Your filename is {_journalName}");
            Console.WriteLine("\n<Press Any Key to Continue>"); //above and beyond, makes it cleaner.Console.ReadKey();
            Console.ReadKey();
            using (StreamWriter _outputFile = new StreamWriter(_journalName, true))
                {                     
                    foreach (Entry journalEntry in _entry)
                        {
                            string _serializedEntry = newEntry.Serialize();
                            _outputFile.WriteLine(_serializedEntry);
                        }
                }
            Console.ReadKey();
            Console.WriteLine("\n<Press Any Key to Continue>"); //above and beyond, makes it cleaner.
       
        }
    public void Load()
        {
            Console.WriteLine("Something Loading");
            Console.ReadKey();
        }
    public void Display()
        {
            Console.WriteLine($"Journal Name: {_journalName}\n");
            Console.WriteLine("Entry List: ");
            
            foreach (Entry journalEntry in _entry)
                {
                    journalEntry.Display();
                }
            Console.WriteLine("\n<Press Any Key to Continue>"); //above and beyond, makes it cleaner.
        }
}

