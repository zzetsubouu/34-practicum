using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_practicum
{
    class Lorry : Vehicle
    {
        private int maxCapacity;
        public int MaxCapacity { get => maxCapacity; set => maxCapacity = value; }

        public Lorry(int price, int maxspeed, int year, int maxCapacity)
            : base(price, maxspeed, year)
        {
            MaxCapacity = maxCapacity;
        }

        public override void Print()
        {
            Console.WriteLine($"Цена: {Price}\tМаксимальная скорость: {Maxspeed}\tГод: {Year}\tГрузоподъемность: {MaxCapacity} кг");
        }

        public static Lorry Create()
        {
            Console.Clear();
            Console.Write("Введите цену: ");
            int price = int.Parse(Console.ReadLine());
            Console.Write("Введите максимальную скорость: ");
            int speed = int.Parse(Console.ReadLine());
            Console.Write("Введите год: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Введите грузоподъемность: ");
            int cap = int.Parse(Console.ReadLine());
            return new Lorry(price, speed, year, cap);
        }
    }
}
