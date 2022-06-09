using FactoryMethodPattern.WithPattern.Interfaces;

namespace FactoryMethodPattern.WithPattern;

/// <summary>
/// Concrete Product
/// </summary>
public class Cat : IAnimal
{
    public void MakeSound()
    {
        Console.WriteLine("Miau Miau");
    }
}