namespace LearningHub.SOLID.InterfaceSegregationPrinciple
{
    public class BitcoinProcessor : IProcessPayment
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine("Processing Bitcoin payment of " + amount);
        }
    }
}
