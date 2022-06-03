using DecoratorPattern.WithoutPattern;

var pizzaCarbonara = new PizzaCarbonara();
pizzaCarbonara.Print();

Console.WriteLine();

var pizzaPepperoni = new PizzaPepperoni();
pizzaPepperoni.Print();

Console.WriteLine();

var pizzaExtraCheese = new PizzaExtraCheese();
pizzaExtraCheese.Print();