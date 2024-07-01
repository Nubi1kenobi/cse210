using System;
using System.Collections.Generic;
using System.IO;

public class Goal
{
    private string _fileName;
    private string _lineUserName;
    private string _goalType;
    private string _goalName;
    private int _goalValue;
    private string _goalDescription;
    private bool _isComplete = false;
    private bool _isPermanent = false;
    private string _serializedOutput;

    public Goal()
    {
        _fileName = "EternalGoalsTracker.txt";
        _lineUserName = "";
        _goalType = "simple";
        _goalName = "";
        _goalDescription = "";
        _goalValue = 0;
        _serializedOutput = "";
    }

    public string GetGoal() => _serializedOutput;

    public void SetGoal(string userName)
    {
        Prompts(userName);
        _serializedOutput = Serialize(userName, _goalType, _goalName, _goalDescription, _goalValue, _isComplete, _isPermanent);
    }

    public string Deserialize(string serializedOutput, User newUser)
    {
        string isCompleteMarker = "";
        string[] segments = serializedOutput.Split("-|-");
        
        if (segments.Length < 7)
        {
            Console.WriteLine("ERROR - Incorrect amount of line segments, in Goal.Deserialize.");
        }
        else
        {            
            _lineUserName = segments[0];
            _goalType = segments[1];
            _goalName = segments[2];
            _goalDescription = segments[3];
            _goalValue = int.Parse(segments[4]);
            _isComplete = bool.Parse(segments[5]);
            if (_isComplete)
            {
                newUser.SetScoreUpdateList(int.Parse(segments[4]));
            }
            _isPermanent = bool.Parse(segments[6]);
        }
        isCompleteMarker = _isComplete ? "X" : " ";
        return $"[{isCompleteMarker}] {_goalName}: {_goalDescription}";
    }

    private void Prompts(string userName)
    {
        Console.Clear();
        Console.Write($"{userName}, what is the name of your goal? ");
        _goalName = Console.ReadLine();
        Console.Clear();
        Console.Write($"{userName}, what is a short description of your goal? ");
        _goalDescription = Console.ReadLine();
        Console.Clear();
        Console.Write($"{userName}, what is the amount of points associated with this goal? ");
        _goalValue = InputHandler();
    }

    private int InputHandler()
    {
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int goalValue))
                return goalValue;

            InvalidInputMessage();
        }
    }

    private void InvalidInputMessage()
    {
        Console.Clear();
        Console.WriteLine("Invalid input. Please enter an integer.");
        Console.WriteLine("<Press Any Key>");
        Console.ReadKey();
    }

    public void Save(List<string> allGoals)
    {
        Console.Clear();
        HashSet<string> savedGoals = new HashSet<string>(File.ReadAllLines(_fileName));
        using (StreamWriter outputFile = new StreamWriter(_fileName, true))
        {                     
            foreach (string goalLine in allGoals)
            {
                if (!savedGoals.Contains(goalLine))
                {
                    outputFile.WriteLine(goalLine);
                    savedGoals.Add(goalLine);
                }
            }
        }
        Console.Clear();
        Console.WriteLine($"{_fileName} has been saved.");
    }

    public void Load(List<string> allGoals, string userName, User newUser)
    {
        Console.Clear();
        string[] allFileLines = File.ReadAllLines(_fileName);
        foreach (string fileLine in allFileLines)
        {
            Goal newGoal = new Goal();
            newGoal.Deserialize(fileLine, newUser);
            if (newGoal._lineUserName == userName)
            {
                if (_goalType == "simple")
                {
                    allGoals.Add(fileLine);
                }
                else
                {
                    DebugUtility.Debug("Error at Goal.Load()");
                }
            }
        }
        Console.CursorVisible = false;
        Console.Clear();
        Console.WriteLine($"{_fileName} has been loaded.");
    }

    private string Serialize(string userName, string goalType, string goalName, string goalDescription, int goalValue, bool isComplete, bool isPermanent)
    {
        return $"{userName}-|-{goalType}-|-{goalName}-|-{goalDescription}-|-{goalValue}-|-{isComplete}-|-{isPermanent}";
    }
}
