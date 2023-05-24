using System;

public class Scripture
{
    private Reference _reference;
    private string _text;
    private List<Word> _words;
    private Random _random;

    public Scripture(string referenceText, string scriptureText)
    {
        _reference = new Reference(referenceText);
        _text = scriptureText;
        _words = new List<Word>();
        _random = new Random();

        string[] splitText = _text.Split(" ");

        foreach (string wordText in splitText)
        {
            Word word = new Word(wordText);
            _words.Add(word);
        }
    }

    public void DisplayScripture()
    {
        Console.Clear();
        Console.WriteLine($"{_reference._referenceText}");
        Console.WriteLine();

        foreach (Word word in _words)
        {
            if(word._isHidden)
            {
                Console.Write("____ ");
            }
            else
            {
                Console.Write(word._text + " ");
            }
        }
        Console.WriteLine();
        Console.WriteLine();
    }

    public void HideRandomWord()
    {
        List<Word> unhiddenWords = GetUnhiddenWords();
        if(unhiddenWords.Count == 0)
        {
            return;
        }

        int randomIndex = _random.Next(0, unhiddenWords.Count());
        Word randomWord = unhiddenWords[randomIndex];
        randomWord.Hide();

    }

    public List<Word> GetUnhiddenWords()
    {
        List<Word> unhiddenWords = new List<Word>();

        foreach(Word word in _words)
        {
            if(!word._isHidden)
            {
                unhiddenWords.Add(word);
            }
        }
        return unhiddenWords;
    }
}

public class Reference
{
    public string _referenceText {get; private set;}

    public Reference(string referenceText)
    {
        _referenceText = referenceText;
    }
}

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
}