namespace LiskovExample
{
    // Interface Segregation Principle: Separate fly behavior from basic bird behavior
    public interface IBird
    {
        string Name { get; }
        void Feathers();
    }

    public interface IFlyingBird : IBird
    {
        void Fly();
    }


    // Single Responsibility Principle: Each class has one clear responsibility
    public class Pigeon : IFlyingBird
    {
        public string Name => "Pigeon";

        public void Feathers()
        {
            Console.WriteLine($"{Name} - I have feathers.");
        }

        public void Fly()
        {
            Console.WriteLine($"{Name} - I am flying.");
        }
    }

    public class Sparrow : IFlyingBird
    {
        public string Name => "Sparrow";

        public void Feathers()
        {
            Console.WriteLine($"{Name} - I have feathers.");
        }

        public void Fly()
        {
            Console.WriteLine($"{Name} - I am flying.");
        }
    }

    public class Ostrich : IBird
    {
        public string Name => "Ostrich";

        public void Feathers()
        {
            Console.WriteLine($"{Name} - I have feathers.");
        }
    }

    public class Penguin : IBird
    {
        public string Name => "Penguin";

        public void Feathers()
        {
            Console.WriteLine($"{Name} - I have feathers.");
        }
    }

    // Dependency Inversion Principle: depend on abstractions, not concrete classes
    public class CreateBird
    {
        public void BirdInfo(IBird bird)
        {
            bird.Feathers();

            if (bird is IFlyingBird flyingBird)
            {
                flyingBird.Fly();
            }
            else
            {
                Console.WriteLine($"{bird.Name} - I cannot fly.");
            }
        }
    }

    public class Birds
    {
        public void Run()
        {
            // This is the liskov substitution principle in action -
            // we can substitute any bird for the base interface -
            // it will work correctly without needing to know the specific type of bird
            var birds = new IBird[]
            {
                new Penguin(),
                new Ostrich(),
                new Pigeon(),
                new Sparrow()
            };

            CreateBird createBird = new CreateBird();

            foreach (var bird in birds)
            {
                createBird.BirdInfo(bird);
                Console.WriteLine();
            }
        }
    }
}