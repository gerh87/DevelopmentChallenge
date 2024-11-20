using DevelopmentChallenge.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Shapes
{
    public class Trapezoid : GeometricShape
    {
        public decimal BaseMajor { get; set; }
        public decimal BaseMinor { get; set; }
        public decimal Height { get; set; }
        public decimal Side1 { get; set; }
        public decimal Side2 { get; set; }

        public override string Type => ShapeEnum.Trapezoid.ToString();

        public Trapezoid(decimal baseMajor, decimal baseMinor, decimal height, decimal side1, decimal side2)
        {
            BaseMajor = baseMajor;
            BaseMinor = baseMinor;
            Height = height;
            Side1 = side1;
            Side2 = side2;
        }

        public override decimal CalculateArea()
        {
            return (BaseMajor + BaseMinor) * Height / 2;
        }

        public override decimal CalculatePerimeter()
        {
            return BaseMajor + BaseMinor + Side1 + Side2;
        }
    }

}
