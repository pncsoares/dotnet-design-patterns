﻿using CommandPattern.WithPattern.Interfaces;

namespace CommandPattern.WithPattern.Proxies;

public class InventoryProxy : IProxy<Inventory>
{
    public bool Create(Inventory item)
    {
        Console.WriteLine($"Created inventory for product: {item.ProductName}");
        return true;
    }

    public bool Delete(Inventory item)
    {
        Console.WriteLine($"Deleted inventory for product: {item.ProductName}");
        return true;
    }
}