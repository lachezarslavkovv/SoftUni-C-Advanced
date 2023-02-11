using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{

    public class Engine
    {
        private int horsePower;

        public int HorsePower
        {
            get { return horsePower; }
            set { horsePower = value; }
        }

        private double cubicCapacity;

        public double CubicCapacity
        {
            get { return cubicCapacity; }
            set { cubicCapacity = value; }
        }
        public Engine(int horsePower, double cubicCapacity)
        {
            HorsePower = horsePower;
            CubicCapacity = cubicCapacity;
        }


    }

     public class Tire
    {
        private int year;

        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        private double pressure;

        public double Pressure
        {
            get { return pressure; }
            set { pressure = value; }
        }

        public Tire(int year, double pressure)
        {
            Year = year;
            Pressure = pressure;
        }
    }
    class Car
    {
        private string make;

        public string Make // = "VW";
        {
            get { return make; }
            set { make = value; }
        }
        private string model;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        private int year;

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        private double fuelQuantity;

        public double FuelQuantity
        {
            get { return fuelQuantity; }
            set { fuelQuantity = value; }
        }
        private double fuelConsumption;

        public double FuelConsumption
        {
            get { return fuelConsumption; }
            set { fuelConsumption = value; }
        }



        public Car()
        {
            Make = "VW";
            Model = "Golf";
            Year = 2025;
            FuelQuantity = 200;
            FuelConsumption = 10;

        }

        public Car(string make, string model, int year) : this()
        {
            Make = make;
            Model = model;
            Year = year;

        }
        public Car(string make, string model, int year, double fuelQuantity, double fuelCons) : this(make, model,year)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelCons;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelCons, Engine engine, Tire[] tires) 
            : this(make, model, year, fuelQuantity, fuelCons)
        {
            Engine = engine;
            Tires = tires;
        }
        public void Drive(double distance)
        {
            if (FuelQuantity - distance * fuelConsumption > 0)
            {
                FuelQuantity -= distance * fuelConsumption;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }
        public string WhoAmI()
        {
            return $"Make: { this.Make}\nModel: { this.Model}\nYear: { this.Year}\nFuel: { this.FuelQuantity:F2}";
        }

        public Engine Engine { get; set; }
        public Tire[] Tires { get; set; }




    }
}
