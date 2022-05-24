# Builder Design Pattern

Separate the construction of a complex object from its representation, allowing the same construction process to create various representations.

💡 Useful when you need to create objects that have many different working parts that need to all come together to create one single object.

## Advantages

- Allows you to vary a product's internal representation
- Encapsulates code for construction and representation
- Provides control over steps of construction process

## Disadvantages

- It does create more code
- Too many constructors to maintain
- Error prone because many fields has same type

# See the code result

Open terminal and execute the command

```bash
  # without pattern
  dotnet run --project ./BuilderPattern/BuilderPattern.WithoutPattern/BuilderPattern.WithoutPattern.csproj

  # with pattern
  dotnet run --project ./BuilderPattern/BuilderPattern.WithPattern/BuilderPattern.WithPattern.csproj
```