using FactoryMethodPattern.WithPattern.Interfaces;

namespace FactoryMethodPattern.WithPattern;

/// <summary>
/// Concrete Product
/// </summary>
public class Dog : IAnimal
{
    public void MakeSound()
    {
        Console.WriteLine("Au Au");
    }
}