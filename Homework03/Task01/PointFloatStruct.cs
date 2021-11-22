using System;
namespace Task01
{
    public struct PointFloatStruct
    {
        public float X { get; set; }
        public float Y { get; set; }

        public static float PointDistance(PointFloatStruct p1, PointFloatStruct p2)
        {
            float x = p1.X - p2.X;
            float y = p1.Y - p2.Y;
            return MathF.Sqrt(x * x + y * y);
        }

        public static float PointDistanceShort(PointFloatStruct p1, PointFloatStruct p2)
        {
            float x = p1.X - p2.X;
            float y = p1.Y - p2.Y;
            return x * x + y * y;
        }
    }
}
