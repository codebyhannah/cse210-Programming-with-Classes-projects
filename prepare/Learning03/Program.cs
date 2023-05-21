using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        // Empty init
        Fraction fractionNum1 = new Fraction();
        Console.WriteLine(fractionNum1.GetFractionString());
        // Whole number init
        Fraction fractionNum2 = new Fraction(6);
        Console.WriteLine(fractionNum2.GetFractionString());
        // Top and bottom init
        Fraction fractionNum3 = new Fraction(6, 7);
        Console.WriteLine(fractionNum3.GetFractionString());

        // Get and set bottom
        Console.WriteLine(fractionNum3.GetBottom());
        fractionNum3.SetBottom(6);
        Console.WriteLine(fractionNum3.GetFractionString());

        // Get and set top
        Console.WriteLine(fractionNum3.GetTop());
        fractionNum3.SetTop(4);
        Console.WriteLine(fractionNum3.GetFractionString());

        // Get fraction string and get decimal value
        Fraction fractionNum4 = new Fraction(3, 4);
        Console.WriteLine(fractionNum4.GetFractionString());
        Console.WriteLine(fractionNum4.GetDecimalValue());

    }
}