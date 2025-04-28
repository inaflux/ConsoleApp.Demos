﻿namespace ConsoleApp.Classes
{
    public class Square : Polygon
    {

        public Square(int width)
        {
            Width = width;
        }
        public override int Area()
        {
            return Width * Width;
        }
    }
}
