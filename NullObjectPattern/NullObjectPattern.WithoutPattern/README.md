# Code without null object design pattern

## ✅ Good scenario

All works well when we write code like this:

`User.cs`

```csharp
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
```	

`UserService.cs`

```csharp
using System.Text;

namespace NullObjectPattern.WithoutPattern.Services;

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

    private User Get(int id)
    {
        return _users.FirstOrDefault(f => f.Id == id);
    }
}
```

`Program.cs`

```csharp
using NullObjectPattern.WithoutPattern;
using NullObjectPattern.WithoutPattern.Services;

var users = new List<User>
{
    new(1, "Bob", RoleEnum.Admin),
    new(2, "Angela", RoleEnum.Basic)
};

var userService = new UserService(users);
userService.Print(1);
userService.Print(2);
```

So far, so good, we initialized an array of users and passed it to the UserService and then we instructed the application to print the information about two users that exists (are not null).

If we run the code like so, the output will be the following:

```
Hello Bob, you have access!

Hello Angela, you are not allowed here!
```

## ❌ Null scenario

But what happens, when we instruct the application to print details of an user that does not exists?

`Program.cs`

```csharp
userService.Print(3);
```

Now, if we execute the code, we will see the following message in the console:

```
Hello Bob, you have access!

Hello Angela, you are not allowed here!

Unhandled exception. System.NullReferenceException: Object reference not set to an instance of an object.
   at NullObjectPattern.WithoutPattern.Services.UserService.Print(Int32 id) in C:\Repositories\Other\Personal\dotnet-design-patterns\NullObjectPattern\NullObjectPattern.WithoutPattern\Services\UserService.cs:line 19
   at Program.<Main>$(String[] args) in C:\Repositories\Other\Personal\dotnet-design-patterns\NullObjectPattern\NullObjectPattern.WithoutPattern\Program.cs:line 13
```

We need to allow any user to access the landing page but we want to contextualize it as a guest. To do that we need to add more code:

```csharp
public void Print(int id)
{
    var stringBuilder = new StringBuilder();
    
    var user = Get(id);

    // this code block was added
    var name = "Guest";

    if (user != null && !string.IsNullOrWhiteSpace(user.Name))
    {
        name = user.Name;
    }
    // this code block was added

    stringBuilder.Append($"Hello {name}, "); // this line was changed

    var accessMessage = user != null && user.HasAccess() ? "you have access!" : "you are not allowed here!";
    stringBuilder.Append(accessMessage);
    
    Console.WriteLine(stringBuilder);
}
```

And now we got the output that we wanted:

```
Hello Bob, you have access!

Hello Angela, you are not allowed here!

Hello Guest, you are not allowed here!
```

But is this the best way to handle null objects? 🤔

Well, if you need to add null object validation all over the code, the code will become a mess and if you forget one of them, you will get errors.

Also, dependency injection does not really enjoy the fact that you provide null as the default value for a component...

[📄 Code using design pattern](./NullObjectPattern.WithPattern/README.md)