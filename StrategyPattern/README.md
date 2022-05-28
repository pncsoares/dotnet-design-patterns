# Strategy Design Pattern

This is simplest design patterns to understand.

If I would define this pattern in a few words, I would say that it is about using composition rather than inheritance because this pattern defends that inheritance is not intended for code reuse.

Official definition of the **Head First Design Patterns** book:

> The strategy design pattern defines a family of algorithms, encapsulates each one and makes them interchangeable. Strategy lets the algorithm very independently from clients that use it.

## Advantages

- Prevents the conditional statements (`switch`, `if`, `else`, ...)
- The algorithms are loosely coupled with the context entity. They can be changed/replaced without changing the context entity
- Very easy extendable


## Disadvantages

- Clients must know existence of different strategies
- Client must understand how the strategies differ
- It increases the number of objects in the application


## Code examples documentation

[📄 Code without design pattern](./StrategyPattern.WithoutPattern/README.md)

[📄 Code using design pattern](./StrategyPattern.WithoutPattern/README.md)