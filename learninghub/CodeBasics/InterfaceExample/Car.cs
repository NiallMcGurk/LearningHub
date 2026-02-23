using LearningHub.CodeBasics.Interface;

namespace LearningHub.CodeBasics.InterfaceExample
{
    public class Car : ITransport
    {
        public int Wheels => 4;

        public void Move()
        {
          Console.WriteLine("The Car drives forward");
        }
    }
}
