class Goldfish : Fish
{
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} the goldfish makes a gentle bubbling sound");
    }

    public void Swim()
    {
        Console.WriteLine($"{Name} the goldfish is swimming.");
    }
}