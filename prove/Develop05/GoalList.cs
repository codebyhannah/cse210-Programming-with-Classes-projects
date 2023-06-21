using System;

public class GoalList
{
    // Attributes
    public string _filePath;
    private List<string> _fileContents = new List<string>() {"clear this"};

    // Constructors
    public GoalList() 
    {
        //empty
    }
    public GoalList(string filePath) 
    {
        _filePath = filePath;
    }


    // Getters and Setters
    public string GetFilePath()
    {
        return _filePath;
    }
    public void SetFilePath(string filePath)
    {
        _filePath = filePath;
    }

    // Methods
    public void ReadFile()
    {
        // string.Trim(); removes white space from a string
        Console.WriteLine("Reading File using File.ReadAllLines()");
  
        // To read a text file line by line
        if (File.Exists(_filePath)) {
            // Store each line in array of strings
            string[] lines = File.ReadAllLines(_filePath);
  
            foreach(string ln in lines)
            {   
                string ln2 = ln.Trim();
                Console.WriteLine(ln2);
                _fileContents.Add(ln2);
            }
            int num = 0;
            foreach (string item in _fileContents)
            {
                num++;
                Console.WriteLine($"{num}. {item}");
            }
        }
        else
        {
            Console.WriteLine("Error: file not found");
        }
        Console.WriteLine();
        _fileContents.Clear();
  
        Console.WriteLine("Reading File using StreamReader");
  
        // By using StreamReader
        if (File.Exists(_filePath)) {
            // Reads file line by line
            StreamReader Textfile = new StreamReader(_filePath);
            string line;
  
            while ((line = Textfile.ReadLine()) != null) {
                string line2 = line.Trim();
                Console.WriteLine(line2);
                _fileContents.Add(line2);
            }
            int num = 0;
            foreach (string item in _fileContents)
            {
                num++;
                Console.WriteLine($"{num}. {item}");
            }
  
            Textfile.Close();
  
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("Error: file not found");
        }
        Console.WriteLine();

    }

    public void WriteFile()
    {
        

    }

    public void AppendFile()
    {

    }

}