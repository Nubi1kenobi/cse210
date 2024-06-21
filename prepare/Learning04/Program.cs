using System;

class Program
    {
        static void Main(string[] args)
            {
                Console.Clear();
                Console.WriteLine("Hello Learning04 World!");
                
                MathAssignment todaysMath = new MathAssignment("Bryan Stauch", "Math", "1", "All Odd");
                WritingAssignment todaysWriting = new WritingAssignment("Bryan Stauch", "Writing", "Creative Writing - Non Fiction");

                Console.WriteLine(todaysMath.GetSummary() + " " + todaysMath.GetHomeworkList());
                Console.WriteLine(todaysWriting.GetSummary()+ " " + todaysWriting.GetWritingInformation());
            }
    }