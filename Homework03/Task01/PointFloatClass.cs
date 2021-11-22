using System;
namespace Task01
{
    public class PointFloatClass
    {
        public float X { get; set; }
        public float Y { get; set; }

        public static float PointDistance(PointFloatClass p1, PointFloatClass p2)
        {
            float x = p1.X - p2.X;
            float y = p1.Y - p2.Y;
            return MathF.Sqrt(x * x + y * y);
        }
    }
}
