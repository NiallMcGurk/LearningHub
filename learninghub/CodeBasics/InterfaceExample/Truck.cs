using LearningHub.CodeBasics.Interface;

namespace LearningHub.CodeBasics.InterfaceExample
{
    public class Truck: ITransport
    {
        public int Wheels => 6;
        public void Move()
        {
            Console.WriteLine("The Truck hauls forward");
        }
    }
}
