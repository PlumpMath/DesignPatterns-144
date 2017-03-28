namespace dpApstractFactory
{
    public static class FactoryProducer
    {
        public static IAbstractFactory GetFactory(string choice)
        {
            switch(choice.ToLower().Trim())
            {
                case "shape":
                    return new ShapeFactory();
                case "color":
                    return new ColoeFactory();
                default:
                    return null;
            }
        }
    }
}