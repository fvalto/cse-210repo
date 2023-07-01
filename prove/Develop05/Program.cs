using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        bool keepRunning = true;
        Game game = new Game();

        while (keepRunning)
        {
            Console.WriteLine();
            Console.WriteLine($"You have {game.GetTotalPoints()} points.\n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create Goals");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choise from the menu: ");
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                game.CreateGoal();
            }
            else if (userInput == "2")
            {
                game.DisplayGoalList();
            }
            else if (userInput == "3")
            {
                game.SaveFile();
            }
            else if (userInput == "4")
            {
                game.LoadFile();
            }
            else if (userInput == "5")
            {
                game.RecordEvent();
            }
            else if (userInput == "6")
            {
                keepRunning = false;
            }
            else
            {
                Console.WriteLine("Please select a valid option");
            }
        }
    }
}