using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_practicum
{
    class Bicycle : Vehicle
    {
        private int maxPassengers;
        public int MaxPassengers { get => maxPassengers; set => maxPassengers = value; }

        public Bicycle(int price, int maxspeed, int year, int maxPassengers)
            : base(price, maxspeed, year)
        {
            MaxPassengers = maxPassengers;
        }

        public override void Print()
        {
            Console.WriteLine($"Цена: {Price}\tМаксимальная скорость: {Maxspeed}\tГод: {Year}\tМаксимум пассажиров: {MaxPassengers}");
        }

        public static Bicycle Create()
        {
            Console.Clear();
            Console.Write("Введите цену: ");
            int price = int.Parse(Console.ReadLine());
            Console.Write("Введите максимальную скорость: ");
            int speed = int.Parse(Console.ReadLine());
            Console.Write("Введите год: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Введите количество пассажиров: ");
            int passengers = int.Parse(Console.ReadLine());
            return new Bicycle(price, speed, year, passengers);
        }
    }

}
