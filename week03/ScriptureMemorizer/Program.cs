using System;

class Program
{
    static void Main(string[] args)
    {
        string user = "";
        Console.WriteLine("Get ready to learn!");
        Console.WriteLine("Enter a scripture reference. Then, hit enter.");
        Reference userReference = SeekReference();
        Console.WriteLine("Great, now enter the verse text, and press enter. Press Shift + Enter for a new line.");
        string verse = Console.ReadLine();
        Scripture newScripture = new Scripture(userReference, verse);
        Console.WriteLine(newScripture.GetScripture());
        while (user != "quit" && user != "Quit" && !newScripture.AllWordsHidden())
        {

            newScripture.HideScripture();
            Console.WriteLine(newScripture.GetScripture());
            if (user != "quit" && user != "Quit")
            {
                Console.WriteLine("Press Enter to Continue or quit to Exit.");
                user = Console.ReadLine();
            }

        }
    }
    public static Reference SeekReference()
    {

        string reference = Console.ReadLine();
        string[] parts = reference.Split(' ', ':');

        Reference newReference = new Reference(parts[0], int.Parse(parts[1]), parts[2]);

        return newReference;
    }
    
}