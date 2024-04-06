class Fish : Animal
{
    public string ScaleColor { get; set; }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} the fish makes a bubbling sound");
    }

    public void Swim()
    {
        Console.WriteLine($"{Name} the fish is swimming.");
    }
}