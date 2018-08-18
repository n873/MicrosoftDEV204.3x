using System;

namespace Shape
{
    public abstract class Shape
    {


    }

    public class Cyclinder : Shape {

        public Cyclinder(decimal radius, decimal height)
        {
            Radius = radius;
            Height = height;
        }

        public decimal Radius { get; }
        public decimal Height { get; }
    }
}
