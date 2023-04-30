using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int num;
        List<int> numbers = new List<int>();

        do
        {
            Console.Write("Enter number: ");
            num = int.Parse(Console.ReadLine());
            
            if (num != 0)
            {
                numbers.Add(num);
            }
        } while (num != 0);

        int sum = 0;
        int length = numbers.Count;
        int max = 0;

        foreach (int number in numbers)
        {   
            sum += number;
            if (number > max)
            {
                max = number;
            }
        }
        
        double decSum = Convert.ToDouble(sum);
        double decLength = Convert.ToDouble(length);

        double average = decSum / decLength;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
    }
}