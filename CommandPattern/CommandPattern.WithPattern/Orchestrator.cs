using CommandPattern.WithPattern.Interfaces;

namespace CommandPattern.WithPattern;

public class Orchestrator : IOrchestrator
{
    private readonly ICommand _orderCommand;
    private readonly ICommand _inventoryCommand;
    
    public Orchestrator(ICommand orderCommand, ICommand inventoryCommand)
    {
        _orderCommand = orderCommand;
        _inventoryCommand = inventoryCommand;
    }
    
    public bool CreateOrder(Order order)
    {
        var orderExecution = _orderCommand.Execute(order);

        if (!orderExecution)
        {
            return false;
        }

        var inventoryExecution = _inventoryCommand.Execute(new Inventory(order.ProductName, order.Quantity));

        if (inventoryExecution)
        {
            return true;
        }

        _orderCommand.Rollback(order);
        return false;
    }
}