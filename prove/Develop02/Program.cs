using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        
        bool loop = true;
        while (loop)
        {
            Console.WriteLine("1. Write an entry.");
            Console.WriteLine("2. Display all entries.");
            Console.WriteLine("3. Load entries from a file.");
            Console.WriteLine("4. Save entries to a file.");
            Console.WriteLine("5. Exit.");
            Console.Write("Please choose an option: ");
            string userInput = Console.ReadLine();
            int choose = int.Parse(userInput);
            
            if (choose == 1)
            {
                journal.Write();
            }
            else if (choose == 2)
            {
                journal.Display();
            }
            else if (choose == 3)
            {
                journal.LoadFile();
            }
            else if (choose == 4)
            {
                journal.SaveFile();
            }
            else if (choose == 5)
            {
                Console.WriteLine("Thanks for using this program.");
                loop = false;
            }
        }
    }
}