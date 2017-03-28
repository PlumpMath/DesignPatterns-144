using System;

namespace dpSingleton
{
    public class Singleton
    {
        private static Singleton _instance;
        private Random _random = new Random();

        private int prevGen = 100;

        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Singleton();

                return _instance;
            }
        }

        public int Next
        {
            get
            {
                prevGen = _random.Next(prevGen);
                return prevGen;
            }
        }

        private Singleton()
        {
            Console.WriteLine("Instance Created");
        }



    }
}