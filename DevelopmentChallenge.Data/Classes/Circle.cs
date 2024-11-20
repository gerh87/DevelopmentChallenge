using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class Circle : GeometricShape
    {
        public override decimal CalculateArea()
        {
            return (decimal)Math.PI * (Side / 2) * (Side / 2);
        }

        public override decimal CalculatePerimeter()
        {
            return (decimal)Math.PI * Side;
        }
    }
}
