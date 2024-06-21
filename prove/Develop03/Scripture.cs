using System;
using System.Diagnostics;
using System.Runtime.Serialization;
public class Scripture
    {
    //object variables***********************************
        private string _scripture;
        private string[] _scriptureWords;
        private int _flaggedWords = 0;
        private List<Word> _scriptureWordList = new List<Word>();
        


    //contructors**************************************
    public Scripture(string scripture)
        {
            _scripture = scripture;
            _scriptureWords = _scripture.Split(" ");
        }    

    //methods/Getters/Setters**************************************
        public string GetScripture() 
            {
                return _scripture; 
            }
        
        public int GetWordCount()
            {
                return _scriptureWords.Length;
            }

        public int GetFlaggedWordCount()
            {
                return _flaggedWords;
            }

        public string GetUpdatedScripture()
            {
                foreach (string wordText in _scriptureWords)
                    {
                        Word word = new Word();
                        _scriptureWordList.Add(word);
                    }
        
                HideMultipleWords();

                for (int i = 0; i < _scriptureWordList.Count; i++)
                    {
                        if (_scriptureWordList[i].GetStatus())
                            {
                                _scriptureWords[i] = "".PadLeft(_scriptureWords[i].Length, '_');
                            }
                    }
                
                _scripture = string.Join(" ", _scriptureWords);
                return _scripture;
            }
    
        private void HideMultipleWords()
            {
                int _randomNumber;
                var rando = new Random();
                int _rCount = 4;
                int diff = _scriptureWords.Count()-_flaggedWords;
                if (diff < 2) {_rCount = 1;}
                _randomNumber = rando.Next(1,_rCount);
                for (int i = _randomNumber; i > 0; i--) { _scriptureWordList[ElRandomo()].SetHidden(); }
                _flaggedWords = _flaggedWords + _randomNumber;

            }
        private int ElRandomo()
            {
                bool _isValid = false;
                int _theRandomNumber;
                var _randomizer = new Random();
                do                                                  
                    {
                        _theRandomNumber = _randomizer.Next(0,GetWordCount());
                        if (_scriptureWordList[_theRandomNumber].GetStatus() == true) // checks for hidden state
                            {   
                                _theRandomNumber = _randomizer.Next(1,_scriptureWordList.Count);
                            }
                            else _isValid = true;
                    }
                while (!_isValid);
                return _theRandomNumber;
            }

    }