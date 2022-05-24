using BuilderPattern.WithPattern;

var address = new Address.AddressBuilder()
    .WithStreet("Rua com passeios e sem passadeiras")
    .WithZip("3880")
    .Build();
        
var user = new User.UserBuilder()
    .WithName("Nel Chapeiro")
    .WithAge(47)
    .WithAddress(address)
    .Build();
        
Console.WriteLine(user.Print());