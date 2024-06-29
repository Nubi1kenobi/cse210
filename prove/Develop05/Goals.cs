using System;
using System.Net.WebSockets;

public class Goal
    {
        
        private string _goalName;
        private int _goalValue;
        private string _goalDescription;
        private bool _isComplete = false;
        private bool _isPermanant = false;
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
        public string SetGoal(string userName)
        //public void SetGoal(string userName)
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
                //_serializedOutput = Serialize(_userName, _goalName, _goalDescription, _goalValue, _isComplete, _isPermanant);
                return Serialize(_userName, _goalName, _goalDescription, _goalValue, _isComplete, _isPermanant);
            }
        private string Serialize(string userName, string goalName, string goalDescription, int goalValue, bool isComplete, bool isPermanant)
            {
                return $"{userName}-|-{goalName}-|-{goalDescription}-|-{goalValue}-|-{isComplete}-|-{isPermanant}";
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