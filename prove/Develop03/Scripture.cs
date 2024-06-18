using System;
using System.Diagnostics;
public class Scripture
{
//object variables***********************************
    private string _scripture;
    private string[] _scriptureWords;
    private List<Word> _scriptureWordList;

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
    
    for (int i = 0; i < _scriptureWordList.Count; i++)
    {
        if (_scriptureWordList[i].GetStatus())
        {
            _scriptureWords[i] = "*****";
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
        //_scriptureWords = _scripture.Split(" ");
        //add logic to hide words
        return _scriptureWords;
    }

    public void SetScripture(string scripture) 
        { 
            _scripture = scripture;
        }
    
    public int GetWordCount()
    {
        //Console.WriteLine($"There are {_scriptureWords.Length} words stored in the array");
        return _scriptureWords.Length;
    }

//methods******************************************************
 

}