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

        int index = 0;

        foreach (Word word in _words)
        {
            if(word._isHidden)
            {
                Console.Write("____ ");
            }
            else if(word.wordIsDigit(word._text))
            {
                if (index != 0){
                    Console.WriteLine();
                    Console.WriteLine();
                }
                
                Console.Write(word._text + " ");
            }
            else
            {
                Console.Write(word._text + " ");
            }

            index ++;
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
            if(!word._isHidden && !word.wordIsDigit(word._text))
            {
                unhiddenWords.Add(word);
            }
        }
        return unhiddenWords;
    }
}