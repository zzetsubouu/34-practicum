using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_practicum
{
    class Program
    {
        static void Main(string[] args)
        {
            Garage garage = new Garage();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nВыберите нужное Вам действие:");
                Console.WriteLine("1. Добавить в список велосипед;");
                Console.WriteLine("2. Добавить в список машину;");
                Console.WriteLine("3. Добавить в список грузовик;");
                Console.WriteLine("4. Вывести все велосипеды из списка;");
                Console.WriteLine("5. Вывести все машины из списка;");
                Console.WriteLine("6. Вывести все грузовики из списка;");
                Console.WriteLine("7. Вывести все машины.");
                Console.WriteLine("8. Выход.");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        garage.AddBicycle(Bicycle.Create());
                        break;
                    case 2:
                        garage.AddCar(Car.Create());
                        break;
                    case 3:
                        garage.AddLorry(Lorry.Create());
                        break;
                    case 4:
                        garage.GetAllBicycle();
                        break;
                    case 5:
                        garage.GetAllCar();
                        break;
                    case 6:
                        garage.GetAllLorry();
                        break;
                    case 7:
                        garage.GetAllVehicles();
                        break;
                    case 8:
                        return;
                    default:
                        Console.WriteLine("Неверный ввод");
                        break;
                }
            }
        }
    }
}
