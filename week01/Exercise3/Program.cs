using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);

        int answer = 0;

        while (answer != number)
        {
            Console.WriteLine("Guess my magic number!");
            answer = int.Parse(Console.ReadLine());

            if (answer > number)
            {
                Console.WriteLine("Too high");
            }

            else if (answer < number)
            {
                Console.WriteLine("Too low");
            }

            else
            {
                Console.WriteLine("That's right!");
            }
        }
    }
}