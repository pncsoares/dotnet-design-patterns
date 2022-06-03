namespace DecoratorPattern.WithPattern;

/// <summary>
/// Concrete decorator
/// </summary>
public class TomatoSauceDecorator : ToppingDecorator
{
    public TomatoSauceDecorator(IPizza pizza) : base(pizza)
    {
        Console.WriteLine("Adding tomato sauce");
    }

    public override string GetDescription()
    {
        return $"{Pizza.GetDescription()}, Tomato Sauce";
    }

    public override double GetCost()
    {
        return Pizza.GetCost() + .85;
    }
}