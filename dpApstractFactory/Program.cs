using System;

namespace dpApstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var abFactory = FactoryProducer.GetFactory("Shape");
            var shape = abFactory.CreateShape("Reactangle");
            shape.Draw();

            abFactory = FactoryProducer.GetFactory("Color");
            var fillColor = abFactory.CreateColor("Red");
            fillColor.Fill();
        }
    }
}
