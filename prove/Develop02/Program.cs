using System;
using System.IO; 
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");

        Journal journal = new Journal();

        string askUser()
        {
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("Please select a choice: ");

            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                    Entry wEntry = new Entry();
                    wEntry.WriteEntry(journal);
                    askUser();
                    break;
                case "2":
                    Entry displayEntry = new Entry();
                    displayEntry.DisplayEntries(journal);
                    askUser();
                    break;
                case "3":
                    Console.Write("Enter the file name .extention: ");
                    string nameToLoad = Console.ReadLine();
                    Journal loadFile = new Journal();
                    loadFile.LoadFile(nameToLoad, journal);
                    askUser();
                    break;
                case "4":
                    Console.Write("Enter the file name .extention: ");
                    string nameToSave = Console.ReadLine();
                    Journal saveFile = new Journal();
                    saveFile.SaveFile(nameToSave, journal);
                    Console.WriteLine("FILE SAVED!");
                    askUser();
                    break;
                case "5":
                    break;
                default:
                    askUser();
                    break;
            }

            return userChoice;
        }
        
        askUser();
    }
 }