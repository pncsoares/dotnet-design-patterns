using BuilderPattern.WithoutPattern;

var address = new Address("Rua com passeios e sem passadeiras", "3880");
var user = new User("Nel Chapeiro", 47, address);
        
Console.WriteLine(user.Print());