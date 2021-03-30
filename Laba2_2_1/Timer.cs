using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static Laba2_2_1.Program;

namespace Laba2_2_1
{
    class Timer
    {
        private int seconds { get; set; }

        public void Start(int sec)
        {
            Methods[] met = new Methods[] { First, Second, Third };
            Random rand = new Random();
            while (true)
            {
                Thread.Sleep(sec * 1000);
                int a = rand.Next(0, 3);
                met[a]();
            }
        }
        private static void First()
        {
            string[] phrases = new string[] { "Hello", "Hi", "Hey", "Hi there", "HEY BRO", "Hiya" };
            Random rand = new Random();
            int a = rand.Next(0, 5);
            Console.WriteLine(phrases[a]);
        }
        private static void Second()
        {
            Console.WriteLine("Method 2: (ㆆ_ㆆ)");
        }
        private static void Third()
        {
            Console.WriteLine("Method 3: |  *_*   |  0_0  |    |  -_-  |");
        }
    }
}
