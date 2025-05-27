using System;

class Scripture
{
    private Reference _reference;

    private List<Word> words = new List<Word>
    {
        
    };

    public Scripture(string text, Reference reference)
    {
        _reference = reference;
    }

    public void HideRandomWords(int numberToHide)
    {

    }

    public string GetDisplayText()
    {
        string text = $"***text here***{words}\n {_reference}";
        return text;
    }

    public bool IsCompletelyHidden()
    {
        return false;
    }
}