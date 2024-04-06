class Reptile : Animal
{
    public string SkinType { get; set; }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} the reptile makes a hissing sound");
    }
}