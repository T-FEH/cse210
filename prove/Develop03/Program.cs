using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] arg)
    {
        // create a library for scriptures
        List<Scripture> library = new List<Scripture>();

        // The reference of the scripture
        string reference; 
        ScriptureReference parsedReference = new ScriptureReference("Joshua 4:4-6");
        if (parsedReference.EndVerse == null) 
        {
            reference = $"{parsedReference.Book} {parsedReference.Chapter}:{parsedReference.StartVerse}";
        }
        else
        {
            reference = $"{parsedReference.Book} {parsedReference.Chapter}:{parsedReference.StartVerse}-{parsedReference.EndVerse}";
        }

        // string reference = "Joshua 4:4-6";
        Scripture scripture = new Scripture(reference, "Then Joshua called the twelve men, whom he had prepared of the children of Israel, out of every tribe a man: And Joshua said unto them, Pass over before the ark of the Lord your God into the midst of Jordan, and take you up every man of you a stone upon his shoulder, according unto the number of the tribes of the children of Israel: That this may be a sign among you, that when your children ask their fathers in time to come, saying, What mean ye by these stones?");
           
           // Displays the original scripture
           DisplayScripture(scripture); 

            do 
            {
                 Console.WriteLine("Press Enter to hide words or type 'quit' to end:");
                 string input = Console.ReadLine() ?? "";

            // Ends the program if the user types 'quit'     
            if (input.ToLower() == "quit") 
            {
                break;
            }

            string newString = HideRandomWords(scripture);
            Scripture scriptureWithUnderscores = new Scripture(reference, newString);
            DisplayScripture(scriptureWithUnderscores);
        } while (!scripture.AllWordsHidden);
    }
    // Displays the scripture with underscores
    static void DisplayScripture(Scripture scripture) 
    {

        Console.WriteLine($"{scripture.Reference}  {scripture.Text}"); 
    }

    static string HideRandomWords(Scripture scripture)
    {
        Random random = new Random();
        List<string> wordsToHide = scripture.Words.Where(word => !word.IsHidden).Select(word => word.Text).ToList();

        // Stores the new string with underscores
        string newString = ""; 

        if (wordsToHide.Count > 1)
        {
            int randomIndex1 = random.Next(wordsToHide.Count);
            int randomIndex2;

            do
            {
                randomIndex2 = random.Next(wordsToHide.Count);
            } while (randomIndex2 == randomIndex1);

            string wordToHide1 = wordsToHide[randomIndex1];
            string wordToHide2 = wordsToHide[randomIndex2];

            // Hides the words
            foreach (Word word in scripture.Words) 
            {
                if (word.Text == wordToHide1 || word.Text == wordToHide2) 
                {
                    string underscores = ReplaceWithUnderscore(word.Text); 
                    word.Text = underscores;
                    word.Hide();
                }

                // Concatenates the new string
                newString += word.Text + " "; 
            }
        }
        else
        {
            scripture.HideAllWords();
        }
        return newString;
    }

    static string ReplaceWithUnderscore(string word)
    {
        // Replaces the word with underscores
        char[] underscores = new char[word.Length];
        for (int i = 0; i < word.Length; i++)
        {
            underscores[i] = '_';
        }

        return new string(underscores);
    }
}

class Scripture
{
    public string Reference { get; private set; }
    public string Text { get; private set; }
    public List<Word> Words { get; private set; }

    public bool AllWordsHidden => Words.All(word => word.IsHidden);

    public Scripture(string reference, string text)
    {
        Reference = reference;
        Text = text;
        Words = InitializeWords();
    }

    private List<Word> InitializeWords()
    {
        // Split the text into words
        string[] wordArray = Text.Split(' ');
        return wordArray.Select(wordText => new Word(wordText)).ToList();
    }

    public void HideAllWords()
    {
        foreach (Word word in Words)
        {
            word.Hide();
        }
    }
}

class ScriptureReference
{
    public string Book { get; private set; } = "";
    public int Chapter { get; private set; }
    public int? StartVerse { get; private set; }
    public int? EndVerse { get; private set; }

    public ScriptureReference(string reference)
    {
        ParseReference(reference);
    }

    private void ParseReference(string reference)
    {
        // Split the reference into parts
        string[] parts = reference.Split(' ');

        // Assuming the reference format is "Book Chapter:StartVerse-EndVerse"
        if (parts.Length >= 2)
        {
            Book = parts[0];

            // Parse Chapter
            if (int.TryParse(parts[1].Split(':')[0], out int chapter))
            {
                Chapter = chapter;
            }

            // Parse StartVerse and EndVerse if available
            if (parts[1].Contains(':'))
            {
                string[] verseParts = parts[1].Split(':')[1].Split('-');

                if (int.TryParse(verseParts[0], out int startVerse))
                {
                    StartVerse = startVerse;
                }

                if (verseParts.Length == 2 && int.TryParse(verseParts[1], out int endVerse))
                {
                    EndVerse = endVerse;
                }
            }
        }
    }

}

class Word
{
    public string Text { get; set; }
    public bool IsHidden { get; private set; }

    public Word(string text)
    {
        Text = text;
        IsHidden = false;
    }

    public void Hide()
    {
        IsHidden = true;
    }
}