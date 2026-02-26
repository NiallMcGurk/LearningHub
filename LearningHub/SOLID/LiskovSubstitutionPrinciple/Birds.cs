namespace LiskovExample
{
    public class Bird
    {
        public string Name { get; }
        public bool CanFly { get; }

        public Bird(string name, bool canFly)
        {
            this.Name = name;
            this.CanFly = canFly;
        }
        
        public void Feathers()
        {
            Console.WriteLine($"{Name} - I have feathers.");
        }

        public void CanTheBirdFly()
        {
            if (CanFly)
            {
                Console.WriteLine($"{Name} - I am flying.");
            }
            else
            {
                Console.WriteLine($"{Name} - I cannot fly.");
            }
        }
    }

    public class NonFlyingBirds : Bird
    {
        public NonFlyingBirds(string name) : base(name, false)
        {
        }
    }

    public class FlyingBird : Bird
    {
        public FlyingBird(string name) : base(name, true)
        {
        }
    }

    public class Pidgeon : FlyingBird
    {
        public Pidgeon() : base("Pidgeon") { }
    }

    public class Ostrich : NonFlyingBirds
    {
        public Ostrich() : base("Ostrich") { }
    }

    public class Penguin : NonFlyingBirds
    {
        public Penguin() : base("Penguin") { }  
    }

    public class Sparrow : FlyingBird
    {
        public Sparrow() : base("Sparrow") { }
    }

    public class Birds
    {
        public void Run()
        {
            Penguin penguin = new Penguin();
            penguin.Feathers();
            penguin.CanTheBirdFly();

            Ostrich ostrich = new Ostrich();
            ostrich.Feathers();
            ostrich.CanTheBirdFly();

            Pidgeon pidgeon = new Pidgeon();
            pidgeon.Feathers();
            pidgeon.CanTheBirdFly();

            Sparrow sparrow = new Sparrow();
            sparrow.Feathers();
            sparrow.CanTheBirdFly();

            // Example of a base class being substituted by the sub class (if required)
            Bird bird = new Bird("Sparrow", true);
            bird.Feathers();
            bird.CanTheBirdFly();
        }
    }
}