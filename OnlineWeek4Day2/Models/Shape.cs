using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineWeek4Day2.Models
{
    public abstract class Shape
    {
        public double X { get; set; }
        public double? Y { get; set; }
        public double? Z { get; set; }

        public abstract double GetArea();

        public Shape(double x)
        {
            X = x;
        }

        public Shape(double x, double y)
            : this(x)
        {
            Y = y;
        }

        public Shape(double x, double y, double z)
            : this(x, y)
        {
            Z = z;
        }
    }
}