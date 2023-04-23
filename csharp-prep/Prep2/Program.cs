using System;

class Program
{
    static void Main(string[] args)
    {
        //ASKING USER GRADE PERCENTAGE
        Console.Write("What is your grade percentage?: ");
        int gradePercentage = int.Parse(Console.ReadLine());
        string letter;
        Console.WriteLine();

        //SORTING GRADE LETTER
        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        //GETTING SYMBOL AFTER GRADE LETTER
        string symbol;
        int reminder = gradePercentage % 10;

        if (reminder >=  7)
        {
            symbol = "+";
        }
        else if (reminder < 3)
        {
            symbol = "-";
        }
        else
        {
            symbol = "";
        }
        letter = letter + symbol;

        //HANDLING EXCEPTIONS
        if (letter == "A+" || gradePercentage == 100)
        {
            letter = "A";
        }
        else if (letter == "F-" || letter == "F+")
        {
            letter ="F";
        }

        //PRINTING GRADE LETTER
        Console.WriteLine($"Your grade is {letter}");

        //DID YOU PASSED THE COURSE?
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course!");
        }
        else 
        {
            Console.WriteLine("Sorry, You'll have to try harder next time!");
        }
    }
}