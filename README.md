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

# Code examples and documentation

## Creational patterns

| Type | Name | Information |
| -- | -- | -- |
| Creational patterns | Builder | [Go to detail 📄](./BuilderPattern/README.md) |
| Creational patterns | Singleton | [Go to detail 📄](./SingletonPattern/README.md) |

### TODO creational patterns

- [ ] Factory
- [ ] Abstract Factory
- [ ] Dependency Injection
- [ ] Lazy Initialization
- [ ] Multiton
- [ ] Object Pool
- [ ] Prototype
- [ ] Resource Acquisition Is Initialization (RAII)

### Structural patterns

| Type | Name | Information |
| -- | -- | -- |
| Structural patterns | Facade | [Go to detail 📄](./FacadePattern/README.md) |

### TODO structural patterns

- [ ] Adapter
- [ ] Bridge
- [ ] Composite
- [ ] Decorator
- [ ] Extension Object
- [ ] Flyweight
- [ ] Front Controller
- [ ] Marker
- [ ] Module
- [ ] Proxy
- [ ] Twin

### Behavioral patterns

| Type | Name | Information |
| -- | -- | -- |
| Behavioral patterns | Command | [Go to detail 📄](./CommandPattern/README.md) |

### TODO behavioral patterns

- [ ] Blackboard
- [ ] Chain Of Responsibility
- [ ] Interpreter
- [ ] Iterator
- [ ] Mediator
- [ ] Memento
- [ ] Null Object
- [ ] Observer
- [ ] Servant
- [ ] Specification
- [ ] State
- [ ] Strategy
- [ ] Template Method
- [ ] Visitor
- [ ] Dispose

### Concurrency patterns

| Type | Name | Information |
| -- | -- | -- |
| - | - | - |

### TODO concurrency patterns

- [ ] Active Object
- [ ] Balking
- [ ] Binding Properties
- [ ] Compute Kernel
- [ ] Double-Checked Locking
- [ ] Event-Based Asynchronous
- [ ] Guarded Suspension
- [ ] Join
- [ ] Lock
- [ ] Messaging
- [ ] Monitor Object
- [ ] Reactor
- [ ] Read-Write Lock
- [ ] Scheduler
- [ ] Thread Pool
- [ ] Thread-Specific Storage
- [ ] Safe Concurrency With Exclusive Ownership
- [ ] CPU Atomic Operation

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
