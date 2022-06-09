namespace FactoryMethodPattern.WithPattern.Interfaces;

/// <summary>
/// Creator
/// </summary>
public interface IAnimalFactory
{
    IAnimal CreateAnimal();
}