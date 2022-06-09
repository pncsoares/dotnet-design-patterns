# Code without factory method design pattern

So, we have the same animal factory example that we saw before:

> The `RandomAnimalFactory` is a factory method that always creates a random animal. It does not have state, every time we invoke it, a random `Animal` is returned and the `BalancedAnimalFactory` has state, it starts to create a new `Animal` but then, only randomizes the other animals different that the ones that were already created.

Take a look at the code and analyze how the responsibility of creating a new `Animal` is statically created in the `Program.cs` file.

# Try it yourself

You can run the console application to see the output in the console.

To do that, you can use your IDE buttons/options or via terminal, executing the following command:

> before executing the command, `cd` to this repository root directory

```bash
dotnet run --project ./FactoryMethodPattern/FactoryMethodPattern.WithoutPattern/FactoryMethodPattern.WithoutPattern.csproj
```

Now lets see the code using the factory method pattern 👇

[📄 Code using factory method pattern](../FactoryMethodPattern.WithPattern/README.md)