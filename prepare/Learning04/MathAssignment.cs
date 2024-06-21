using System;
public class MathAssignment : Assignment
{
    private string _textBookSection = "";
    private string _problems = "";
  
    public string HomeworkList()
        {
            return $"Section: {_textBookSection}, Problems: {_problems}.";
        }

    
}