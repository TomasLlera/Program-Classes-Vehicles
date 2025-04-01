using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motos
{
    internal class Program
    {
        static void Main(string[] args) // Método principal
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>() // Lista de vehículos
        {
            new Auto("Toyota", 200, 4),
            new Moto("Yamaha", 150, false),
            new Auto("Ford", 180, 2),
            new Moto("Harley-Davidson", 160, true) // Creación de objetos
        };

            Console.WriteLine("Información de los vehículos:");
            Console.WriteLine("====================================");

            foreach (var vehiculo in vehiculos)
            {
                Console.WriteLine("------------------------------------");
                vehiculo.MostrarInformacion();
                Console.WriteLine("------------------------------------");
            }

            Console.WriteLine("====================================");
            Console.ReadKey(); 
        }
    }
}
