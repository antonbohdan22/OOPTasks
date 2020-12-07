using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStock
{
    class Runner
    {
        static void Main(string[] args)
        {
            Car[] cars = new Car[9];
            cars[0] = new Car("Mercedes-Benz", "C220", "Grey", 2002, 4700);
            cars[1] = new Car("Mercedes-Benz", "E63AMG", "Black", 2015, 69000);
            cars[2] = new Car("BMW", "X5", "Red", 2008, 11320);
            cars[3] = new Car("Opel", "Meriva", "Blue", 2007, 4850);
            cars[4] = new Car("Renault", "Scenic", "Brown", 2011, 6400);
            cars[5] = new Car("Audi", "Q8", "Yellow", 2020, 106365);
            cars[6] = new Car("Vokswagen", "Passat B7", "Grey", 2012, 11500);
            cars[7] = new Car("Honda", "Civic", "Dark Blue", 2017, 18200);
            cars[8] = new Car("Toyota", "Corolla", "Light Grey", 2016, 17260);

            foreach (Car car in cars)
            {
                if ((car.Price < 20000) && (DateTime.Now.Year - car.ReleaseYear < 10))
                {
                    Console.WriteLine("{0} {1} {2}", car.Manufacturer, car.Model, car.Color);
                }
            }
            Console.ReadKey();
        }
    }
}
