namespace OOP.Inheritance
{
    public abstract class Animal
    {
        protected int _energy;
        
        public Animal()
        {
            _energy = 5;
        }

        public void Eat()
        {
            Console.WriteLine("Eating...");
            _energy += 1;
        }

        public void Sleep()
        {
            Console.WriteLine("Sleeping...");
            _energy += 3;
        }

        public int GetEnergy()
        {
            return _energy;
        }

        public abstract void Play();

    }


    public class Dog : Animal
    {
        public Dog() 
        {
            _energy = 10;
        }

        public void Woof()
        {
            Console.WriteLine("Woof...");
            _energy -= 1;
        }

        public override void Play()
        {
            Console.WriteLine("Chasing ball...");
            _energy -= 3;
        }
    }

    public class Cat : Animal
    {
        public Cat() 
        {
            _energy = 7;
        }
        public void Meow()
        {
            Console.WriteLine("Meow...");
            _energy -= 1;
        }

        public override void Play()
        {
            Console.WriteLine("Fighting with shadows...");
            _energy -= 2;
        }

    }

}
