# The 3 versions of the Factory Pattern

> 📝 All three Factory types do the same thing: They are a "smart constructor".

Let's say you want to be able to create two kinds of Fruit: Apple and Orange.

## Factory

Factory is "fixed", in that you have just one implementation with no sub-classing. In this case, you will have a class like this:

```csharp
class FruitFactory {

    public Apple MakeApple() {
      // Code for creating an Apple here.
    }

    public Orange MakeOrange() {
      // Code for creating an orange here.
    }

}
```

_Use case: Constructing an Apple or an Orange is a bit too complex to handle in the constructor for either._

## Factory Method

Factory method is generally used when you have some generic processing in a class, but want to vary which kind of fruit you actually use. So:

```csharp
abstract class FruitPicker {

    protected abstract Fruit MakeFruit();

    public void PickFruit() {
        private sealed Fruit fruit = MakeFruit(); // The fruit we will work on..
        // ...
    }
}
```

...then you can reuse the common functionality in FruitPicker.pickFruit() by implementing a factory method in subclasses:

```csharp
class OrangePicker : FruitPicker {

    protected override Fruit MakeFruit() {
        return new Orange();
    }
}
```

[📄 Read Factory Method detailed documentation](./FactoryMethodPattern/README.md)

## Abstract Factory

Abstract factory is normally used for things like dependency injection/strategy, when you want to be able to create a whole family of objects that need to be of "the same kind", and have some common base classes. Here's a vaguely fruit-related example. The use case here is that we want to make sure that we don't accidentally use an OrangePicker on an Apple. As long as we get our Fruit and Picker from the same factory, they will match.

```csharp
interface IPlantFactory {
  
    Plant MakePlant();

    Picker MakePicker(); 

}

public class AppleFactory : IPlantFactory {

    Plant MakePlant() {
        return new Apple();
    }

    Picker MakePicker() {
        return new ApplePicker();
    }
}

public class OrangeFactory : IPlantFactory {

    Plant MakePlant() {
        return new Orange();
    }

    Picker MakePicker() {
        return new OrangePicker();
    }
}
```