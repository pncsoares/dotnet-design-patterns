# Code using null object design pattern

We start creating an interface named `IUser.cs`

```csharp
namespace NullObjectPattern.WithPattern.Interfaces;

public interface IUser
{
    short Id { get; }
    string Name { get; }
    RoleEnum Role { get; }

    bool HasAccess();
}
```

Then we extend the interface in the existing class `User.cs`

Then we create a new class named `NullUser.cs`

```csharp
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
```

And then we remove most of the business logic in the `Print` method, add a null object validation in the `Get` method.

The `UserService.cs` class becomes like this:

```csharp
using System.Text;
using NullObjectPattern.WithPattern.Interfaces;

namespace NullObjectPattern.WithPattern.Services;

public class UserService
{
    private readonly IEnumerable<User> _users;

    public UserService(IEnumerable<User> users)
    {
        _users = users;
    }

    public void Print(int id)
    {
        var stringBuilder = new StringBuilder();
        
        var user = Get(id);
        stringBuilder.Append($"Hello {user.Name}, ");

        var accessMessage = user.HasAccess() ? "you have access!" : "you are not allowed here!";
        stringBuilder.Append(accessMessage);
        
        Console.WriteLine(stringBuilder);
    }

    private IUser Get(int id)
    {
        var user = _users.FirstOrDefault(f => f.Id == id);

        if (user == null)
        {
            return new NullUser();
        }

        return user;
    }
}
```

Now, if we run the application, everything works ✅ and of course, the non existing user is contextualized as a Guest:

```
Hello Bob, you have access!

Hello Angela, you are not allowed here!

Hello Guest, you are not allowed here!
```