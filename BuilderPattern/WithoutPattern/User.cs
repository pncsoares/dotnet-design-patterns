namespace BuilderPattern.WithoutPattern;

public class User
{
    private readonly string _name;
    private readonly int _age;
    private readonly Address _address;

    public User(string name, int age, Address address)
    {
        _name = name;
        _age = age;
        _address = address;
    }
}
