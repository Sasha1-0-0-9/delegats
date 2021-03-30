using System;

namespace Laba2_2_1
{
    class Program
    {
        delegate void Deledate(int sec);

        public delegate void Methods();
        static void Main(string[] args)
        {
            Console.Write("Введiть t: ");
            int sec = int.Parse(Console.ReadLine());
            Timer timer = new Timer();
            Deledate del = timer.Start;
            del.Invoke(sec);
        }
    }
}
