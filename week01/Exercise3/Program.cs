using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 11);
        int numberGuess = 99;
        int count = 1;
        do
        {
            Console.WriteLine("What is guess for the magic number?");
            string numberGuessString = Console.ReadLine();
            numberGuess = int.Parse(numberGuessString);

            if (numberGuess == magicNumber)
            {
                Console.WriteLine($"You got it in {count} turns!");
            }
            else if (numberGuess > magicNumber)
            {
                Console.WriteLine("Too High");
            }
            else if (numberGuess < magicNumber)
            {
                Console.WriteLine("Too Low");
            }
            else
            {
                Console.WriteLine("Not Valid");
            }
            count++;
        } while (numberGuess != magicNumber);
    }
}