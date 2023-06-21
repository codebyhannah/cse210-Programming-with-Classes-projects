using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<string> menuOptions = new List<string>() {"a","b","c"};
        
        Menu menu = new Menu("pick one of these", menuOptions);

        //menu.DisplayMenu();
        //menu.ChooseMenuOption();

        GoalList goals = new GoalList();

        goals.SetFilePath(@"/Users/hannah/Desktop/cse210-Programming-with-Classes-projects/prove/Develop05/txtTesting.txt");
        goals.ReadFile();

        goals.WriteFile();

        GoalList newFileGoals = new GoalList(@"/Users/hannah/Desktop/cse210-Programming-with-Classes-projects/prove/Develop05/writeText.txt");
        newFileGoals.WriteFile();

    }
}