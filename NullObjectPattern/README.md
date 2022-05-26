# Null Object Design Pattern

The Null object pattern is a design pattern that simplifies the use of dependencies that can be undefined. This is achieved by using instances of a concrete class that implements a known interface, instead of null references.

We create an abstract class specifying various operations to be done, concrete classes extending this class and a null object class providing do nothing implementation of this class and will be used seamlessly where we need to check null value.

## What is Null Object?

A no-operation object that conforms to the required interface, satisfying a dependency requirement of some other object.

## Why should I use null object design pattern?

**When component A uses component B, it typically assumes that B is non-null**

If you use dependency injection and you inject B or some `Option<B>` you probably will not check for null (for example `?.`) on every call.

**There is no option of telling A not to use an instance of B**

Its use is hard-coded

**Thus, we build a no-operation, non-functioning inheritor of B and pass it into A**

## Advantages

- It defines class hierarchies consisting of real objects and null objects. Null objects can be used in place of real objects when the object is expected to do nothing. Whenever client code expects a real object, it can also take a null object.

- Also makes the client code simple. Clients can treat real collaborators and null collaborators uniformly. Clients normally don’t know whether they’re dealing with a real or a null collaborator. This simplifies client code, because it avoids having to write testing code which handles the null collaborator specially.

## Disadvantages

- Can be difficult to implement if various clients do not agree on how the null object should do nothing as when your AbstractObject interface is not well defined.

- Can necessitate creating a new NullObject class for every new AbstractObject class.

# See the code result

Open terminal and execute the command

```bash
  # without pattern
  dotnet run --project ./NullObjectPattern/NullObjectPattern.WithoutPattern/NullObjectPattern.WithoutPattern.csproj

  # with pattern
  dotnet run --project ./NullObjectPattern/NullObjectPattern.WithPattern/NullObjectPattern.WithPattern.csproj
```

## Code examples documentation

[📄 Code without design pattern](./NullObjectPattern.WithoutPattern/README.md)

[📄 Code using design pattern](./NullObjectPattern.WithPattern/README.md)