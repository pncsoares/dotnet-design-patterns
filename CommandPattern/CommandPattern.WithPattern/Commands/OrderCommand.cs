using CommandPattern.WithPattern.Interfaces;

namespace CommandPattern.WithPattern.Commands;

public class OrderCommand : ICommand
{
    private readonly IProxy<Order> _orderProxy;

    public OrderCommand(IProxy<Order> orderProxy)
    {
        _orderProxy = orderProxy;
    }
    
    public bool Execute(IMessage message)
    {
        return _orderProxy.Create((Order)message);
    }

    public bool Rollback(IMessage message)
    {
        return _orderProxy.Delete((Order)message);
    }
}