namespace CommandPattern.WithPattern.Interfaces;

public interface IProxy<T>
{
    bool Create(T item);
    bool Delete(T item);
}