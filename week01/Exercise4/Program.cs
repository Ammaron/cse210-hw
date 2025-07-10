using System;

class Program
{
    static void Main(string[] args)
    {
        bool end = false;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        do
        {
            Console.WriteLine("Enter number: ");
            string numberString = Console.ReadLine();
            int number = int.Parse(numberString);

            if (number == 0)
            {
                end = true;
            }
            else
            {
                numbers.Add(number);
            }
        } while (end != true);
        for (int i = 0; i < numbers.Count; i++)
        {
            Console.WriteLine(numbers[i]);
        }
        int sum = numbers.Sum();
        int average = sum / numbers.Count;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
    }
}