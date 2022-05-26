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