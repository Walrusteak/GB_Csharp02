using BenchmarkDotNet.Attributes;
namespace Task01
{
    public class BenchmarkClass
    {
        [Benchmark]
        public void TestFloatClass()
        {
            PointFloatClass.PointDistance(new PointFloatClass() { X = 10, Y = 50 }, new PointFloatClass() { X = -50, Y = 100 });
        }

        [Benchmark]
        public void TestFloatStruct()
        {
            PointFloatStruct.PointDistance(new PointFloatStruct() { X = 10, Y = 50 }, new PointFloatStruct() { X = -50, Y = 100 });
        }

        [Benchmark]
        public void TestFloatStructShort()
        {
            PointFloatStruct.PointDistanceShort(new PointFloatStruct() { X = 10, Y = 50 }, new PointFloatStruct() { X = -50, Y = 100 });
        }

        [Benchmark]
        public void TestDoubleStruct()
        {
            PointDoubleStruct.PointDistance(new PointDoubleStruct() { X = 10, Y = 50 }, new PointDoubleStruct() { X = -50, Y = 100 });
        }
    }

    public class BenchmarkClassPreCreated
    {
        PointFloatClass pfc1 = new() { X = 10, Y = 50 };
        PointFloatClass pfc2 = new() { X = -50, Y = 100 };
        PointFloatStruct pfs1 = new() { X = 10, Y = 50 };
        PointFloatStruct pfs2 = new() { X = -50, Y = 100 };
        PointDoubleStruct pds1 = new() { X = 10, Y = 50 };
        PointDoubleStruct pds2 = new() { X = -50, Y = 100 };

        [Benchmark]
        public void TestFloatClass()
        {
            PointFloatClass.PointDistance(pfc1, pfc2);
        }

        [Benchmark]
        public void TestFloatStruct()
        {
            PointFloatStruct.PointDistance(pfs1, pfs2);
        }

        [Benchmark]
        public void TestFloatStructShort()
        {
            PointFloatStruct.PointDistanceShort(pfs1, pfs2);
        }

        [Benchmark]
        public void TestDoubleStruct()
        {
            PointDoubleStruct.PointDistance(pds1, pds2);
        }
    }
}
