using CommandPattern.WithPattern.Interfaces;

namespace CommandPattern.WithPattern.Proxies;

public class OrderProxy : IProxy<Order>
{
    public bool Create(Order item)
    {
        Console.WriteLine($"Created order for product: {item.ProductName}");
        return true;
    }

    public bool Delete(Order item)
    {
        Console.WriteLine($"Deleted order for product: {item.ProductName}");
        return true;
    }
}