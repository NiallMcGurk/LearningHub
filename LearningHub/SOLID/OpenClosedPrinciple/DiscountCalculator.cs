namespace LearningHub.SOLID.OpenClosedPrinciple
{
    public class DiscountCalculator
    {
        private readonly IDiscount _discount;

        public DiscountCalculator(IDiscount discount)
        {
            _discount = discount;
        }

        public decimal Calculate(decimal amount)
        {
            return _discount.CalculateDiscount(amount);
        }
    }
}
