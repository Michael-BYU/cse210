using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string percentage = Console.ReadLine();
        int percent = int.Parse(percentage);
        string letter = "";

// To determine grade letter value

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"{letter}");

// To determine if student passed
        if (percent >= 70)
        {
            Console.WriteLine("Congratulations! You pass!");
        }
        else
        {
            Console.Write("You fail. Better luck next time!");
        }
    }
}