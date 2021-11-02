using System;
namespace Task01
{
    public class TestCase<T> where T : Exception    //мне стало скучно
    {
        public int N { get; }
        public bool Expected { get; }
        public Type ExceptionType => typeof(T);

        public TestCase(int n, bool expected)
        {
            N = n;
            Expected = expected;
        }
    }
}
