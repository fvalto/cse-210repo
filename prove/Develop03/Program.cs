using System;

class Program
{
    static void Main(string[] args)
    {
        string scriptureText = "Trust in the Lord with all thine heart; and lean not unto thine own understanding; In all thy ways acknowledge him, and he shall direct thy paths.";
        Scripture _scripture = new Scripture("Proverbs", 3, 5, 6, scriptureText);
        string userInput = "";
        Console.Clear();
        _scripture.DisplayReference(); _scripture.DisplayText();
        while (userInput != "quit")
        {
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            userInput = Console.ReadLine().ToLower();
            Console.Clear();
            _scripture.DisplayReference(); 
            _scripture.HideRandomWords(scriptureText);
            _scripture.DisplayText();
            if (_scripture.isCompletelyHidden()) {
                userInput = "quit";
            }
        }
    }
}