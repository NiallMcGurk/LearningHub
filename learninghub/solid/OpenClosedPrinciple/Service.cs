namespace LearningHub.SOLID.OpenClosedPrinciple
{
    public class Service : IService
    {
        public readonly IService _service;

        public Service(IService service)
        {
            this._service = service;
        }

        public void PrintToConsoleExample()
        {
            Console.WriteLine("Hello from Service class");
        }

        public int DoSomething(int value)
        {
            // Decorator pattern - before or after the existing code

            // implement the existing interface

            // Calls new method without 

            // needs more study
            int newValue = this._service.DoSomething(value);

            Console.WriteLine($"The value from the service is {newValue}");

            return newValue;
        }
    }
}