using System;
using System.IO;

public class Journal
{
    public List<Entry> _entries;

    public void AddEntry(Entry newEntry)
    {
        string filename = "myFile.txt";
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine("");
        }
    }

    public void DisplayAll()
    {

    }

    public void SaveToFile(string file)
    {

    }

    public void LoadFromFile(string file)
    {
        
    }
}