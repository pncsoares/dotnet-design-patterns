namespace DecoratorPattern.WithoutPattern;

public class PizzaExtraCheese
{
    public PizzaExtraCheese()
    {
        Console.WriteLine("Creating pizza with extra Cheese");    
    }
    
    public string GetDescription()
    {
        return "Mozzarella, parmesan, fontina, cheddar, provolone, pecorino romano and ricotta";
    }

    public double GetCost()
    {
        return 11;
    }
    
    public void Print()
    { 
        Console.WriteLine($"Ingredients: {GetDescription()}");
        Console.WriteLine($"Cost: {GetCost()}");
    }
}