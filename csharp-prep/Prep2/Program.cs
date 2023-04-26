using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter grade percentage: ");
        string userInput = Console.ReadLine();
        int numGrade = int.Parse(userInput);

        string letter = "";

        if (numGrade >= 90)
        {
            letter = "A";
        }
        else if (numGrade >= 80)
        {
            letter = "B";
        }
        else if (numGrade >= 70)
        {
            letter = "C";
        }
        else if (numGrade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }


        Console.WriteLine($"Your grade is: {letter}");
        if (numGrade >= 70)
        {
            Console.WriteLine("Congratulations, you pass!");
        }
        else 
        {
            Console.WriteLine("You fail.");
        }

        


    }
}