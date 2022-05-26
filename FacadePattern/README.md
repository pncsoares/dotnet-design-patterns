# Facade Design Pattern

Provide a unified interface to a set of interfaces in a subsystem. Facade defines a higher-level interface that makes the subsystem easier to use.

## Advantages

- Minimizes complexity of sub-systems
- Aids principle of loose coupling
- Software becomes more flexible and easily expandable

## Disadvantages

- Complex implementation (especially with existing code)
- Approach is coupled to an additional level of indirection
- High degree of dependence at facade interface

# See the code result

Open terminal and execute the command

```bash
  # without pattern
  dotnet run --project ./FacadePattern/FacadePattern.WithoutPattern/FacadePattern.WithoutPattern.csproj

  # with pattern
  dotnet run --project ./FacadePattern/FacadePattern.WithPattern/FacadePattern.WithPattern.csproj
```