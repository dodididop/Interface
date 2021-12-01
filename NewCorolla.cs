namespace InterfaceImplementation
{
    public class NewCorolla : Car
    {
        public override Brand BrandName()
        {
            return Brand.toyota;
        }
        public override Color StandardColor()
        {
            return Color.black;
        }
    }
}