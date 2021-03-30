using System;

namespace SharpWasher
{
    class Program
    {
        delegate void Wash(Car car);

        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------------------------");
            Garage garage = new Garage();
            Car car1 = new Car("Tesla Model X");
            Car car2 = new Car("BMW X6 M");
            Car car3 = new Car("Ford Mustang GT");
            garage.Add(car1);
            garage.Add(car2);
            garage.Add(car3);
            foreach (var car in garage)
            {
                Console.WriteLine(car.name + " |is clean?|  " + car.clean);

            }
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Пiсля автомийки:");
            foreach (var car in garage)
            {
                Washer washer = new Washer();
                Wash del = washer.Wash;
                del(car);
                Console.WriteLine(car.name + "  |is clean?|  " + car.clean);

            }
            Console.ReadKey();
        }
    }
}
