class Snake : Reptile
{
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} the snake hisses menacingly");
    }
}