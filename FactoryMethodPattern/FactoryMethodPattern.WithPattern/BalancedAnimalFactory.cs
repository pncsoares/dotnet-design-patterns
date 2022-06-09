using FactoryMethodPattern.WithPattern.Interfaces;

namespace FactoryMethodPattern.WithPattern;

/// <summary>
/// Concrete Creator
/// </summary>
public class BalancedAnimalFactory : IAnimalFactory
{
    private short _counter;

    /// <summary>
    /// Creates a new IAnimal but in a balanced way (it has state)
    /// </summary>
    /// <returns></returns>
    /// <exception cref="InvalidOperationException"></exception>
    public IAnimal CreateAnimal()
    {
        switch (_counter)
        {
            case 0:
                IncrementCounter();
                return CreateCat;
            
            case 1:
                IncrementCounter();
                return CreateDog;
            
            case 2:
                ResetCounter();
                return CreateDuck;
        }

        throw new InvalidOperationException();
    }

    private static Cat CreateCat => new Cat();
    
    private static Dog CreateDog => new Dog();
    
    private static Duck CreateDuck => new Duck();

    private void IncrementCounter()
    {
        _counter++;
    }
    
    private void ResetCounter()
    {
        _counter = 0;
    }
}