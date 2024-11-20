using DevelopmentChallenge.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Shapes
{
    public class Square : GeometricShape
    {
        public decimal Side { get; set; }
        public override string Type => ShapeEnum.Square.ToString();

        public override decimal CalculateArea()
        {
            return Side * Side;
        }

        public override decimal CalculatePerimeter()
        {
            return Side * 4;
        }
    }
}
