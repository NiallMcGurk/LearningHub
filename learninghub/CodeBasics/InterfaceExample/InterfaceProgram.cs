using LearningHub.CodeBasics.Interface;
using LearningHub.CodeBasics.InterfaceExample;

namespace LearningHub
{
    public class InterfaceProgram
    {
        public InterfaceProgram()
        {
            List<ITransport> vehicles = new List<ITransport>
        {
            new Car(),
            new Bike(),
            new Truck()
        };
            // POLYMORPISM!
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"This vehicle has {vehicle.Wheels} wheels.");
                vehicle.Move();
            }
        }
    }
}
