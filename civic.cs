namespace InterfaceImplementation
{
    public class Civic : Icar
    {
        public Brand brandName()
        {
            return Brand.honda;
        }

        public int NumberOfWheel()
        {
            return 4;
        }

        public Color standardColor()
        {
            return Color.white;
        }
    }
}