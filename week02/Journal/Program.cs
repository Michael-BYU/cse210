using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime theCurrentDate = DateTime.Now;
        
        Entry date = new Entry();
        date._date = theCurrentDate.ToShortDateString();

        Entry prompt1 = new Entry();
        prompt1._promptText = "Who was the most interesting person I interacted with today?";
        Entry prompt2 = new Entry();
        prompt2._promptText = "What was the best part of my day?";
        Entry prompt3 = new Entry();
        prompt3._promptText = "How did I see the hand of the Lord in my life today?";
        Entry prompt4 = new Entry();
        prompt4._promptText = "What was the strongest emotion I felt today?";
        Entry prompt5 = new Entry();
        prompt5._promptText = "If I had one thing I could do over today, what would it be?";



        Entry entry = new Entry();
        entry.Display();
    }
}