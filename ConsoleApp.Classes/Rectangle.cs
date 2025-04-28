namespace ConsoleApp.Classes
{
    public partial class Rectangle : Polygon, I2DShape
    {
        public Rectangle(int width ,int length)
        {
            Length = length;
            Width = width;
        }
        public int Length { get; set; }
        public override int Area()
        {
            return Length * Width;
        }

        public int Perimeter()
        {
            return (2 * Length) + (2 * Width);
        }
    }
}
