using LearningHub.CodeBasics.Interface;
namespace LearningHub.CodeBasics.InterfaceExample
{
    public class Bike: ITransport
    {
        public int Wheels => 2;
        public void Move()
        {
            Console.WriteLine("The Bike pedals forward");
        }
    }
}
