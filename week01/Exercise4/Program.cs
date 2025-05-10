using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userNumbers = -1;


        while (userNumbers != 0)
        {
            Console.WriteLine("Add a number to the list. Enter 0 to end. ");
            string userInput = Console.ReadLine();
            userNumbers = int.Parse(userInput);

            if (userNumbers != 0)
            {
                numbers.Add(userNumbers);
            }
        }
    }
}