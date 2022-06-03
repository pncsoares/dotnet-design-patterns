namespace DecoratorPattern.WithoutPattern;

public class PizzaCarbonara
{
    public PizzaCarbonara()
    {
        Console.WriteLine("Creating pizza Carbonara");
    }
    
    public string GetDescription()
    {
        return "Crisp pieces of salt bacon, mushrooms, gooey cheese and egg";
    }

    public double GetCost()
    {
        return 10.50;
    }
    
    public void Print()
    { 
        Console.WriteLine($"Ingredients: {GetDescription()}");
        Console.WriteLine($"Cost: {GetCost()}");
    }
}