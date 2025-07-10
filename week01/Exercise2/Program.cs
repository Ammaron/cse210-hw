using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string grade = Console.ReadLine();
        int percent = int.Parse(grade);
        string letter = "A";
        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent < 90 && percent >= 80)
        {
            letter = "B";
        }
        else if (percent < 80 && percent >= 70)
        {
            letter = "C";
        }
        else if (percent < 70 && percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (percent >= 70 && letter != "A")
        {
            Console.WriteLine($"Congrats, you pass! You scored with a {letter}");
        }
        else if (letter == "A")
        {
            Console.WriteLine($"Congrats, you pass! You scored with an {letter}");
        }
        else if (letter == "F")
        {
            Console.WriteLine($"You failed with an {letter}");
        }
        else
        {
            Console.WriteLine($"You failed with a {letter}");
        }
    }
}