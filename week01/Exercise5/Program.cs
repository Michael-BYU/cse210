using System;
using System.Formats.Asn1;
using System.Xml.XPath;

class Program
{
    static void Main(string[] args)
    {
        Welcome();

        string name = UserName();
        int number = UserNumber();
        int squaredNumber = Square(number);
        
        static void Welcome()
        {
            Console.WriteLine("Welcome!");
        }
        static string UserName()
        {
            Console.WriteLine("Enter username");
            string name = Console.ReadLine();
            return name;
        }
        static int UserNumber()
        {
            Console.WriteLine("What is your favourite number?");
            int number = int.Parse(Console.ReadLine());
            return number;
        }
        static int Square(int number)
        {
            int square = number * number;
            return square;
        }
        static void Result(string name, int square)
        {
            Console.WriteLine($"{name}, your square root is {square}");
        }
    }
}