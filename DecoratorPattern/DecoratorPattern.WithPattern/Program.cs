using DecoratorPattern.WithPattern;

var pizza = new PlainPizza();
var mozzarellaDecorator = new MozzarellaDecorator(pizza);
var tomatoDecorator = new TomatoSauceDecorator(mozzarellaDecorator);
var onionDecorator = new OnionDecorator(tomatoDecorator);
onionDecorator.Print();