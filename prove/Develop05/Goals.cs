using System;
using System.Net.WebSockets;

public class Goal
    {
        
        private string _goalName;
        private int _goalValue;
        private string _goalDescription;
        private bool _isComplete = false;
        private bool _isPermanant = false;
        protected bool[] _goalType = {true, false, false}; // Simple Goal = _goalType[0], Eternal Goal = _goalType[1], Checklist Goal = _goalType[2]
        protected string _serializedOutput;
        
        public Goal()
            {
                _goalName = "";
                _goalDescription = "";
                _goalValue = 0;
                _serializedOutput = "";
                
            }
        private string GetGoal()
            {
                
                return _serializedOutput;
            }
        //public string SetGoal(string userName)
        public string SetGoal(string userName)
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
                return Serialize(_userName, _goalType[0], _goalType[1], _goalType[2], _goalName, _goalDescription, _goalValue, _isComplete, _isPermanant );
            }
        private string Serialize(string userName, bool simpleGoal, bool eternalGoal, bool checklistGoal, string goalName, string goalDescription, int goalValue, bool isComplete, bool isPermanant)
            {
                string serializedData = $"{userName}-|-{simpleGoal}-|-{eternalGoal}-|-{checklistGoal}-|-{goalName}-|-{goalDescription}-|-{goalValue}-|-{isComplete}-|-{isPermanant}";

                return $"{userName}-|-{simpleGoal}-|-{eternalGoal}-|-{checklistGoal}-|-{goalName}-|-{goalDescription}-|-{goalValue}-|-{isComplete}-|-{isPermanant}";
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
        
    }