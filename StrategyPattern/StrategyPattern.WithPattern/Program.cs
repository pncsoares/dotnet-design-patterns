using StrategyPattern.WithPattern;
using StrategyPattern.WithPattern.Implementations;

// display
var cityDisplayBehavior = new CityDisplayBehavior();
var wildDisplayBehavior = new WildDisplayBehavior();
var rubberDisplayBehavior = new RubberDisplayBehavior();
var cloudDisplayBehavior = new CloudDisplayBehavior();
var mountainDisplayBehavior = new MountainDisplayBehavior();

// quack
var simpleQuackBehavior = new SimpleQuackBehavior();
var noQuackBehavior = new NoQuackBehavior();

// fly
var simpleFlyBehavior = new SimpleFlyBehavior();
var noFlyBehavior = new NoFlyBehavior();
var cloudFlyBehavior = new CloudFlyBehavior();

// eat
var simpleEatBehavior = new SimpleEatBehavior();
var noEatBehavior = new NoEatBehavior();
var eatBirdBehavior = new EatBirdBehavior();

var cityDuck = new CityDuck(cityDisplayBehavior, simpleQuackBehavior, simpleFlyBehavior, simpleEatBehavior);
var wildDuck = new WildDuck(wildDisplayBehavior, simpleQuackBehavior, simpleFlyBehavior, simpleEatBehavior);
var rubberDuck = new RubberDuck(rubberDisplayBehavior, noQuackBehavior, noFlyBehavior, noEatBehavior);
var cloudDuck = new CloudDuck(cloudDisplayBehavior, simpleQuackBehavior, cloudFlyBehavior, eatBirdBehavior);
var mountainDuck = new MountainDuck(mountainDisplayBehavior, simpleQuackBehavior, cloudFlyBehavior, eatBirdBehavior);