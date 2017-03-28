using System;

namespace dpSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = Singleton.Instance;
            Console.WriteLine(s1.Next);

            var s2 = Singleton.Instance;
            Console.WriteLine(s2.Next);

            var s3 = Singleton.Instance;
            Console.WriteLine(s3.Next);
        }
    }
}
