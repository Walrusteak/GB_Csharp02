using static System.Console;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine(Recursive(3));
            WriteLine(Recursive(5));
            WriteLine(Recursive(10));
            WriteLine();
            WriteLine(Cyclic(3));
            WriteLine(Cyclic(5));
            WriteLine(Cyclic(10));
        }

        static int Recursive(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;
            return Recursive(n - 2) + Recursive(n - 1);
        }

        static int Cyclic(int n)
        {
            int a = 0;
            int b = 1;
            int c = 0;
            for (int i = 0; i <= n; i++)
            {
                if (i <= 1)
                    c = i;
                else
                {
                    c = a + b;
                    a = b;
                    b = c;
                };
            }
            return c;
        }
    }
}
