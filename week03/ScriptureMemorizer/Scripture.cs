using System;
using System.Reflection.Metadata.Ecma335;

class Scripture
{
    private Word[] _words;
    private Reference _reference;
    private string _verse;

    public Scripture(Reference reference, string verse)
    {
        _reference = reference;
        _verse = verse;
        string[] verseWords = verse.Split(' ');
        _words = new Word[verseWords.Length];
        for (int i = 0; i < verseWords.Length; i++)
        {
            _words[i] = new Word(verseWords[i]);
        }
    }
    public string GetScripture()
    {
        string verse = "";
        string chapter = _reference.GetDisplayReference();
        for (int i = 0; i < _words.Length; i++)
        {
            verse += _words[i].GetDisplayText() + " ";
        }

        string scripture = $"{chapter} {verse}";

        return scripture;

    }

    public void HideScripture()
    {
        Random randomGenerator = new Random();
        int blank = randomGenerator.Next(0, _words.Length);

        _words[blank].Hide();

    }

    public bool AllWordsHidden()
{
    for (int i = 0; i < _words.Length; i++)
    {
        string notHidden = _words[i].GetDisplayText();
        if (notHidden != new string('_', wordText.Length))
        {
            return false; 
        }
    }
    return true; 
}
}