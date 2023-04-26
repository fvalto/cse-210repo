using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int toAdd;
        int total;
        float average;
        int largest;

        do
        {
            Console.Write("Enter number: ");
            toAdd = int.Parse(Console.ReadLine());
            if (toAdd != 0)
            {
                numbers.Add(toAdd);
            }
        } while (toAdd != 0);
        
        total = numbers.Sum();
        average = (float)total/(numbers.Count);
        largest = numbers.Max();

        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}