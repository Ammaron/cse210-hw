using System;
using System.Security.Cryptography;
using System.IO;
using System.Collections.Generic;
class Program
{
static void Main(string[] args)
    {
        DisplayWelcome();
        List<Entry> journal = new List<Entry>();
        string filename = "";

        string option = "";
        while (option != "5" && option != "Quit" && option != "quit")
        {
            option = DisplayOptions();
            string prompt = "";
            string response = "";

            if (option == "1" || option == "Write" || option == "write")
            {
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                Random randomGenerator = new Random();
                int question = randomGenerator.Next(1, 5);
                if (question == 1)
                {
                    prompt = "Who was the most interesting person I interacted with today";
                    Console.WriteLine(prompt);
                    response = Console.ReadLine();

                }
                else if (question == 2)
                {
                    prompt = "What was the best part of my day?";
                    Console.WriteLine(prompt);
                    response = Console.ReadLine();
                }
                else if (question == 3)
                {
                    prompt = "How did I see the hand of the Lord in my life today?";
                    Console.WriteLine(prompt);
                    response = Console.ReadLine();
                }
                else if (question == 4)
                {
                    prompt = "What was the strongest emotion I felt today?";
                    Console.WriteLine(prompt);
                    response = Console.ReadLine();
                }
                else if (question == 5)
                {
                    prompt = "If I had one thing I could do over today, what would it be?";
                    Console.WriteLine(prompt);
                    response = Console.ReadLine();
                }
                Entry newEntry = new Entry(prompt, response, dateText);
                journal.Add(newEntry);
            }

            else if (option == "2" || option == "Display" || option == "display")
            {
                foreach (Entry entry in journal)
                {
                    entry.DisplayEntry();
                }
            }

            else if (option == "3" || option == "Load" || option == "load")
            {
                Console.WriteLine("What is the file name?");
                string userInput = Console.ReadLine();
                filename = $"/home/kirby/Documents/Github/cse210-hw/week02/Journal/{userInput}";

                Journal journalManager = new Journal();
                journal = journalManager.LoadJournal(filename);
                Console.WriteLine($"Loaded {journal.Count} entries");

            }

            else if (option == "4" || option == "Save" || option == "save")
            {
                Console.WriteLine("What is the file name?");
                string userInput = Console.ReadLine();
                filename = $"/home/kirby/Documents/Github/cse210-hw/week02/Journal/{userInput}";

                Journal journalManager = new Journal();
                journalManager.SaveJournal(journal, filename);
            }
            else if (option == "5" || option == "Quit" || option == "quit")
            {
                Console.WriteLine("Don't forget to check back in tomorrow!");
            }
            
            
        }
    }
    
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Journal Program!");
    }
    
    static string DisplayOptions() 
    {
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.WriteLine("What would you like to do? ");
        string option = Console.ReadLine();
        return option;
    }        
}