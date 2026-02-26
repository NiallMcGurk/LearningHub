namespace LearningHub.SOLID.DependencyInversionPrinciple
{
    public class EmailService : IMessageService
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("Message: " + message + " - send via Email.");
        }
    }
}
