using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Shapes
{
    public abstract class GeometricShape
    {
        public abstract string Type { get; }
        public abstract decimal CalculateArea();
        public abstract decimal CalculatePerimeter();
    }
}
