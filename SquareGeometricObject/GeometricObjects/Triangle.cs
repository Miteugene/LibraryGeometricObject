using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SquareGeometricObject.GeometricInterface;

namespace SquareGeometricObject.GeometricObjects
{
    public class Triangle : GeometricObject
    {
        private double sideA;
        private double sideB;
        private double sideC;

        public Triangle(double A, double B, double C)
        {
            if ( (A <= 0) || (B <= 0) || (C <= 0) )
                throw new ArithmeticException("The length of the side of the triangle must be greater than zero");

            if ( (A + B <= C) ||
                 (B + C <= A) ||
                 (A + C <= B) 
               )
                throw new ArithmeticException("This is not a triangle");

            sideA = A;
            sideB = B;
            sideC = C;
        }

        public double GetPerimeter()
        {
            return sideA + sideB + sideC;
        }

        public override double GetSquare()
        {
            var halfPerimeter = GetPerimeter() / 2;
            return Math.Sqrt( halfPerimeter * (halfPerimeter - sideA) * (halfPerimeter - sideB) * (halfPerimeter - sideC) );
        }


    }
}
