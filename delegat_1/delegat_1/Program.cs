using System;
namespace delegat_1
{

    static class Program
    {
        delegate double Delegat(double yourNumber);
        static double AddNumberToDefaultValue(double yourNumber) => yourNumber + 3.5;
        static double SquareRootOfNumberModule(double yourNumber) => Math.Sqrt(Math.Abs(yourNumber));
        static double NumberInThirdDegree(double yourNumber) => Math.Pow(yourNumber, 3);
        

        static void Main(string[] args)
        {
            Console.Write("Виводьте рядки послідовно один за одним\n" +
                "Поки вони матимуть вигляд 0х, чи 1х, чи 2х\n" +
                "(тобто цифра від 0 до 2, а після неї запис конкретного дійсного числа),\n" +
                "програма обчислюватиме одну з трьох функцій\n" +
                "\t0 - sqrt(abs(x))\n" +
                "\t1 - x^3(інакше кажучи х*х*х)\n" +
                "\t2 - х + 3,5\n" +
                "згідно цифри на початку і виводитиме результат.\n" +
                "\nЯкщо вхідний рядок не задовольняє цей формат, програма завершить роботу.\n");

            Delegat[] delegat = new Delegat[3] { SquareRootOfNumberModule, NumberInThirdDegree, AddNumberToDefaultValue };
            while (true)
            {
                try
                {
                    string[] data = Console.ReadLine().Split(' ');
                    int operation = int.Parse(data[0]);
                    double num = int.Parse(data[1]);
                    Console.WriteLine(delegat[operation](num));
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введені дані не задовольняють потрібний формат. Натисніть будь-яку клавішу для виходу.");
                    Console.ReadKey();
                    break;
                }
            }
        }
    }
}
