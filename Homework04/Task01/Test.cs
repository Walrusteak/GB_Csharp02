using System;
using System.Collections.Generic;
using System.Linq;

namespace Task01
{
    public class Test
    {
        private const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        private Random random;

        public HashSet<string> hashSet;
        public string[] array;

        public Test()
        {
            random = new();
            hashSet = new(10000);

            while (hashSet.Count < 10000)
                hashSet.Add(RandomString(8, 16));
            array = hashSet.ToArray();
        }

        private string RandomString(int minLen, int maxLen)
        {
            int length = random.Next(minLen, maxLen);
            return new string(Enumerable.Range(1, length).Select(_ => chars[random.Next(chars.Length)]).ToArray());
        }

        public bool SearchHashSet(string str) => hashSet.Contains(str);

        public bool SearchArray(string str) => array.Contains(str);
    }
}
