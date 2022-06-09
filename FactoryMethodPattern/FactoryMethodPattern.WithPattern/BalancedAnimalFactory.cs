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
                return new Cat();
            
            case 1:
                IncrementCounter();
                return new Dog();
            
            case 2:
                ResetCounter();
                return new Duck();
        }

        throw new InvalidOperationException();
    }

    private void IncrementCounter()
    {
        _counter++;
    }
    
    private void ResetCounter()
    {
        _counter = 0;
    }
}