using System;
using System.Diagnostics;
public class Reference
{
//object variables***********************************
    private string _book = "";
    private string _chapter = "";
    private string _verseBegining = "";
    private string _verseEnding = "";

//contructors**************************************
    public Reference(string book, string chapter, string verseBegining, string verseEnding)
        {
            _book = book;
            _chapter = chapter;
            _verseBegining = verseBegining;
            _verseEnding = verseEnding;
        }

//methods/Getters/Setters**************************************
    public string GetReference() 
        {
            return $"{_book} {_chapter}:{_verseBegining}-{_verseEnding}"; 
        }

//methods******************************************************
 


}