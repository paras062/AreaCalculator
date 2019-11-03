using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculator
{
    public class Circle : Shape
    {
        protected double radius;
        public Circle(double r)
        {
            radius = r;
        }

        //getRadius
        public double GetRadius()
        {

            return radius;
        }

        //setRadius
        public void SetRadius(double r)
        {
            radius = r;

        }

        //Area
        public override double GetArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

    }
}