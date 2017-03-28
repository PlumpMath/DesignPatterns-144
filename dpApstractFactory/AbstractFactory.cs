using System;

namespace dpApstractFactory
{
    public interface  IAbstractFactory
    {
        IColor CreateColor(String color);
        IShape CreateShape(String shape) ;
    }
}