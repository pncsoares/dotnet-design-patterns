namespace DecoratorPattern.WithPattern;

/// <summary>
/// Concrete component
/// </summary>
public class PlainPizza : IPizza
{
    public PlainPizza()
    {
        Console.WriteLine("Adding dough");
    }
    
    public string GetDescription()
    {
        return "Thin dough";
    }

    public double GetCost()
    {
        return 8.00;
    }
}