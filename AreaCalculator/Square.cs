using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculator
{
    public class Square : Shape
    {
        protected double side;


        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="s"></param>
        public Square(double s)
        {
            side = s;
        }

        /// <summary>
        /// getWidth Method
        /// </summary>
        /// <returns></returns>
        public double GetWidth()
        {
            return side;
        }

        /// <summary>
        /// Set Width
        /// </summary>
        /// <param name="s"></param>
        public void SetWidth(double s)
        {
            side = s;
        }

        /// <summary>
        /// Get Area Method implemented from Shape Class
        /// </summary>
        /// <returns></returns>
        public override double GetArea()
        {
            return Math.Pow(side,2);
        }
    }
}
