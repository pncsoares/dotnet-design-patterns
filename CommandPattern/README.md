# Command Design Pattern

Encapsulate a request as an object, thereby allowing for the parameterization of clients with different requests, and the queuing or logging of requests. It also allows for the support of undo operations.

## 👍 Advantages

- It decouples the classes that invoke the operation from the object that knows how to execute the operation
- Allows you to create a sequence of commands by providing a queue system
- Extensions to add a new command is easy and can be done without changing the existing code
- You can also define a rollback system with the Command pattern

## 👎 Disadvantages

- There are a high number of classes and objects working together to achieve a goal. Application developers need to be careful developing these classes correctly
- Using command design pattern may requires more effort on implementation, since each command requires a concrete command class