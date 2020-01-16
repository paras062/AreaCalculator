using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculator
{
    public class Rectangle : IQuardilateral
    {
        private double width;
        private double height;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="h"></param>
        /// <param name="w"></param>
        public Rectangle(double h, double w) {
            height = h;
            width = w;
        }

        /// <summary>
        /// GetWidth Method
        /// </summary>
        /// <returns></returns>
        public double getWidth()
        {
            return width;
        }

        /// <summary>
        /// Set Width Method
        /// </summary>
        /// <param name="width"></param>
        public void setWidth(int width)
        {
            this.width = width;
        }

        /// <summary>
        /// Get Height Method
        /// </summary>
        /// <returns></returns>
        public double getHeight()
        {
            return height;

        }

        /// <summary>
        /// Set height method
        /// </summary>
        /// <param name="height"></param>
        public void setHeight(int height)
        {
            this.height = height;

        }
        /// <summary>
        /// Get Area Method implemented from interface Quardilateral Class
        /// </summary>
        /// <returns></returns>

        public double calculateArea()
        {
            return height * width;
        }
    }
}
