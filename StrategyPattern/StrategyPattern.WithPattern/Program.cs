using StrategyPattern.WithPattern;
using StrategyPattern.WithPattern.Strategies.Display;
using StrategyPattern.WithPattern.Strategies.Eat;
using StrategyPattern.WithPattern.Strategies.Fly;
using StrategyPattern.WithPattern.Strategies.Quack;

// display
var animalDisplayStrategy = new AnimalDisplayStrategy();
var toyDisplayStrategy = new ToyDisplayStrategy();

// quack
var quietQuackStrategy = new QuietQuackStrategy();
var loudQuackStrategy = new LoudQuackStrategy();
var noQuackStrategy = new NoQuackStrategy();

// fly
var lowFlyStrategy = new LowFlyStrategy();
var noFlyStrategy = new NoFlyStrategy();
var cloudFlyStrategy = new CloudFlyStrategy();

// eat
var meatEatStrategy = new MeatEatStrategy();
var noEatStrategy = new NoEatStrategy();
var vegetarianEatStrategy = new VegetarianEatStrategy();

var cityDuck = new CityDuck(animalDisplayStrategy, quietQuackStrategy, lowFlyStrategy, meatEatStrategy);
var wildDuck = new WildDuck(animalDisplayStrategy, loudQuackStrategy, lowFlyStrategy, meatEatStrategy);
var rubberDuck = new RubberDuck(toyDisplayStrategy, noQuackStrategy, noFlyStrategy, noEatStrategy);
var cloudDuck = new CloudDuck(animalDisplayStrategy, quietQuackStrategy, cloudFlyStrategy, vegetarianEatStrategy);
var mountainDuck = new MountainDuck(animalDisplayStrategy, loudQuackStrategy, cloudFlyStrategy, vegetarianEatStrategy);