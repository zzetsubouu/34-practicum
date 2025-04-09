using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_practicum
{
    class Car : Vehicle
    {
        private int power;
        public int Power { get => power; set => power = value; }

        public Car(int price, int maxspeed, int year, int power)
            : base(price, maxspeed, year)
        {
            Power = power;
        }

        public override void Print()
        {
            Console.WriteLine($"Цена: {Price}\tМаксимальная скорость: {Maxspeed}\tГод: {Year}\tМощность: {Power} л.с.");
        }

        public static Car Create()
        {
            Console.Clear();
            Console.Write("Введите цену: ");
            int price = int.Parse(Console.ReadLine());
            Console.Write("Введите максимальную скорость: ");
            int speed = int.Parse(Console.ReadLine());
            Console.Write("Введите год: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Введите мощность: ");
            int power = int.Parse(Console.ReadLine());
            return new Car(price, speed, year, power);
        }
    }

}
