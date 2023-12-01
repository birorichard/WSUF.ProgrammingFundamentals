using OOP.Inheritance;

Console.WriteLine("Dog stuffs");
var dog = new Dog();

Console.WriteLine(dog.GetEnergy());

dog.Sleep();

Console.WriteLine(dog.GetEnergy());

dog.Woof();
dog.Woof();

Console.WriteLine(dog.GetEnergy());


Console.WriteLine("\n");
Console.WriteLine("Cat stuffs");
var cat = new Cat();
cat.Meow();
Console.WriteLine(cat.GetEnergy());

Console.WriteLine("\n");

cat.Play();
Console.WriteLine(cat.GetEnergy());

dog.Play();
Console.WriteLine(dog.GetEnergy());