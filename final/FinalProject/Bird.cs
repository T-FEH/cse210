class Bird : Animal
{
    public string FeatherColor { get; set; }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} the bird makes a chirping sound");
    }
}