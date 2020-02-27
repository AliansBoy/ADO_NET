using PresentationLayer.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            CarController car = new CarController();
            var Result = car.GetCars();
            foreach (var x in Result)
            {
                Console.WriteLine($"{x.Manufacturer}");
                foreach (var z in x.Details)
                {
                    Console.WriteLine($"{z.CarId} {z.Name} {z.Price}");
                }
            }
            Console.ReadKey();
        }
    }
}
