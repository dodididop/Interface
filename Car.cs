namespace InterfaceImplementation
{
    public abstract class Car{
        public int NumberOfWheel(){
            return 4;
        }
        public virtual Color StandardColor(){
            return Color.white;
        }

        public abstract Brand BrandName();
    }
}