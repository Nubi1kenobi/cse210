using System;
public class WritingAssignment : Assignment
{
    private string _title = "";

    public string WritingInformation()
        {
            return $"Writing Infor: {_title}";
        }

}