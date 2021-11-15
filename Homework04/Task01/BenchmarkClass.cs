using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using System;

namespace Task01
{
    public class BenchmarkClass
    {
        public Test test;

        [ParamsSource(nameof(Strings))]
        public string Str { get; set; }

        public IEnumerable<string> Strings { get; set; }

        public BenchmarkClass()
        {
            Random random = new();
            test = new();
            Strings = Enumerable.Range(1, 5).Select(_ => test.array[random.Next(0, 10000)]);
        }

        [Benchmark]
        public void TestHashSet()
        {
            test.SearchHashSet(Str);
        }

        [Benchmark]
        public void TestArray()
        {
            test.SearchArray(Str);
        }
    }
}
