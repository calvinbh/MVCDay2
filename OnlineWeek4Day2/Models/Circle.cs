using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineWeek4Day2.Models
{
    public class Circle : Shape
    {
        /// <summary>
        /// Creates a new Circle object using 1 paramater.
        /// </summary>
        /// <param name="radius">The Radius of the Circle</param>
        public Circle(double radius)
            : base(radius)
        {
        }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(X, 2);
        }
    }
}