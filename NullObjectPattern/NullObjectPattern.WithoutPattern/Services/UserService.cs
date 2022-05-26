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
        var name = "Guest";

        if (user != null && !string.IsNullOrWhiteSpace(user.Name))
        {
            name = user.Name;
        }

        stringBuilder.Append($"Hello {name}, ");

        var accessMessage = user != null && user.HasAccess() ? "you have access!" : "you are not allowed here!";
        stringBuilder.Append(accessMessage);
        
        Console.WriteLine(stringBuilder);
    }

    private User Get(int id)
    {
        return _users.FirstOrDefault(f => f.Id == id);
    }
}