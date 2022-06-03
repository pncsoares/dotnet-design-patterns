namespace DecoratorPattern.WithPattern;

/// <summary>
/// Base decorator
/// </summary>
public abstract class ToppingDecorator : IPizza
{
    protected readonly IPizza Pizza;

    protected ToppingDecorator(IPizza pizza)
    {
        Pizza = pizza;
    }

    public virtual string GetDescription()
    {
        return Pizza.GetDescription();
    }

    public virtual double GetCost()
    {
        return Pizza.GetCost();
    }

    public void Print()
    { 
        Console.WriteLine($"\nIngredients: {GetDescription()}");
        Console.WriteLine($"Cost: {GetCost()}");
    }
}