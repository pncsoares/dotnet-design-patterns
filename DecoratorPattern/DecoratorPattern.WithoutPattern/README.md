# Code without decorator design pattern

To exemplify, we have a Pizza factory that has a plain pizza (basically the dough) and then you can choose the ingredients.

To achieve that, we created 3 classes:
- Pizza Carbonara
- Pizza Pepperoni
- Pizza Extra Cheese

Each class have the ingredients statically defined, to this example we used a string (description) to register the ingredients but in a real app/system we could have a list of ingredients saved in the database or other platform. But what it's important to understand is that each class has the ingredients statically defined, so, if a pizza changes an ingredient or if a factory would like to change an existing pizza, the code must be changed, compiled and deployed in order for that to take effect in the next orders.

In the class `Program.cs`, we are creating this 3 types of pizzas:

```csharp
var pizzaCarbonara = new PizzaCarbonara();
pizzaCarbonara.Print();

var pizzaPepperoni = new PizzaPepperoni();
pizzaPepperoni.Print();

var pizzaExtraCheese = new PizzaExtraCheese();
pizzaExtraCheese.Print();
```

And the output is the following:

```
Creating pizza Carbonara
Ingredients: Crisp pieces of salt bacon, mushrooms, gooey cheese and egg
Cost: 10.5

Creating pizza Pepperoni
Ingredients: Salami, paprika, garlic, black pepper, red pepper, cayenne pepper, mustard seed and fennel seed
Cost: 11.5

Creating pizza with extra Cheese
Ingredients: Mozzarella, parmesan, fontina, cheddar, provolone, pecorino romano and ricotta
Cost: 11
```

We can see for the code and structure that each time this pizza factory wants to create a new pizza, needs to create e new class and define the ingredients.

If the price of the tomato sauce, for example, changes, all the `GetCost()` method from all classes of pizzas that has tomato sauce needs to be changed.

Also, if a customer wants to create a custom pizza, the developers needs to find a way to make that possible with the code as is in this example.

> We will see this same scenario but using Decorator pattern - all this "problems" are solved with it

# Try it yourself

You can run the console application to see the output in the console.

To do that, you can use your IDE buttons/options or via terminal, executing the following command:

> before executing the command, `cd` to this repository root directory

```bash
dotnet run --project ./DecoratorPattern/DecoratorPattern.WithoutPattern/DecoratorPattern.WithoutPattern.csproj
```

Now lets see the code using the decorator pattern 👇

[📄 Code using decorator pattern](../DecoratorPattern.WithPattern/README.md)