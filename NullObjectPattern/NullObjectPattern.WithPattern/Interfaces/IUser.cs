namespace NullObjectPattern.WithPattern.Interfaces;

public interface IUser
{
    short Id { get; }
    string Name { get; }
    RoleEnum Role { get; }

    bool HasAccess();
}