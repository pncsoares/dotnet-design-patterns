namespace DecoratorPattern.WithPattern;

/// <summary>
/// Concrete decorator
/// </summary>
public class OnionDecorator : ToppingDecorator
{
    public OnionDecorator(IPizza pizza) : base(pizza)
    {
        Console.WriteLine("Adding onion");
    }

    public override string GetDescription()
    {
        return $"{Pizza.GetDescription()}, Onion";
    }

    public override double GetCost()
    {
        return Pizza.GetCost() + .50;
    }
}