using LearningHub.SOLID.DependencyInversionPrinciple;
using LearningHub.SOLID.InterfaceSegregationPrinciple;
using LearningHub.SOLID.OpenClosedPrinciple;
using LearningHub.SOLID.SingleResponsibilityPrinciple.GoodExample;
using LiskovExample;

namespace LearningHub.SOLID
{
    public class SolidProgram
    {
        public SolidProgram()
        {

            Console.WriteLine("\n Single Responsibility Principle \n *********************************** \n");
            new RegisterStudent();

            Console.WriteLine("\n Open Closed Principle \n *********************************** \n");

            IDiscount basicDiscount = new BasicDiscount();
            DiscountCalculator basicCalculator = new DiscountCalculator(basicDiscount);
            decimal basicResult = basicCalculator.Calculate(100);

            IDiscount premiumDiscount = new PremiumDiscount();
            DiscountCalculator premiumCalculator = new DiscountCalculator(premiumDiscount);
            decimal premiumResult = premiumCalculator.Calculate(100);

            Console.WriteLine(basicResult + " " + premiumResult);

            Console.WriteLine("\n Liskov Substitution Principle \n *********************************** \n");

            Birds birds = new Birds();
            birds.Run();

            Console.WriteLine("\n Interface Segregation Principle \n *********************************** \n");

            BitcoinProcessor bitcoinProcessor = new BitcoinProcessor();
            bitcoinProcessor.ProcessPayment(100);

            Console.WriteLine("\n Dependency Inversion Principle \n *********************************** \n");
            SMSService phoneService = new SMSService();
            phoneService.SendMessage("Hello world!");

            EmailService emailService = new EmailService();
            emailService.SendMessage("Hellow world!");

            Console.WriteLine("\n NOTES \n *********************************** \n SRP is to do with a single responsibility \n OCP is to do with being open for extension but closed for modification \n LSP is to do with subsituting subclasses for base classes \n ISP is to do with interfaces and not forcing clients to depend on methods they do not use \n DIP is to do with depending on abstractions rather than concrete implementations");
        }
    }
}
