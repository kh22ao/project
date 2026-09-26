using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        
       

class Vehicle
    {
        public string Brand;
        public int Year;

        public Vehicle(string brand, int year)
        {
            Brand = brand;
            Year = year;
        }

        public virtual void Start()
        {
            Console.WriteLine($"{Brand} vehicle is starting.");
        }
    }

    class Car : Vehicle
    {
        public int NumberOfDoors;

        public Car(string brand, int year, int numberOfDoors)
            : base(brand, year)
        {
            NumberOfDoors = numberOfDoors;
        }

        public override void Start()
        {
            Console.WriteLine($"{Brand} Car is starting.");
        }
    }

    class Bus : Vehicle
    {
        public int Capacity;

        public Bus(string brand, int year, int capacity)
            : base(brand, year)
        {
            Capacity = capacity;
        }

        public override void Start()
        {
            Console.WriteLine($"{Brand} Bus is starting.");
        }
    }

    class Motorcycle : Vehicle
    {
        public bool HasSidecar;

        public Motorcycle(string brand, int year, bool hasSidecar)
            : base(brand, year)
        {
            HasSidecar = hasSidecar;
        }

        public override void Start()
        {
            Console.WriteLine($"{Brand} Motorcycle is starting.");
        }
    }

    
    
        static void Main()
        {
            Car car = new Car("Toyota", 2022, 4);
            Bus bus = new Bus("Mercedes", 2020, 50);
            Motorcycle motorcycle = new Motorcycle("Honda", 2023, false);

            car.Start();
            bus.Start();
            motorcycle.Start();
        }
    }















}
    

