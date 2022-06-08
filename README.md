# Design Patterns

Design patterns written in C#

[![contributions welcome](https://img.shields.io/badge/contributions-welcome-brightgreen.svg?style=flat)](./CONTRIBUTING.md)

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

### Creational patterns

Deal with object creation mechanisms, trying to create objects in a manner suitable to the situation. The basic form of object creation could result in design problems or in added complexity to the design. Creational design patterns solve this problem by somehow controlling this object creation.

Are composed of two dominant ideas:
1. Encapsulating knowledge about which concrete classes the system uses;
1. Hiding how instances of these concrete classes are created and combined.

### Structural patterns

Ease the design by identifying a simple way to realize relationships among entities. 

### Behavioral patterns

Identify common communication patterns among objects. By doing so, these patterns increase flexibility in carrying out communication. 

### Concurrency patterns

Deal with the multi-threaded programming paradigm. 

# Code examples and documentation

## Creational patterns

- [Factory Method](./FactoryMethodPattern/README.md)

> There are 3 versions of the factory pattern, the simple factory, the factory method and the abstract factory. To know more, read [this file](./.github/FACTORY.md).

- [Builder](./BuilderPattern/README.md)
- [Singleton](./SingletonPattern/README.md)

### TODO creational patterns

- [ ] Abstract Factory
- [ ] Dependency Injection
- [ ] Lazy Initialization
- [ ] Multiton
- [ ] Object Pool
- [ ] Prototype
- [ ] Resource Acquisition Is Initialization (RAII)

## Structural patterns

- [Decorator](./DecoratorPattern/README.md)
- [Facade](./FacadePattern/README.md)

### TODO structural patterns

- [ ] Adapter
- [ ] Bridge
- [ ] Composite
- [ ] Extension Object
- [ ] Flyweight
- [ ] Front Controller
- [ ] Marker
- [ ] Module
- [ ] Proxy
- [ ] Twin

## Behavioral patterns

- [Strategy](./StrategyPattern/README.md)
- [Observer](./ObserverPattern/README.md)
- [Command](./CommandPattern/README.md)
- [Dispose](./DisposePattern/README.md)
- [Null Object](./NullObjectPattern/README.md)

### TODO behavioral patterns

- [ ] Blackboard
- [ ] Chain Of Responsibility
- [ ] Interpreter
- [ ] Iterator
- [ ] Mediator
- [ ] Memento
- [ ] Servant
- [ ] Specification
- [ ] State
- [ ] Template Method
- [ ] Visitor

## Concurrency patterns

- _Empty for now..._

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

# 🤲 Contribute

Any contributions are highly appreciated 🙏

You can contribute in some ways:
1. Fork the project and submit a PR with the new design pattern. Before doing that, please make sure that you read and follow the [Contribution Guide](./CONTRIBUTING.md);
1. If you want others to add a design pattern, go to `issues` tab and create a new issue with the label `new design pattern` and add the name of the design pattern in the `title`;
1. Fork the project and submit a PR with an improvement of any kind, code, documentation, scenarios, pros, cons, spelling, etc;
1. If you noticed something and want to register it so others can handle it, create a new issue with the label that better fits that scenario and fill as much information as you can.

# 📢 Give feedback

Do you have any suggestions on how we could improve this project overall? Let us know! We'd love to hear your feedback!

Use the `discussions` tab for this purpose. Choose the category that better fits the scope of the discussion.

# 🌱 Spread the word!

If the information from this repo was useful to you in any way, make sure you give it a star ⭐

This way others can find it and benefit too! Together we can grow and make our community better!

Thanks 🙏