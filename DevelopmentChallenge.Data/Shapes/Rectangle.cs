using DevelopmentChallenge.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Shapes
{
    public class Rectangle : GeometricShape
    {
        public override string Type => ShapeEnum.Rectangle.ToString();
        public decimal Length { get; set; }
        public decimal Width { get; set; }


        public Rectangle(decimal length, decimal width)
        {
            Length = length;
            Width = width;
        }

        public override decimal CalculateArea()
        {
            return Length * Width;
        }
        public override decimal CalculatePerimeter()
        {
            return 2 * (Length + Width);
        }
    }

}
