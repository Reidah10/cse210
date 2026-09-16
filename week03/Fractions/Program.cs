using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");
        Fraction fraction1 = new Fraction();
        {
            Console.WriteLine(fraction1.GetFractionString());
        }
        Fraction fraction2 = new Fraction(6);
        {
            Console.WriteLine(fraction2.GetFractionString());
        }
        Fraction fraction3 = new Fraction(2,3);
        {
            Console.WriteLine(fraction3.GetFractionString());
        }
        Console.WriteLine(fraction3.GetTop());
        fraction3.SetTop(10);
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetBottom());
        fraction3.SetBottom(5);
        Console.WriteLine(fraction3.GetFractionString());

        Fraction fraction4 = new Fraction(3,4);
        {
            Console.WriteLine(fraction4.GetFractionString());
            Console.WriteLine(fraction4.GetDecimalValue());
        }

        Fraction fraction5 = new Fraction(1,3);
        {
            Console.WriteLine(fraction5.GetFractionString());
            Console.WriteLine(fraction5.GetDecimalValue());
        }
    }
}