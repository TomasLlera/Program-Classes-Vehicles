using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motos
{
    internal class Vehiculo // Clase Vehículo Padre
    {
        public string Marca { get; set; }
        public int VelocidadMaxima { get; set; } // Propiedades

        public Vehiculo(string marca, int velocidadMaxima) // Constructor
        {
            Marca = marca;
            VelocidadMaxima = velocidadMaxima;
        }
        public virtual void MostrarInformacion() // Método
        {
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Velocidad máxima: " + VelocidadMaxima);
        }
    }
}
