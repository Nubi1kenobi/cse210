using System;
using System.Collections.Generic;
using System.IO;

public class User
{
    List<string> _allGoals;
    private List<int> _scoreUpdate;
    private List<string> _userList;
    private string _userName;
    private string _fileUserName;
    private string _fileName;
    private string _fileName2;
    private int _score;
    
    public User()
    {
        _allGoals = new List<string>();
        _scoreUpdate = new List<int>();
        _userName = "";
        _fileName = "userList.txt";
        _fileName2 = "EternalGoalsTracker.txt";
        _score = 0;
        _fileUserName = "";
    }

    public string GetUser() => _userName;

    public void Login(User newUser)
    {
        bool validUsername = false;

        while (!validUsername)
        {
            Console.Clear();
            Console.WriteLine("Welcome to your Eternal Goals!!!!!");
            Console.Write("Please Enter your username: ");
            _userName = Console.ReadLine();

            // Validate the username length
            if (!InputHandler(_userName))
            {
                InvalidInputMessage();
                continue; // Restart the loop to prompt for username again
            }

            // Load existing usernames from file
            LoadUserList();

            // Check if username exists in userList
            if (CheckUsersOnFile(_userName))
            {
                validUsername = true;
            }
            else
            {
                Console.WriteLine("Your username does not exist.");
                Console.Write("Press 'y' to create it or any other key to retry: ");
                string userInput = Console.ReadLine();

                if (userInput.ToLower() == "y")
                {
                    SaveUserToFile();
                    validUsername = true;
                }
            }
        }
    }

    public List<int> GetScoreUpdateList() => _scoreUpdate;
    public void SetFileLineUsername(string segment0)
    {
        _fileUserName = segment0;
    }

    public void SetScoreUpdateList(int newScore) => _scoreUpdate.Add(newScore);

    public int GetScore()
    {
        UpdateScore();
        return _score;
    }

    public List<string> GetUserGoals()
    {
        return _allGoals;
    }

    private void UpdateScore()
    {
        _score = 0;
        foreach (int newScore in _scoreUpdate)
        {
            _score += newScore;
            DebugUtility.Debug(newScore);
        }
        _scoreUpdate.Clear(); // Clear _scoreUpdate after updating _score
    }

    private static bool InputHandler(string userName) =>
        !string.IsNullOrWhiteSpace(userName) && userName.Length >= 3 && userName.Length <= 16;

    private static void InvalidInputMessage()
    {
        Console.Clear();
        Console.WriteLine("Invalid Username. It must be between 3 and 16 characters long.");
        Console.WriteLine("<Press Any Key>");
        Console.ReadKey();
    }

    private void SaveUserToFile()
    {
        using (StreamWriter outputFile = new StreamWriter(_fileName, true))
        {
            outputFile.WriteLine(_userName);
        }
    }
    private void LoadUserList()
    {
        if (File.Exists(_fileName))
        {
            _userList = new List<string>(File.ReadAllLines(_fileName));
        }
        else
        {
            _userList = new List<string>();
        }
    }

    private bool CheckUsersOnFile(string userName)
    {
        return _userList.Contains(userName);
    }

     public void Save()
    {
        Console.Clear();
        HashSet<string> savedGoals = new HashSet<string>(File.ReadAllLines(_fileName));
        using (StreamWriter outputFile = new StreamWriter(_fileName, true))
        {                     
            foreach (string goalLine in _allGoals)
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

    public void Load(User newUser)
    {
        Console.Clear();
        string[] allFileLines = File.ReadAllLines(_fileName);
        foreach (string fileLine in allFileLines)
        {
            Goal newGoal = new Goal();
            newGoal.Deserialize(fileLine, newUser);
            if (_fileUserName == _userName)
            {
                _allGoals.Add(fileLine);;
            }
        }
        Console.CursorVisible = false;
        Console.Clear();
        Console.WriteLine($"{_fileName} has been loaded.");
    }
}
