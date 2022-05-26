using NullObjectPattern.WithPattern.Interfaces;

namespace NullObjectPattern.WithPattern;

public class NullUser : IUser
{
    public short Id { get; }
    public string Name { get; }
    public RoleEnum Role { get; }
    
    public NullUser()
    {
        Id = -1;
        Name = "Guest";
        Role = RoleEnum.Guest;
    }
    
    public bool HasAccess() => false;
}