

namespace LearningHub.SOLID.OpenClosedPrinciple
{
    public class Service
    {
        public int DontModifyMe(int number)
        {
            Console.WriteLine("Hello please do not modify me I am old.");

            return number + 2;
        }
    }
}
