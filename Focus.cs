namespace InterfaceImplementation
{
    public class Focus : Icar
    {
        public Brand brandName()
        {
            return Brand.ford;
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