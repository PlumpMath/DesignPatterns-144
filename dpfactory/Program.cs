using System;

namespace hwapp
{
    public interface IProduct
    {
        void Build();
    }

    public class ProductA : IProduct
    {
        public void Build()
        {
            Console.WriteLine("ProductA");
        }
    }

    public class ProductB : IProduct
    {
        public void Build()
        {
            Console.WriteLine("ProductB");
        }
    }

    public class ProductFactory
    {
        public IProduct MakeProduct(string productType)
        {
            if(productType.Equals("ProductA"))
            {
                return new ProductA();
            }
            else if(productType.Equals("ProductB"))
            {
                return new ProductB();
            }
            else
            {
                return null;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var f = new ProductFactory();
            var p  = f.MakeProduct("ProductA");
            p.Build();
            p = f.MakeProduct("ProductB");
            p.Build();
        }
    }
}
