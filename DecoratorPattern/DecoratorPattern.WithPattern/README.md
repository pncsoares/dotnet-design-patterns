# Code using decorator design pattern

Here, the example is the same, a pizza factory and after applying the Decorator pattern, the pizzas are custom made. If the customer wants a Carbonara pizza, all the ingredients to that pizza receipt will be added. If a customer does not like cheese (hope not 🙂), we just need to instruct the code to not use the cheese decorator and so on.

Also, if the price for a specific ingredient changes, we just need to change the price of that particular ingredient and all the application continues to work properly.

Example of a pizza assembled in the `Program.cs` file:

```csharp
var pizza = new PlainPizza();
var mozzarellaDecorator = new MozzarellaDecorator(pizza);
var tomatoDecorator = new TomatoSauceDecorator(mozzarellaDecorator);
var onionDecorator = new OnionDecorator(tomatoDecorator);
onionDecorator.Print();
```

We started with the component, the plain pizza, then we added Mozzarella cheese, then tomato and onion. The sentence that we read in the main Decorator pattern [README](https://github.com/pncsoares/dotnet-design-patterns/blob/main/DecoratorPattern/README.md) is verified by the code: _The decorators behave like the component (the object) from the interface standpoint, in other words, they are exchangeable. So we are saying that you wrap the original component (object in our example) and then you can use the wrapper to pass them around as if it was one of the original component._

The code output is the following for the code example above:

```
Adding dough
Adding mozzarella
Adding tomato sauce
Adding onion

Ingredients: Thin dough, Mozzarella, Tomato Sauce, Onion
Cost: 10.35
```

# Try it yourself

You can run the console application to see the output in the console.

To do that, you can use your IDE buttons/options or via terminal, executing the following command:

> before executing the command, `cd` to this repository root directory

```bash
dotnet run --project ./DecoratorPattern/DecoratorPattern.WithPattern/DecoratorPattern.WithPattern.csproj
```

[📄 Code without decorator pattern](../DecoratorPattern.WithoutPattern/README.md)