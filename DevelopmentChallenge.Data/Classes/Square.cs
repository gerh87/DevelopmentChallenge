using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class Square : GeometricShape
    {
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
