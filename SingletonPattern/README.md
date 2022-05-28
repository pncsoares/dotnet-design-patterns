# Singleton Design Pattern

Ensure a class has only one instance, and provide a global point of access to it.

## Advantages

- Prevents other objects from instantiating their own copies of the Singleton object
- You are absolutely sure of the number of instances when you use Singleton, and, you can change your mind and manage any number of instances

## Disadvantages

- **Singletons hinder unit testing**: A Singleton might cause issues for writing testable code if the object and the methods associated with it are so tightly coupled that it becomes impossible to test without writing a fully-functional class dedicated to the Singleton
- **Singletons create hidden dependencies**: As the Singleton is readily available throughout the code base, it can be overused. Moreover, since its reference is not completely transparent while passing to different methods, it becomes difficult to track