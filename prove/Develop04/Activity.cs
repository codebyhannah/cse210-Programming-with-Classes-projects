using System;

public class Activity
{
    /*
    Base class for all other activity classes. 
    Displays the opening and closing messages as well as containing other behaviors/methods that are common in the derived activity classes.
    */
    public string _name = "";
    public string _openingMessage = "";
    public string _closingMessage = "";
    public int _time = 30; // Time in seconds


    public Activity(string name, string openingMessage, string closingMessage)
    {
        _name = name;
        _openingMessage = openingMessage;
        _closingMessage = closingMessage;
    }

    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public string GetOpeningMessage()
    {
        return _openingMessage;
    }
    public void SetOpeningMessage(string openingMessage)
    {
        _openingMessage = openingMessage;
    }
    public string GetClosingMessage()
    {
        return _closingMessage;
    }
    public void SetClosingMessage(string closingMessage)
    {
        _closingMessage = closingMessage;
    }

    public void DisplayMessage(string message)
    {
        Console.WriteLine(message);
    }

}