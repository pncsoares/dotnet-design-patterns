using FactoryMethodPattern.WithPattern;

var randomAnimalFactory = new RandomAnimalFactory();
randomAnimalFactory.CreateAnimal().MakeSound();
randomAnimalFactory.CreateAnimal().MakeSound();
randomAnimalFactory.CreateAnimal().MakeSound();
randomAnimalFactory.CreateAnimal().MakeSound();
randomAnimalFactory.CreateAnimal().MakeSound();
randomAnimalFactory.CreateAnimal().MakeSound();

Console.WriteLine();

var balancedAnimalFactory = new BalancedAnimalFactory();
balancedAnimalFactory.CreateAnimal().MakeSound();
balancedAnimalFactory.CreateAnimal().MakeSound();
balancedAnimalFactory.CreateAnimal().MakeSound();
balancedAnimalFactory.CreateAnimal().MakeSound();
balancedAnimalFactory.CreateAnimal().MakeSound();
balancedAnimalFactory.CreateAnimal().MakeSound();