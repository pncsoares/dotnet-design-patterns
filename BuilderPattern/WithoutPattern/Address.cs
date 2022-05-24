namespace BuilderPattern.WithoutPattern;

public class Address
{
    private readonly string _street;
    private readonly string _zip;

    public Address(string street, string zip)
    {
        _street = street;
        _zip = zip;
    }
}