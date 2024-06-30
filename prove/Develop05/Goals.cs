using System;


public class Goal
{
    private string _fileName;
    private string _lineUserName;
    private string _goalType;
    private string _goalName;
    private int _goalValue;
    private string _goalDescription;
    private bool _isComplete = false;
    protected bool _isPermanant = false;
    protected string _serializedOutput;
    
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
    public string GetGoal()
    {
        return _serializedOutput;
    }
    //public string SetGoal(string userName)
    public void SetGoal(string userName)
    {
        string _userName = userName;
        Prompts(_userName);
        _serializedOutput = Serialize(_userName, _goalType, _goalName, _goalDescription, _goalValue, _isComplete, _isPermanant );
    }

    private void Prompts(string userName)
    {
            string _userName = userName;
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
    private string Serialize(string userName, string goalType, string goalName, string goalDescription, int goalValue, bool isComplete, bool isPermanant)
    {
        return $"{userName}-|-{goalType}-|-{goalName}-|-{goalDescription}-|-{goalValue}-|-{isComplete}-|-{isPermanant}";
    }

    public string Deserialize(string _serializedOutput, User newUser)
    {
        string _isCompleteMarker = "";
        string[] _segments = _serializedOutput.Split("-|-");
        
        if (_serializedOutput.Length < 7)
        {
            Console.WriteLine("ERROR - Incorrect amount of line segments, in Goal.Deserialize.");
        }
        else
        {            
            _lineUserName = _segments[0];
            _goalType = _segments[1];
            _goalName = _segments[2];
            _goalDescription = _segments[3];
            _goalValue = int.Parse(_segments[4]);
            _isComplete = bool.Parse(_segments[5]);
            if (_isComplete)
            {
                newUser.SetScoreUpdateList(int.Parse(_segments[4]));
            }
            _isPermanant = bool.Parse(_segments[6]);
        }
        if (_isComplete)
        {
            _isCompleteMarker = "X";
        }
        else {_isCompleteMarker = " ";}
        return $"[{_isCompleteMarker}] {_goalName}: {_goalDescription}";
    }
    private int InputHandler()
    {
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int _goalValue))
                return _goalValue;

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
        Console.Clear();    //above and beyond, makes it cleaner.
        HashSet<string> savedGoals = new HashSet<string>(File.ReadAllLines(_fileName));
        using (StreamWriter _outputFile = new StreamWriter(_fileName, true))
        {                     
            foreach (string myGoalLine in allGoals)
            {
                if (!savedGoals.Contains(myGoalLine))
                {
                    _outputFile.WriteLine(myGoalLine);
                    savedGoals.Add(myGoalLine);
                }
            }
        }
        Console.Clear();    //above and beyond, makes it cleaner.
        Console.WriteLine($"{_fileName} has been saved.");  //above and beyond, makes it cleaner.
    }
    public void Load(List<string> allGoals, string userName, User newUser)
    {
        string _userName = userName;
        Console.Clear();    //above and beyond, makes it cleaner.
        string[] allFileLines = File.ReadAllLines(_fileName);
        foreach (string fileLine in allFileLines)
        {
            Goal newGoal = new Goal();
            newGoal.Deserialize(fileLine, newUser);
            if (newGoal._lineUserName == _userName)
            {
                if (_goalType == "simple")
                {
                    allGoals.Add(fileLine);
                }
                else
                {
                    DebugUtility.Debug("Mistakes were made @ Goal.Load()");
                }
            }
            else 
            {

            }
    
            Console.CursorVisible = false;  //above and beyond, makes it cleaner.
            Console.Clear();    //above and beyond, makes it cleaner.
            Console.WriteLine($"{_fileName} has been loaded.");  //above and beyond, makes it cleaner.
        }

    }
}

    