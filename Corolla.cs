namespace InterfaceImplementation
{
    public class Corolla : Icar
    {
        public Brand brandName()
        {
            return Brand.toyota;
        }

        public int NumberOfWheel()
        {
            return 4;
        }

        public Color standardColor()
        {
            return Color.black;
        }
    }
}