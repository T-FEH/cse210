using System;

class Entry
{
    public string Response { get; }
    public string Prompt { get; }
    public DateTime Date { get; }

    public Entry(string response, string prompt, DateTime date)
    {
        Response = response;
        Prompt = prompt;
        Date = date;
    }
}