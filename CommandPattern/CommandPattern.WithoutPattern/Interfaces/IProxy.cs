namespace CommandPattern.WithoutPattern.Interfaces;

public interface IProxy<T>
{
    bool Create(T item);
    bool Delete(T item);
}