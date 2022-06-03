namespace DecoratorPattern.WithPattern;

/// <summary>
/// Concrete decorator
/// </summary>
public class MozzarellaDecorator : ToppingDecorator
{
    public MozzarellaDecorator(IPizza pizza) : base(pizza)
    {
        Console.WriteLine("Adding mozzarella");
    }

    public override string GetDescription()
    {
        return $"{Pizza.GetDescription()}, Mozzarella";
}

    public override double GetCost()
    {
        return Pizza.GetCost() + 1;
    }
}