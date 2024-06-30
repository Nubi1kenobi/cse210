using System;
using System.Dynamic;

public class User
{  
    private List<int> scoreUpdate = new List<int>();
    private string userName;
    private int score;
    public User()
    {
        int score = 0;
        string userName = "";

    }
    public string GetUser()
    {
        return userName;
    }
    public string Login()
    {
        while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to your Eternal Goals!!!!!");
                Console.Write("Please Enter your username: ");
                userName = Console.ReadLine();
                if (InputHandler(userName))
                    {
                        return userName;
                    }
                InvalidInputMessage(userName);
            }
    }
    public List<int> GetScoreUpdateList()
    {
        return scoreUpdate;
    }

    public void SetScoreUpdateList(int newScore)
    {
        scoreUpdate.Add(newScore);
    }

    public int GetScore()
    {
        UpdateScore();
        return score;
    }
    public void UpdateScore()
    {   
        foreach(int newScore in scoreUpdate)
        {
            score = score + newScore;
            Console.WriteLine($"Score: {score}, NewScore: {newScore}");
        }    
        //scoreUpdate.Add(newScore);
    }
    static private bool InputHandler(string userName)
            {
                return !string.IsNullOrWhiteSpace(userName) && userName.Length >= 3 && userName.Length <= 16;
            }
        
        static private void InvalidInputMessage(string userName)
            {
                Console.CursorVisible = false;
                Console.Clear();
                Console.WriteLine($"{userName} is an invalid Username. It must be between 3 and 16 characters long.");
                Console.WriteLine("<Press Any Key>");
                Console.ReadKey();
                Console.CursorVisible = true;
            }
        
    



}