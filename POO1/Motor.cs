using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{

    public class Motor
    {
        
        public int litros_de_aceite { get; set; }



        private int Potencia { get; set; }

        public Motor(int potencia)
        {
            Potencia = potencia;
            litros_de_aceite = 0;
        }


    }
}
