using FactoryMethodPattern.WithoutPattern.Interfaces;

namespace FactoryMethodPattern.WithoutPattern;

public class Dog : IAnimal
{
    public void MakeSound()
    {
        Console.WriteLine("Au Au");
    }
}