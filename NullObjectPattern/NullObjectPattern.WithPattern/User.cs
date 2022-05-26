using NullObjectPattern.WithPattern.Interfaces;

namespace NullObjectPattern.WithPattern;

public class User : IUser
{
    public short Id { get; }
    public string Name { get; }
    public RoleEnum Role { get; }
    
    public User(short id, string name, RoleEnum role)
    {
        Id = id;
        Name = name;
        Role = role;
    }

    public bool HasAccess() => Role == RoleEnum.Admin;
}