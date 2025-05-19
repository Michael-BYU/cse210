using System;

public class Entry
{
    public string _date;  
    public string _promptText;
    public string _entrytext;

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Here is something to get your mind working: {_promptText}");
        Console.WriteLine($"{_entrytext}");
    }
}