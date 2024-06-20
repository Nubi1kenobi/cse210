using System;
using System.Diagnostics;
public class Scripture
{
//object variables***********************************
    private string _scripture;
    private string[] _scriptureWords;
    private List<Word> _scriptureWordList = new List<Word>();

//contructors**************************************
public Scripture(string scripture)
{
    _scripture = scripture;
    _scriptureWords = _scripture.Split(" ");
    
    foreach (string wordText in _scriptureWords)
    {
        Word word = new Word();
        _scriptureWordList.Add(word);
    }
 
    // _scriptureWordList[0].SetHidden();
    // _scriptureWordList[1].SetHidden();
    // _scriptureWordList[2].SetHidden();
    // _scriptureWordList[3].SetHidden();
    // _scriptureWordList[4].SetHidden();
    // _scriptureWordList[5].SetHidden();
    // _scriptureWordList[6].SetHidden();
    _scriptureWordList[elRandomo()].SetHidden();



    for (int i = 0; i < _scriptureWordList.Count; i++)
    {
        if (_scriptureWordList[i].GetStatus())
        {
            _scriptureWords[i] = "".PadLeft(_scriptureWords[i].Length, '_');
        }
    }
    
    _scripture = string.Join(" ", _scriptureWords);
}    

//methods/Getters/Setters**************************************
    public string GetScripture() 
        {
            return _scripture; 
        }
   
    private string[] GetScriptureWords()
    {
        return _scriptureWords;
    }

    // private void SetScripture(string scripture) 
    //     { 
    //         _scripture = scripture;
    //     }
    
    public int GetWordCount()
    {
        //Console.WriteLine($"There are {_scriptureWords.Length} words stored in the array");
        return _scriptureWords.Length;
    }

    private int elRandomo()
    {
        bool isValid = false;
        int _theRandomNumber;
        var _randomizer = new Random();
        do                                                  
            {
                _theRandomNumber = _randomizer.Next(1,_scriptureWordList.Count);
                if (_scriptureWordList[_theRandomNumber].GetStatus() == true) // checks for hidden state
                    {   
                        _theRandomNumber = _randomizer.Next(1,_scriptureWordList.Count);
                    }
                    else isValid = true;
            }
        while (!isValid);
        return _theRandomNumber;
    }

}