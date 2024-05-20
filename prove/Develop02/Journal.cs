using System;
public class Journal
    {
        public string _name = "";
        public List<Journal> _journal = new List<Journal>();

        public void Load()
            {
                Console.WriteLine("Filename Loaded");
            }

        public void Save()
            {
                Console.Write("Please enter the filename: ");
                string _savedFileName = Console.ReadLine();
                Console.WriteLine($"{_savedFileName} has been saved.");
            }

        public void Display()
        {
            Console.WriteLine("The list of saved journals should be displayed.");
        /*    Console.WriteLine($"Persons Name: {_name}");
            Console.WriteLine("Job List: ");
            
            foreach (Journal journal in _journal)
            {
                journal.Display();  
            }   */

        }

    }