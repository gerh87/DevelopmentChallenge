using DevelopmentChallenge.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Shapes
{
    public class EquilateralTriangle : GeometricShape
    {
        public decimal Side { get; set; }
        public override string Type => ShapeEnum.Triangle.ToString();

        public EquilateralTriangle(decimal side)
        {
            Side = side;
        }

        public override decimal CalculateArea()
        {
            return ((decimal)Math.Sqrt(3) / 4) * Side * Side;
        }

        public override decimal CalculatePerimeter()
        {
            return Side * 3;
        }
    }
}
