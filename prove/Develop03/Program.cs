using System;

class Program
{
    static void Main(string[] args)
    {
        
        Scripture myScripture = new Scripture("D&C 6:36", "Look unto me in every thought; doubt not, fear not.");

        myScripture.DisplayScripture();

        while(true)
        {
            Console.WriteLine("Press 'Enter' to continue or type 'quit' to exit.");
            string input = Console.ReadLine();
            if(input == "quit")
            {
                break;
            }

            myScripture.HideRandomWord();
            myScripture.DisplayScripture();
            
            if (myScripture.GetUnhiddenWords().Count == 0)
            {
                break;
            }

        }

    }
}

/*

3 Class objects

Scripture Parent
    Reference Child/Parent
        Word Child


Constructors Scripture

Scripture(Reference)
Scripture(Reference_Text)
Scripture(Reference, Reference_Text_List[])
(can separate verses using the numbers as delimiters)
//Setters/Getters

string getReference();
string getReference_Text();

*/