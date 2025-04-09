using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_practicum
{
    class Garage
    {
        private List<Bicycle> bicycles = new List<Bicycle>();
        private List<Car> cars = new List<Car>();
        private List<Lorry> lorrys = new List<Lorry>();

        public void AddBicycle(Bicycle bicycle) => bicycles.Add(bicycle);
        public void AddCar(Car car) => cars.Add(car);
        public void AddLorry(Lorry lorry) => lorrys.Add(lorry);

        public void GetAllBicycle()
        {
            Console.Clear();
            Console.WriteLine("Велосипеды:");
            foreach (var b in bicycles) b.Print();
        }
        public void GetAllCar()
        {
            Console.Clear();
            Console.WriteLine("Машины:");
            foreach (var c in cars) c.Print();
        }
        public void GetAllLorry()
        {
            Console.Clear();
            Console.WriteLine("Грузовики:");
            foreach (var l in lorrys) l.Print();
        }
        public void GetAllVehicles()
        {
            Console.Clear();
            var allVehicles = new List<Vehicle>();
            allVehicles.AddRange(bicycles);
            allVehicles.AddRange(cars);
            allVehicles.AddRange(lorrys);
            Console.WriteLine("Все транспортные средства:");
            foreach (var b in allVehicles)
            {
                b.Print();
            }
        }
    }

}
