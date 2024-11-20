using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class Trienagle : GeometricShape
    {
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
