namespace BuilderPattern.WithPattern;

public class User : IUser
{
    public string Name { get; private set; }

    public int Age { get; private set; }

    public Address Address { get; private set; }

    private User()
    {
    }

    public class UserBuilder
    {
        private readonly User _user;

        public UserBuilder()
        {
            _user = new User();
        }

        public UserBuilder WithName(string name)
        {
            _user.Name = name;
            return this;
        }

        public UserBuilder WithAge(int age)
        {
            _user.Age = age;
            return this;
        }

        public UserBuilder WithAddress(Address address)
        {
            _user.Address = address;
            return this;
        }

        public User Build()
        {
            return _user;
        }
    }
}