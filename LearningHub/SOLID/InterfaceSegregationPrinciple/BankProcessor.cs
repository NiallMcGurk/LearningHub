namespace LearningHub.SOLID.InterfaceSegregationPrinciple
{
    // Golden Scenario
    public class BankProcessor : IProcessPayment, IRefundPayment, ISaveCardDetails, IValidateFraudCheck
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine("Processing credit card payment of " + amount);
        }

        public void RefundPayment(decimal amount)
        {
            Console.WriteLine("Refunding credit card payment of " + amount);
        }

        public void SaveCardDetails(string cardNumber)
        {
            Console.WriteLine("Saving card details of card number: " + cardNumber);
        }

        public void ValidateFraudCheck()
        {
            Console.WriteLine("Running fraud check");
        }
    }
}
