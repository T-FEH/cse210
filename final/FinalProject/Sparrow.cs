class Sparrow : Bird
{
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} the sparrow chirps happily");
    }

    public void BuildNest()
    {
        Console.WriteLine($"{Name} the sparrow is building a nest.");
    }
}