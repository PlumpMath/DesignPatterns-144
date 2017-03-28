using System;

namespace dpApstractFactory
{
    public interface IColor
    {
        void Fill();
    }

    public class Red : IColor
    {
        public void Fill()
        {
            Console.WriteLine("Red");
        }
    }

    public class Green : IColor
    {
        public void Fill()
        {
            Console.WriteLine("Green");
        }
    }

    public class Blue : IColor
    {
        public void Fill()
        {
            Console.WriteLine("Blue");
        }
    }

    public class ColoeFactory : IAbstractFactory
    {
        public IColor CreateColor(string color)
        {
            if(color.Equals("Blue"))
            {
                return new Blue();
            }
            else if(color.Equals("Green"))
            {
                return new Green();
            }
            else if(color.Equals("Red"))
            {
                return new Red();
            }
            else
            {
                return null;
            }
        }

        public IShape CreateShape(string shape)
        {
            return null;
        }
    }
}