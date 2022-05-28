using StrategyPattern.WithPattern.Interfaces;

namespace StrategyPattern.WithPattern.Strategies.Eat;

public class VegetarianEatStrategy : IEatStrategy
{
    public void Eat()
    {
        Console.WriteLine("I eat a mix of fruits, vegetables, grains, healthy fats and proteins");
    }
}