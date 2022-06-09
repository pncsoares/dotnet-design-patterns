using FactoryMethodPattern.WithoutPattern;

// Random
var random = new Random().Next(0, 2);

switch (random)
{
    case 0:
        new Cat().MakeSound();
        break;
    case 1:
        new Dog().MakeSound();
        break;
    case 2:
        new Duck().MakeSound();
        break;
};

// Balanced
short counter = 0;

switch (counter)
{
    case 0:
        counter++;
        new Cat().MakeSound();
        break;

    case 1:
        counter++;
        new Dog().MakeSound();
        break;

    case 2:
        counter = 0;
        new Duck().MakeSound();
        break;
}