using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_practicum
{
    abstract class Vehicle
    {
        private double price;
        private int maxspeed;
        private int year;

        public double Price
        {
            get => price;
            set => price = value >= 0 ? value : throw new ArgumentException("цена не может быть отрицательной");
        }

        public int Maxspeed
        {
            get => maxspeed;
            set => maxspeed = value > 0 ? value : throw new ArgumentException("скорость должна быть > 0");
        }

        public int Year
        {
            get => year;
            set => year = value >= 1900 && value <= DateTime.Now.Year ? value : throw new ArgumentException("год указан неправильно");
        }

        public Vehicle(double price, int maxspeed, int year)
        {
            Price = price;
            Maxspeed = maxspeed;
            Year = year;
        }
        public abstract void Print();
    }

}
