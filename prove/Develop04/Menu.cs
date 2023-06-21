using System;

public class Menu
{
    public List<Activity> _activityList;
    public string _menuInstructions = "yolo";
    
    public Menu(List<Activity> activityList)
    {
        _activityList = new List<Activity>();
    }

    public void DisplayMenu()
    {
        Console.WriteLine(_menuInstructions);
        Console.WriteLine();
        
        for (var i = 0; i < _activityList.Count; i++)
        {
            Console.WriteLine($"-{i}- {_activityList[i]}");
        }
        
        Console.WriteLine();
    }

}