using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motos
{
    internal class Auto : Vehiculo // Clase Auto que hereda de Vehículo
    {
        public int CantPuertas { get; set; } // Propiedad

        public Auto(string marca, int velocidadMaxima, int cantPuertas) : base(marca, velocidadMaxima) // Constructor
        {
            Marca = marca; 
            VelocidadMaxima = velocidadMaxima;
            CantPuertas = cantPuertas;
        }
        public override void MostrarInformacion() // Método
        {
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Velocidad máxima: " + VelocidadMaxima);
            Console.WriteLine("Cantidad de puertas: " + CantPuertas);
        }
    }
}
