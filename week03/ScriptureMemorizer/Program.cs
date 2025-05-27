using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Ephesians", 6, 12);
        Word text = new Word("For we wrestle not against flesh and blood, but against principalities, against powers, against the rulers of the darkness of this world, against spiritual wickedness in high places.");
        Scripture scripture = new Scripture("For we wrestle not against flesh and blood, but against principalities, against powers, against the rulers of the darkness of this world, against spiritual wickedness in high places.", reference);

        Console.WriteLine(scripture.GetDisplayText());
        // Console.WriteLine(reference);
        Console.WriteLine(text);
    }
}