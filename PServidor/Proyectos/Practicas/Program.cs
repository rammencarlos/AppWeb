using System;

namespace Practicas
{
    class Program
    {
        static void Main(string[] args)
        {
            Car nombreClase = new Car();
            nombreClase.Model = "Ford";
            nombreClase.Year = 2021;

            Console.WriteLine(nombreClase.Model);
            Console.WriteLine(nombreClase.Year);
            Console.WriteLine(nombreClase.GenerateCar());

            WareHouse wareHouse = new WareHouse();

            string name = wareHouse.GetName();
            Console.WriteLine(name);


        }
    }
}
