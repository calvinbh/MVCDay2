using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineWeek4Day2.Models
{
    public class Square : Shape
    {
        public Square(double x, double y)
            : base(x, y)
        {
        }

        public override double GetArea()
        {
            return X * Y.Value;
        }
    }
}