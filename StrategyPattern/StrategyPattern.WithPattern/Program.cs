using StrategyPattern.WithPattern;
using StrategyPattern.WithPattern.Implementations.Display;
using StrategyPattern.WithPattern.Implementations.Eat;
using StrategyPattern.WithPattern.Implementations.Fly;
using StrategyPattern.WithPattern.Implementations.Quack;

// display
var animalDisplayBehavior = new AnimalDisplayBehavior();
var toyDisplayBehavior = new ToyDisplayBehavior();

// quack
var quietQuackBehavior = new QuietQuackBehavior();
var loudQuackBehavior = new LoudQuackBehavior();
var noQuackBehavior = new NoQuackBehavior();

// fly
var lowFlyBehavior = new LowFlyBehavior();
var noFlyBehavior = new NoFlyBehavior();
var cloudFlyBehavior = new CloudFlyBehavior();

// eat
var meatEatBehavior = new MeatEatBehavior();
var noEatBehavior = new NoEatBehavior();
var vegetarianEatBehavior = new VegetarianEatBehavior();

var cityDuck = new CityDuck(animalDisplayBehavior, quietQuackBehavior, lowFlyBehavior, meatEatBehavior);
var wildDuck = new WildDuck(animalDisplayBehavior, loudQuackBehavior, lowFlyBehavior, meatEatBehavior);
var rubberDuck = new RubberDuck(toyDisplayBehavior, noQuackBehavior, noFlyBehavior, noEatBehavior);
var cloudDuck = new CloudDuck(animalDisplayBehavior, quietQuackBehavior, cloudFlyBehavior, vegetarianEatBehavior);
var mountainDuck = new MountainDuck(animalDisplayBehavior, loudQuackBehavior, cloudFlyBehavior, vegetarianEatBehavior);