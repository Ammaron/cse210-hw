using System;
using System.IO;
using System.Collections.Generic;
public class Journal
{

    public void SaveJournal(List<Entry> journal, string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in journal)
            {

                string line = $"{entry._date} | {entry._prompt} | {entry._response}";
                outputFile.WriteLine(line);
            }
        }
    }

    public List<Entry> LoadJournal(string filename)
    {
        List<Entry> loadedEntries = new List<Entry>();
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            string date = parts[0];
            string prompt = parts[1];
            string response = parts[2];

            Entry entry = new Entry(prompt, response, date);
            loadedEntries.Add(entry);
        }
        return loadedEntries;
    }
}