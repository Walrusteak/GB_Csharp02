using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] arr;
            arr = new int[random.Next(1, 100)];
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0)
                    arr[i] = random.Next(-1000, 1000);
                else
                    arr[i] = random.Next(arr[i - 1] + 1, arr[i - 1] + 1000);
            }
            int number = arr[random.Next(0, arr.Length)];
            Console.WriteLine($"Длина массива: {arr.Length}");
            Console.WriteLine($"Искомое число: {number}");
            int pos = BinarySearch(arr, number);
            Console.WriteLine($"Найденная позиция: {pos}");
            Console.WriteLine($"Найденное число: {arr[pos]}");
        }

        public static int BinarySearch(int[] inputArray, int searchValue)   //сложность O(n)
        {
            int min = 0;
            int max = inputArray.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (searchValue == inputArray[mid])
                    return mid;
                else if (searchValue < inputArray[mid])
                    max = mid - 1;
                else
                    min = mid + 1;
            }
            return -1;
        }
    }
}
