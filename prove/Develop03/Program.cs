using System;

class Program
{
    static void Main(string[] args)
    {
        
        //Scripture myScripture = new Scripture("D&C 6:36", "36 Look unto me in every thought; doubt not, fear not.");

        Scripture myScripture = new Scripture("Genesis 1:1-5","1 In the beginning God created the heaven and the earth. 2 And the earth was without form, and void; and darkness was upon the face of the deep. And the Spirit of God moved upon the face of the waters. 3 And God said, Let there be light: and there was light. 4 And God saw the light, that it was good: and God divided the light from the darkness. 5 And God called the light Day, and the darkness he called Night. And the evening and the morning were the first day.");

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