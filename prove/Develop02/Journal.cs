using System;
using System.Collections.Generic;
using System.IO;
using System.Linq; //This provides classes and extensions for LINQ.
using System.Globalization; //This provides classes and extensions for working with dates and times.

class Journal
{
    public List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }

    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine($"Date: {entry.Date}");
            Console.WriteLine($"Prompt: {entry.Prompt}");
            Console.WriteLine($"Response: {entry.Response}");
            Console.WriteLine();
        }
    }

    public void SaveToFile(string fileName)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (var entry in entries)
                {
                    writer.WriteLine($"{entry.Date} | {entry.Prompt} | {entry.Response}");
                }
            }
            Console.WriteLine("Journal saved successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving journal to file: {ex.Message}");
        }
    }

    public void LoadFromFile(string fileName)
    {
        try
        {
            // Clear existing entries before loading from file
            entries.Clear(); 

            using (StreamReader reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    string[] entryData = reader.ReadLine().Split('|');
                    DateTime date = DateTime.Parse(entryData[0].Trim());
                    string prompt = entryData[1].Trim();
                    string response = entryData[2].Trim();

                    Entry loadedEntry = new Entry(response, prompt, date);
                    entries.Add(loadedEntry);
                }
            }
            Console.WriteLine("Journal loaded successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading journal from file: {ex.Message}");
        }
    }
    // Save entries to CSV file
     public void SaveToCsv(string fileName)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                // Write header
                writer.WriteLine("Date,Prompt,Response");

                // Write entries
                foreach (var entry in entries)
                {
                    // Escape any commas in prompt or response
                    writer.WriteLine($"{FormatCsvField(entry.Date.ToString("yyyy-MM-dd HH:mm:ss"))},{FormatCsvField(entry.Prompt)},{FormatCsvField(entry.Response)}");
                }
            }
            Console.WriteLine("Journal saved successfully as CSV!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving journal to CSV: {ex.Message}");
        }
    }

    // Load entries from CSV file
    public void LoadFromCsv(string fileName)
    {
        try
        {
            entries.Clear(); // Clear existing entries before loading from CSV

            using (StreamReader reader = new StreamReader(fileName))
            {
                // Skip header
                reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    string[] entryData = reader.ReadLine().Split(',');

                    // Ensure proper CSV formatting
                    DateTime date = DateTime.ParseExact(entryData[0], "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
                    string prompt = ParseCsvField(entryData[1]);
                    string response = ParseCsvField(entryData[2]);

                    Entry loadedEntry = new Entry(response, prompt, date);
                    entries.Add(loadedEntry);
                }
            }
            Console.WriteLine("Journal loaded successfully from CSV!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading journal from CSV: {ex.Message}");
        }
    }

    // Helper method to format a CSV field for writing
    public string FormatCsvField(string field)
    {
        if (field.Contains(",") || field.Contains("\"") || field.Contains("\n"))
        {
            // Escape any quotes or newlines
            return $"\"{field.Replace("\"", "\"\"")}\"";
        }
        return field;
    }

    // Helper method to parse a CSV field for reading
    public string ParseCsvField(string field)
    {
        if (field.StartsWith("\"") && field.EndsWith("\""))
        {
            // Unescape any quotes
            return field.Substring(1, field.Length - 2).Replace("\"\"", "\"");
        }
        return field;
    }
}