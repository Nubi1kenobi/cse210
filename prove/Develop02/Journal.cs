using System;
public class Journal
{
    public string _journalName = "Something Dumb";
    public List<Entry> _entry = new List<Entry>();
    //internal static object _entry;

    public void Save()
        {
            Console.WriteLine("Something Saving");
            Console.ReadKey();
        
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
            Console.WriteLine("");
            }
        }
}

