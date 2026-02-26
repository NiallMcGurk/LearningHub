namespace LearningHub.SOLID.OpenClosedPrinciple
{
    public class PremiumDiscount : IDiscount
    {
        // An example of a "new" discount that we can add without modifying existing code.
        public decimal CalculateDiscount(decimal amount)
        {
            return amount * 0.5m;
        }
    }
}
