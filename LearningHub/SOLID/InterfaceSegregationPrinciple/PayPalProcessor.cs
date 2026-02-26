namespace LearningHub.SOLID.InterfaceSegregationPrinciple
{
    public class PayPalProcessor : IProcessPayment, IRefundPayment, IValidateFraudCheck
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine("Processing PayPal payment of " + amount);
        }

        public void RefundPayment(decimal amount)
        {
            Console.WriteLine("Refunding PayaPal payment of " + amount);
        }

        public void ValidateFraudCheck()
        {
            Console.WriteLine("Running fraud check");
        }
    }
}
