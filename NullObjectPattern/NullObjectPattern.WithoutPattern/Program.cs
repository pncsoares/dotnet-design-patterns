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
userService.Print(3);