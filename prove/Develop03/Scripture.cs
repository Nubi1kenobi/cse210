using System;
using System.Diagnostics;
public class Scripture
{
//object variables***********************************
    private string _scripture;
    private string _updatedScripture;
    private string[] _scriptureWords;

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
    
    public void CountArray()
    {
        Console.WriteLine($"There are {_scriptureWords.Length} words stored in the array");
    }

//methods******************************************************
 

}