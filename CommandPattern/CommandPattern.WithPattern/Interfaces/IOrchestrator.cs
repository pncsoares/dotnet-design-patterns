namespace CommandPattern.WithPattern.Interfaces;

public interface IOrchestrator
{
    bool CreateOrder(Order order);
}