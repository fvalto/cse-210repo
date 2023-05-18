using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction firstExample = new Fraction();
        Console.WriteLine(firstExample.GetFractionString());
        Console.WriteLine(firstExample.GetDecimalValue());

        Fraction secondExample = new Fraction(5);
        Console.WriteLine(secondExample.GetFractionString());
        Console.WriteLine(secondExample.GetDecimalValue());

        Fraction thirdExample = new Fraction(3, 4);
        Console.WriteLine(thirdExample.GetFractionString());
        Console.WriteLine(thirdExample.GetDecimalValue());

        Fraction fourthExample = new Fraction(1, 3);
        Console.WriteLine(fourthExample.GetFractionString());
        Console.WriteLine(fourthExample.GetDecimalValue());
    }
}