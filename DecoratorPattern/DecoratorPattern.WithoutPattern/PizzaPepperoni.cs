namespace DecoratorPattern.WithoutPattern;

public class PizzaPepperoni
{
    public PizzaPepperoni()
    {
        Console.WriteLine("Creating pizza Pepperoni");    
    }
    
    public string GetDescription()
    {
        return "Salami, paprika, garlic, black pepper, red pepper, cayenne pepper, mustard seed and fennel seed";
    }

    public double GetCost()
    {
        return 11.50;
    }
    
    public void Print()
    { 
        Console.WriteLine($"Ingredients: {GetDescription()}");
        Console.WriteLine($"Cost: {GetCost()}");
    }
}