# Code without abstract factory design pattern

One of the many possibilities of achieving what we need to do in our UI controls application is to create an abstraction for the `AlertBox` and the `Button`. Then, we need to create the 3 implementations for this abstractions, one for each operation system.

Take a look at the code 👀

If you run the project, the output will be the following:

```
MacOs Factory starting...
Creating an alert box that works on MacOs
> The MacOs alert box is now displayed
This is a button that works on MacOs
> The MacOs button is now displayed

Linux Factory starting...
This is an alert box that works on Linux
> The Linux alert box is now displayed
This is a button that works on Linux
> The Linux button is now displayed

Windows Factory starting...
This is an alert box that works on Windows
> The Windows alert box is now displayed
This is a button that works on Windows
> The Windows button is now displayed
```

# Try it yourself

You can run the console application to see the output in the console.

To do that, you can use your IDE buttons/options or via terminal, executing the following command:

> before executing the command, `cd` to this repository root directory

```bash
dotnet run --project ./AbstractFactoryPattern/AbstractFactoryPattern.WithoutPattern/AbstractFactoryPattern.WithoutPattern.csproj
```

Now lets see the code using the abstract factory pattern 👇

[📄 Code using abstract factory pattern](../AbstractFactoryPattern.WithPattern/README.md)