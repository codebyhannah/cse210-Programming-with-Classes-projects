using System;

public class Menu
{
    public string _menuInstructions;
    public List<string> _menuOptions;
    
    public Menu(string menuInstructions, List<string> menuOptions)
    {
        _menuInstructions = menuInstructions;
        _menuOptions = menuOptions;
    }

    public void DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine(_menuInstructions);
        Console.WriteLine();
        int num = 1;
        foreach (string option in _menuOptions)
        {
            Console.WriteLine($"{num}. {option}");
            num++;
        }
        Console.WriteLine();
    }

    public void ChooseMenuOption()
    {   
        Console.Write("Enter the number corresponding to your choice: ");
        string choice = Console.ReadLine();
        Console.WriteLine($"your choice is: {choice}");

        bool isDigit = false;

        do
        {
            isDigit = false;
            foreach (char c in choice)
            {
                isDigit = Char.IsNumber(c);
            }
            
            if (choice == "1")
            {
                Console.WriteLine("one");
            }
            else if (choice == "2")
            {
                Console.WriteLine("two");
            }
            else if (choice == "3")
            {
                Console.WriteLine("three");
            }
            else if (!isDigit)
            {
                Console.Write("Numbers Only: ");
                choice = Console.ReadLine();
            }
            else
            {
                Console.Write("Invalid number: ");
                choice = Console.ReadLine();
                isDigit = false; // while this choice is a digit, it is not a valid option. setting isDigit as false causes the do/while to repeat without having to throw a second bool or other condition into the mix.
            }
        }
        while (!isDigit);
    }

}