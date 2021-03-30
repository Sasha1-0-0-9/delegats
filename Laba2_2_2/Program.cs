using System;

namespace Laba2_2_2
{
    class Program
    {
        public delegate void Dividor(int[] arr);
        static void Main(string[] args)
        {
            int[] arr = {3, 7, 21, -21, 30, 77, 33, 49};
            Dividor d3 = new Dividor(IsDiv3);
            Dividor d7 = new Dividor(IsDiv7);
            d3(arr);
            d7.Invoke(arr);
            Console.ReadKey();
        }
        public static void IsDiv3(int[] arr)
        {
            Console.WriteLine("Діляться на 3: ");
            foreach (int a in arr)
            {
                if (a % 3 == 0)
                {
                    Console.Write(a + " ");
                }
            }
            Console.WriteLine();
        }
        public static void IsDiv7(int[] arr)
        {
            Console.WriteLine("Діляться на 7: ");
            foreach (int a in arr)
            {
                if (a % 7 == 0)
                {
                    Console.Write(a + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
