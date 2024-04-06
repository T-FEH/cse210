class Lion : Mammal
{
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} the lion roars");
    }

    public void GiveBirth()
    {
        Console.WriteLine($"{Name} the lion is giving birth.");
    }
}