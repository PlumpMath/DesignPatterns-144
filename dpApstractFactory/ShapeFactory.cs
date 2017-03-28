using System;

namespace dpApstractFactory
{
    public interface IShape
    {
        void Draw();
    }

    public class Reactangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Reactangle");
        }
    }

    public class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Square");
        }
    }

    public class ShapeFactory : IAbstractFactory
    {
        public IColor CreateColor(string color)
        {
            return null;
        }

        public IShape CreateShape(string shape)
        {
            if(shape.Equals("Square"))
            {
                return new Square();
            }
            else if(shape.Equals("Reactangle"))
            {
                return new Reactangle();
            }
            else
            {
                return null;
            }
        }
    }
}