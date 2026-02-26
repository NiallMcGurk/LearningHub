namespace LearningHub.SOLID.OpenClosedPrinciple
{
    public class BasicDiscount : IDiscount
    {
        // This will never need to be modified
        // We can now just add a new class and use the interface to create new discounts.
        public decimal CalculateDiscount(decimal amount)
        {
            return amount * 0.10m;
        }
    }
}
