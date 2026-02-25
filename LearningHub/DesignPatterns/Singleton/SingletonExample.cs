namespace LearningHub.DesignPatterns.Singleton
{
    public class SingletonExample
    {
        private static SingletonExample _instance;

        private SingletonExample()
        {
            // Private constructor to prevent instantiation from outside the class

            // the class is public and can access the private constructor

        }
        public static SingletonExample GetInstance()
        {
            if (_instance == null)
            {
                _instance = new SingletonExample();
            }

            return _instance;
        }
    }
}