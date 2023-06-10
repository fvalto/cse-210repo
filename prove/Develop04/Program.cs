using System;

class Program
{
    static void Main(string[] args)
    {
        bool keepRunning = true;
        Console.Clear();

        string breathingDescription = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", breathingDescription);

        string reflectingDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";  
        ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting Activity", reflectingDescription);

        string listingDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        ListingActivity listingActivity = new ListingActivity("Listing Activity", listingDescription);


        while (keepRunning)
        {
            Console.WriteLine("Menu options:");
            Console.WriteLine(" 1. Start breathing activity.");
            Console.WriteLine(" 2. Start reflecting activity.");
            Console.WriteLine(" 3. Start listing activity.");
            Console.WriteLine(" 4. Quit.");
            Console.Write("Select a choise from the menu: ");

            string userChoise = Console.ReadLine();

            if (userChoise == "1")
            {
                breathingActivity.Run();
            }
            else if (userChoise == "2")
            {
                reflectingActivity.Run();
            }
            else if (userChoise == "3")
            {
                listingActivity.Run();
            }
            else if (userChoise == "4")
            {
                Console.WriteLine("\nThanks for using.");
                keepRunning = false;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Please enter a valid choise...\n");
            }

        }
    }
}