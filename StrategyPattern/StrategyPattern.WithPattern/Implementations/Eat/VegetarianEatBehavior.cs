using StrategyPattern.WithPattern.Interfaces;

namespace StrategyPattern.WithPattern.Implementations.Eat;

public class VegetarianEatBehavior : IEatBehavior
{
    public void Eat()
    {
        Console.WriteLine("I eat a mix of fruits, vegetables, grains, healthy fats and proteins");
    }
}