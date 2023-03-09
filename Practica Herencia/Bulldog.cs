using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploHerencia
{
    public class Bulldog:Perro
    {
        public override string Ladrar()
        {
            return $"\nEl bulldog esta ladrando.";
        }

        public override string Comer()
        {
            return $"\nEl bulldog esta comiendo.";
        }

        public override string Correr()
        {
            return $"\nEl bulldog esta corriendo.";
        }

        public override string Kgar()
        {
            return $"\nEl bulldog esta haciendo su diligencia...";
        }


        public override string Dormir()
        {
            return $"\nEl bulldog se fue a mimir.";
        }
    }
}
