class Mammal : Animal
{
    public string FurColor { get; set; }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} the mammal makes a sound");
    }

    public void GiveBirth()
    {
        Console.WriteLine($"{Name} the mammal is giving birth.");
    }
}