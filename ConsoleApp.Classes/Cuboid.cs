namespace ConsoleApp.Classes
{
    public partial class Rectangle
    {
        public class Cuboid : Polygon, I2DShape, I3DShape
        {
            public interface ICircularShape
            {
                decimal Circumference();
            }
            public override int Area() 
            {
                throw new NotImplementedException();
            }
            public int Perimeter()
            {
                throw new NotImplementedException();
            }

            public int Volume()
            {
                throw new NotImplementedException();
            }
        }
    }
}
