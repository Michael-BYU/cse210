using System;
using System.IO;

public class Journal
{
    public List<Entry> _entries;

    public void AddEntry(Entry newEntry)
    {

    }

    public void DisplayAll()
    {
        string _menuSelect = "";

        while (_menuSelect != "5. Quit")
        {
            List<string> _menu = new List<string>(){
            "1. Write",
            "2. Display",
            "3. Load",
            "4. Save",
            "5. Quit"};
        }
    }

    public void SaveToFile(string file)
    {
        // save the prompt that displayed
        // change this to user input
        string filename = "myFile.txt";
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine("");
        }
    }

    public void LoadFromFile(string file)
    {
        // change this to user input - prompt for file name
        // use readlines from WA
        string filename = "myFile.txt"; 
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine("");
        }
    }
}