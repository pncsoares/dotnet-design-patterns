using CommandPattern.WithoutPattern.Interfaces;

namespace CommandPattern.WithoutPattern.Proxies;

public class OrderProxy : IProxy<Order>
{
    public bool Create(Order item)
    {
        Console.WriteLine($"Created inventory for product: {item.ProductName}");
        return true;
    }

    public bool Delete(Order item)
    {
        Console.WriteLine($"Deleted inventory for product: {item.ProductName}");
        return true;
    }
}