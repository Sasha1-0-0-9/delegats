using System;

namespace Laba2_2_3
{
    class Program
    {
        public static int Factorial(int b)
        {
            int res = 1;
            for (int i = 1; i <= b; i++)
            {
                res *= i;
            }
            return res;
        }
        public static void Method1(int n)
        {
            double output = 0;
            int bottom = 1;
            for (int i = 1; i <= n; i++)
            {
                output += 1.0 / bottom;
                bottom *= 2;
            }
            Console.WriteLine("Mеthod1: " + output);

        }

        public static void Method2(int n)
        {
            double output = 0;
            for (int i = 1; i <= n; i++)
            {
                output += 1.0 / Factorial(i);
            }
            Console.WriteLine("Method2: " + output);
        }
        public static void Method3(int n)
        {
            double output = 1;
            int bottom = 1;
            if (n % 2 == 1)
            {
                for (int i = 1; i <= n; i++)
                {
                    bottom *= 2;
                    output += 1.0 / bottom;
                    bottom *= 2;
                    output -= 1.0 / bottom;
                }
            }
            else
            {
                for (int i = 1; i <= n - 1; i++)
                {
                    bottom *= 2;
                    output += 1.0 / bottom;
                    bottom *= 2;
                    output -= 1.0 / bottom;
                }
                output += 1.0 / bottom;
            }
            Console.WriteLine("Method3: " + output);
        }

        public delegate void Delegate(int n);


        static void Main(string[] args)
        {
            Console.Write("Введiть точнiсть: ");
            int n = int.Parse(Console.ReadLine());
            Delegate del1 = new Delegate(Method1);
            del1.Invoke(n);
            Delegate del2 = new Delegate(Method2);
            del2.Invoke(n);
            Delegate del3 = new Delegate(Method3);
            del3.Invoke(n);
            Console.ReadKey();
        }

    }
}
