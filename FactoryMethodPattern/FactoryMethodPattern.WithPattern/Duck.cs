using FactoryMethodPattern.WithPattern.Interfaces;

namespace FactoryMethodPattern.WithPattern;

/// <summary>
/// Concrete Product
/// </summary>
public class Duck : IAnimal
{
    public void MakeSound()
    {
        Console.WriteLine("Quack Quack");
    }
}