using System;
using System.Collections.Generic;

class Zoo
{
    private List<Animal> animals;

    public Zoo()
    {
        animals = new List<Animal>();
    }

    public void AddAnimal(Animal animal)
    {
        animals.Add(animal);
    }

    public void MakeAllSounds()
    {
        foreach (var animal in animals)
        {
            animal.MakeSound();
        }
    }

    public IEnumerable<Animal> GetAnimals()
    {
        return animals;
    }
}