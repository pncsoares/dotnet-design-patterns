using System.Text;

namespace BuilderPattern.WithoutPattern;

public class User
{
    private readonly string _name;
    private readonly int _age;
    private readonly Address? _address;

    public User(string name, int age, Address? address)
    {
        _name = name;
        _age = age;
        _address = address;
    }

    public string Print()
    {
        var stringBuilder = new StringBuilder();
        stringBuilder.Append($"{_name} has {_age} years old");
        
        if (_address != null)
        {
            stringBuilder.Append($" and lives in {_address.Print()}");
        }

        return stringBuilder.ToString();
    }
}
