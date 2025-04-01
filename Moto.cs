using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motos
{
    internal class Moto : Vehiculo // Clase Moto que hereda de Vehículo
    {
        public bool TieneCasco { get; set; }

        public Moto(string marca, int velocidadMaxima, bool tieneCasco) // Constructor
            : base(marca, velocidadMaxima)
        {
            TieneCasco = tieneCasco;
        }

        public override void MostrarInformacion() // Método
        {
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Velocidad máxima: " + VelocidadMaxima);
            Console.WriteLine("Tiene casco: " + TieneCasco);
        }
    }
}
