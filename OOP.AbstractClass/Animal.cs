namespace OOP.AbstractClass
{
    public abstract class Animal
    {
        protected int _energy;
        
        public Animal()
        {
            _energy = 5;
        }

        public abstract string Sound();

        public void Eat()
        {
            Console.WriteLine("Eating...");
            _energy += 1;
        }

        public void Sleep()
        {
            _energy += 2;
            Console.WriteLine("Sleeping...");
        }

        public void Play()
        {
            if (_energy == 0) 
            {
                Console.WriteLine("Can't play, have to sleep or eat something.");
            }
            else
            {
                _energy -= 1;
            }
        }

        public int GetEnergy()
        {
            return _energy;
        }
    }

    public class Cat : Animal
    {
        public Cat()
        {
            _energy = 10;
        }

        public override string Sound()
        {
            throw new NotImplementedException();
        }
    }

    
}
