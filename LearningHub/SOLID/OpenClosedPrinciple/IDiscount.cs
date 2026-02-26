namespace LearningHub.SOLID.OpenClosedPrinciple
{
    // IDiscount defines a contract for discount calculation.
    // It allows new discount types to be added without modifying
    // existing classes (Open/Closed Principle).
    //
    // The DiscountCalculator depends on this abstraction
    // rather than concrete implementations.
    public interface IDiscount
    {
        // Each discount type provides its own calculation logic. (10%, 50%)
        // The calculator does not need to know how the discount works,
        // only that it can calculate one.
        decimal CalculateDiscount(decimal amount);
    }
}
