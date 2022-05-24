namespace CommandPattern.WithPattern.Interfaces;

public interface ICommand
{
    bool Execute(IMessage message);
    bool Rollback(IMessage message);
}