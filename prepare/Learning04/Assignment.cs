using System;
using System.Reflection.Metadata.Ecma335;
public class Assignment
{
    private string _studentName = "";
    private string _topic = "";

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetSummary()
        {
            return $"Name: {_studentName}, Topic: {_topic}: ";
            
        }

    
}