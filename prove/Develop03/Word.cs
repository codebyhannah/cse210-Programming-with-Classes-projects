using System;

public class Word
{
    // C sharp gives you automatic getters and setters, which can be be set up in the declaration of the attribute instead of writing a getter or setter function. Ethan showed them to us. a private set only allows functions inside of the class to directly set the attribute.
    public string _text {get; private set;}
    public bool _isHidden {get; private set;}

    public Word(string text)
    {
        _text = text;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public bool wordIsDigit(string text)
    {
        bool isDigit = false;
        foreach (char c in text){
            isDigit = Char.IsNumber(c);
        }
        
        return isDigit;
    }
}