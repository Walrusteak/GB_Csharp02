using System;
using static System.Console;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Test(new TestCase<Exception>(61, true));
            Test(new TestCase<Exception>(67, true));
            Test(new TestCase<Exception>(71, true));
            Test(new TestCase<Exception>(73, true));
            Test(new TestCase<Exception>(79, true));
            Test(new TestCase<Exception>(83, false));
            Test(new TestCase<Exception>(89, false));
            Test(new TestCase<Exception>(97, false));

            Test(new TestCase<Exception>(4, false));
            Test(new TestCase<Exception>(9, false));
            Test(new TestCase<Exception>(15, false));
            Test(new TestCase<Exception>(33, false));
            Test(new TestCase<Exception>(45, true));
            Test(new TestCase<Exception>(99, true));
            Test(new TestCase<Exception>(100, true));

            //Test(new TestCase<ArithmeticException>(0, false));
            //Test(new TestCase<OverflowException>(0, false));
        }

        static bool IsSimple(int n) //немного отошел от блок-схемы в плане типа результата, не бейте
        {
            //if (n == 0)
            //    throw new ArithmeticException("O RLY?");  //чисто для проверки работоспособности теста... т.е. тест для теста... testception?

            int d = 0;
            int i = 2;
            while (i < n)
            {
                if (n % i == 0)
                    d++;
                i++;
            }
            return d == 0;
        }

        static void Test<T>(TestCase<T> testCase) where T : Exception   //только после этого я понял, что IsSimple в принципе не способен выкинуть исключение
        {                                                               //так или иначе, я неплохо провел время в компании дженериков
            try
            {
                bool actual = IsSimple(testCase.N);
                WriteLine(actual == testCase.Expected ? "Valid" : "Invalid");
            }
            catch (Exception ex)
            {
                WriteLine(ex.GetType() == testCase.ExceptionType ? "Valid" : "Invalid");
            }
        }
    }
}
