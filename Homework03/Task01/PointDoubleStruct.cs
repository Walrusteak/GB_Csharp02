using System;
namespace Task01
{
    public struct PointDoubleStruct
    {
        public double X;
        public double Y;

        public static double PointDistance(PointDoubleStruct p1, PointDoubleStruct p2)
        {
            double x = p1.X - p2.X;
            double y = p1.Y - p2.Y;
            return Math.Sqrt(x * x + y * y);
        }
    }
}
