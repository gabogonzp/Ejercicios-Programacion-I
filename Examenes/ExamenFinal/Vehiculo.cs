using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinalProgI
{
    internal class Vehiculo
    {
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public string Chasis { get; set; }

        public Vehiculo(string placa, string marca, string modelo, string color, int year, string chasis)
        {
            Placa = placa;
            Marca = marca;
            Modelo = modelo;
            Color = color;
            Year = year;
            Chasis = chasis;
        }
    }
}
