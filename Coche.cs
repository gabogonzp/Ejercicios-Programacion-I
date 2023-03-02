using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Coche
    {
        private Motor _Motor { get; set; }

        public string _Marca { get; set; }

        public  string _Modelo { get; set; }

        public double _Precio_Acumulado { get; set; }

        public Coche(string marca, string modelo)
        {
            _Marca = marca;
            _Modelo = modelo;
        }

        
       
    }
}
