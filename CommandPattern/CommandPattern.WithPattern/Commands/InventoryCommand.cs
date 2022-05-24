using CommandPattern.WithPattern.Interfaces;

namespace CommandPattern.WithPattern.Commands;

public class InventoryCommand : ICommand
{
    private readonly IProxy<Inventory> _inventoryProxy;

    public InventoryCommand(IProxy<Inventory> inventoryProxy)
    {
        _inventoryProxy = inventoryProxy;
    }
    
    public bool Execute(IMessage message)
    {
        return _inventoryProxy.Create((Inventory)message);
    }

    public bool Rollback(IMessage message)
    {
        return _inventoryProxy.Delete((Inventory)message);
    }
}