namespace BuilderPattern.WithPattern;

public class Address : IAddress
{
    public string Street { get; private set; }

    public string Zip { get; private set; }

    private Address()
    {
    }

    public class AddressBuilder
    {
        private readonly Address _address;

        public AddressBuilder()
        {
            _address = new Address();
        }

        public AddressBuilder WithStreet(string street)
        {
            _address.Street = street;
            return this;
        }
        
        public AddressBuilder WithZip(string zip)
        {
            _address.Zip = zip;
            return this;
        }
        
        public Address Build()
        {
            return _address;
        }
    }
}