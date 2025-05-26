using System;

class Program
{
    static void Main(string[] args)
    {
        Entry prompt = new Entry();
        prompt._promptText = "prompt1";

        Entry date = new Entry();
        date._date = "date here";

        Entry entry = new Entry();
        entry.Display();
    }
}