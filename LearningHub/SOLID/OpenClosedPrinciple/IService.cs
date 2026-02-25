namespace LearningHub.SOLID.OpenClosedPrinciple
{
    // Open Closed

    // Open for extension, closed for modification
    // Do not modify this code, but you can extend it by adding new code
    // Unit tests will break 
    // Additional functionality could break or act differently.


    public interface IService
    {
        // Can only use decorator pattern if method is public and included in the interface
        void PrintToConsoleExample();

        int DoSomething(int input);
    }
}
