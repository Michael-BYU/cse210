using System;

public class PromptGenerator
{
    public List<Entry> _prompts = new List<Entry>();

    public string GetRandomPrompt()

    {
        Random random = new Random();
        int randomIndexNumber = random.Next(_prompts.Count);
        Console.WriteLine(_prompts[randomIndexNumber]);

        foreach (Entry prompt in _prompts)
        {
            prompt.Display();
        }

        return "";
    }
}