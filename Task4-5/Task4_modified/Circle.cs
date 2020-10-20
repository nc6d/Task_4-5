using System;
using System.Collections.Generic;
using System.Text;

namespace Task4_modified
{
    class Circle
    {
         public static double VectorLength(double x1, double y1, double x2, double y2)
        {
            double stdVector = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return stdVector;
        }
        public static double CircleSquare(double r)
        {
            double square = r * r * Math.PI;
            return square;
        }

        public static double CircleLength(double r)
        {
            double length = 2 * Math.PI * r;
            return length;
        }

        public static double ZoomingTheCricle(ref double radiusVector, ref double zoom)
        {
            double zoomedRadiusVector = radiusVector * zoom;
            return zoomedRadiusVector;
        }
    }
}
