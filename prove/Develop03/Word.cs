using System;
using System.Diagnostics;
public class Word
{

    //object variables***********************************
        private bool _isHidden = false;
    //contructors**************************************

    //methods**************************************************

    public string Text { get; }
    public void SetHidden()
        {
            _isHidden = true;
        }   

    public bool GetStatus()
    {
        return _isHidden;
    }     
          
        

}