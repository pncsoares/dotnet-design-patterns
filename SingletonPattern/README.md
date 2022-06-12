# Singleton Design Pattern

> Many people argue that singleton pattern actually is a code smell (is any characteristic in the source code of a program that possibly indicates a deeper problem) that you should not actually ever use the singleton pattern.

Lets take a look at the definition of the **Head First Design Patterns** book and then we will briefly see why people argue that you should not use this pattern.

## 📖 Official definition of the **Head First Design Patterns** book:

> The singleton pattern ensures a class has only one instance and provide a global point of access to it.

In other words, you have a class and singleton pattern helps you to make it impossible to instantiate that class, except for a single time and then, whenever you want an instance, you will inevitably have to use that instance. The way it actually works is that whenever you ask for an instance, you will always get the same instance.

<details>
    <summary><b>Expand to see why people argue that you should not use this pattern</b></summary>

The main critique towards this pattern core essentially these two points:

### 1. Avoid globals

One of the first things we learn when we talk about programming is to avoid globals, its to actually scope variables and functions so that not everything is leaking into the global namespace.

For one it is extremely difficult to control because you have a box of lots of different things that might be ambiguous out context or might be difficult to understand out of context. But probably more importantly, whenever you leak something to the global namespace, whenever something is globally accessible, that thing might change without you knowing. It's much harder to reason about your program when you don't have control, when you don't necessarily know the scope of a particular thing because that thing that you are interacting with, anybody within the whole program might change that thing, assuming it is a changeable, it might of course not be changeable. But anything within your program might be able to touch that thing.

### 2. Making sure that you only have a single instance

This is kind of an absurd idea. If you think about it, that is an assumption. You are assuming that in the future, I will only ever ever have a single instance of a particular class...that is not necessarily true and especially if your application is growing.

So, just to take certain example, think about building a chat application. So you might first think that the chat is a singleton like you want to be able to reference the chat in which users are from whenever in the program and in order to make it more convenient for yourself, you make it a singleton and you have a point of access to this instance of the chat.

But, as time progresses, you start to realize that actually we are being very successful with this chat and we want to have multiple chat rooms and if the singleton chat is managing users who are currently connected to this chat, that's essentially a chatroom, it's just that when we were designing it as a singleton we didn't think about the fact that, in the future, we maybe actually want multiple instances of this thing that we currently really believe that we only want a single instance of.

So, the whole idea about, before seeing the application to only have a singleton instance of something, only really makes sense if you 100% know that, now and in the future, you will only need a single instance of that class but I would argue that we almost never know that so it's better just to not make that assumption.

In the following links you will find Google tech talks that discuss this and other cool things 👇

- [Inheritance, Polymorphism, & Testing](https://www.youtube.com/watch?v=4F72VULWFvc)
- [Unit Testing](https://www.youtube.com/watch?v=wEhu57pih5w)
- [Don't Look For Things!](https://www.youtube.com/watch?v=RlfLCWKxHJ0)
- [Global State and Singletons](https://www.youtube.com/watch?v=-FRm3VPhseI)
- [How to Write Clean, Testable Code](https://www.youtube.com/watch?v=XcT4yYu_TTs)

### And what about testing? 🤔

There is a great saying that _"one man's constant is another man's variable"_ and if you look at it from a different perspective, singletons might make testing very difficult because whoever is requesting the singleton will definitely get a particular instance but in testing you might, for example, want to mock that and that becomes a lot more difficult when you have this sort of global object, this global single instance that you are always reaching for.

So, even if in the whole application you really need a single instance, as soon as you do testing, there's almost always a second needed instance because you might want to mock that within the testing of your application.

So, again, _"one man's constant is another man's variable"_.

## So, what to do instead? 🤷

It is completely fine to have a single object, only only a single object within your application but it's not fine to force, to make it impossible to create a second instance. It's not a good idea to make it impossible to create a second instance because you don't necessarily know whether you have some point actually want the second instance.

**But, have in mind that the singleton pattern is designed with the intent of making it impossible to create a second instance.**

</details>

<br>

## 👍 Advantages

- Prevents other objects from instantiating their own copies of the Singleton object
- You are absolutely sure of the number of instances when you use Singleton, and, you can change your mind and manage any number of instances

## 👎 Disadvantages

- **Singletons hinder unit testing**: A Singleton might cause issues for writing testable code if the object and the methods associated with it are so tightly coupled that it becomes impossible to test without writing a fully-functional class dedicated to the Singleton
- **Singletons create hidden dependencies**: As the Singleton is readily available throughout the code base, it can be overused. Moreover, since its reference is not completely transparent while passing to different methods, it becomes difficult to track

## Code and documentation

[📄 Code without design pattern](./SingletonPattern.WithoutPattern/README.md)

[📄 Code using design pattern](./SingletonPattern.WithPattern/README.md)