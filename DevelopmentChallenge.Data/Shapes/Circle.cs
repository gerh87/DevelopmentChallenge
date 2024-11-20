using DevelopmentChallenge.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Shapes
{
    public class Circle : GeometricShape
    {
        public decimal Radio { get; set; }
        public override string Type => ShapeEnum.Circle.ToString();

        public override decimal CalculateArea()
        {
            return (decimal)Math.PI * (Radio / 2) * (Radio / 2);
        }

        public override decimal CalculatePerimeter()
        {
            return (decimal)Math.PI * Radio;
        }
    }
}
