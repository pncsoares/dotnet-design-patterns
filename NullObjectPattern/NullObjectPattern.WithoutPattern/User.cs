namespace NullObjectPattern.WithoutPattern;

public class User
{
    public short Id { get; }
    public string Name { get; }
    private RoleEnum Role { get; }
    
    public User(short id, string name, RoleEnum role)
    {
        Id = id;
        Name = name;
        Role = role;
    }

    public bool HasAccess() => Role == RoleEnum.Admin;
}