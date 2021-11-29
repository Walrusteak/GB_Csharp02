using System;
using System.Collections.Generic;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 3, 6, 1, 36, 17, 22, 8, 3, 6, 9, 0, 11, 34, 2, 0, 5, 1, 3, 8, 14 };
            List<int> b = BucketSort(a);
            b.ForEach(n => Console.Write($"{n} "));
        }

        static List<int> BucketSort(int[] array, int bucketsNumber = 10)
        {
            List<int> sortedArray = new List<int>();
            List<int>[] buckets = new List<int>[bucketsNumber];
            for (int i = 0; i < bucketsNumber; i++)
                buckets[i] = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                int bucket = array[i] / bucketsNumber;
                buckets[bucket].Add(array[i]);
            }

            for (int i = 0; i < bucketsNumber; i++)
            {
                buckets[i].Sort();
                sortedArray.AddRange(buckets[i]);
            }
            return sortedArray;
        }
    }
}
