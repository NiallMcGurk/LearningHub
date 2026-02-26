using LearningHub.SOLID.GoodExample;
using LearningHub.SOLID.OpenClosedPrinciple;
using LearningHub.SOLID.SingleResponsibilityPrinciple.GoodExample;
using LiskovExample;

namespace LearningHub
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IDiscount basicDiscount = new BasicDiscount();
            DiscountCalculator basicCalculator = new DiscountCalculator(basicDiscount);
            decimal basicResult = basicCalculator.Calculate(100);

            IDiscount premiumDiscount = new PremiumDiscount();
            DiscountCalculator premiumCalculator = new DiscountCalculator(premiumDiscount);
            decimal premiumResult = premiumCalculator.Calculate(100);

            Console.WriteLine(basicResult + " " + premiumResult);


            // new RegisterStudent();
            // new SingleResponsibilityPrincipleProgram();
            // new InterfaceProgram();
            // Birds birds = new Birds();
            // birds.Run();
        }
    }
}
