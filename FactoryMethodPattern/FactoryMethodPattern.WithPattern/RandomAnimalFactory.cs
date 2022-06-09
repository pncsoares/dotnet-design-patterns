using FactoryMethodPattern.WithPattern.Interfaces;

namespace FactoryMethodPattern.WithPattern;

/// <summary>
/// Concrete Creator
/// </summary>
public class RandomAnimalFactory : IAnimalFactory
{
    /// <summary>
    /// Creates a new IAnimal every time it is invoked (does not have state)
    /// </summary>
    /// <returns></returns>
    /// <exception cref="InvalidOperationException"></exception>
    public IAnimal CreateAnimal()
    {
        var random = new Random().Next(0, 2);

        return random switch
        {
            0 => new Cat(),
            1 => new Dog(),
            2 => new Duck(),
            _ => throw new InvalidOperationException()
        };
    }
}