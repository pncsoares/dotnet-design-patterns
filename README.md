# Design Patterns

Design patterns written in C#

## Definition

A software design pattern is a general, reusable solution to a commonly occurring problem within a given context in software design. 
Design patterns are formalized best practices that the programmer can use to solve common problems when designing an application or system.

[👆 Source](https://en.wikipedia.org/wiki/Software_design_pattern)

In my opinion, this defines very well what a design pattern is.

## Advantages of using them

- Promote easier changes
- Turns the objects reusable
- Keeps objects small and specialized

## Types

- Creational patterns
- Structural patterns
- Behavioral patterns
- Concurrency patterns

## Code examples

| Type | Name | Information |
| -- | -- | -- |
| Creational patterns | Builder | [Go to detail 📄](./BuilderPattern/README.md) |
| Creational patterns | Singleton | [Go to detail 📄](./SingletonPattern/README.md) |
| Structural patterns | Facade | [Go to detail 📄](./FacadePattern/README.md) |
| Behavioral patterns | Command | [Go to detail 📄](./CommandPattern/README.md) |

Another design patterns that I will add in the future:

- [ ] Null Object
- [ ] Factory
- [ ] Observer
- [ ] Decorator
- [ ] Strategy
- [ ] Adapter
- [ ] Iterator
- [ ] Proxy
- [ ] Composite
- [ ] Bridge

# Setup

## Clone repository

Create and go to the directory where you want to place the repository

```bash
  cd my-directory
```

Clone the project

```bash
  git clone https://github.com/pncsoares/dotnet-design-patterns.git
```

Go to the project directory

```bash
  cd dotnet-design-patterns
```

## Run the Console Applications

Open terminal and execute the command

```bash
  dotnet run --project projectPath/projectName.csproj
  
  # example
  # dotnet run --project ./BuilderPattern/BuilderPattern.WithoutPattern/BuilderPattern.WithoutPattern.csproj
```

# License

MIT
