using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SquareGeometricObject.GeometricInterface;

namespace SquareGeometricObject.GeometricObjects
{
    public class Circle : GeometricObject
    {
        private double radius;

        public Circle(double R)
        {
            if (R <= 0)
                throw new ArithmeticException("The radius must be greater than zero");

            radius = R;
        }

        public override double GetSquare()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

    }
}
