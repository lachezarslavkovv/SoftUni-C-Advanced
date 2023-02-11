using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string make = Console.ReadLine();
            string model = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());
            double fuelQuantity = double.Parse(Console.ReadLine());
            double fuelCons = double.Parse(Console.ReadLine());

            Car firstCar = new Car();
            Car secondCar = new Car(make, model, year);
            Car thiurdCar = new Car(make, model, year, fuelQuantity, fuelCons);


            Console.WriteLine(firstCar.WhoAmI());
            Console.WriteLine(secondCar.WhoAmI());
            Console.WriteLine(thiurdCar.WhoAmI());

        }
    }
}
