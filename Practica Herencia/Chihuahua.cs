using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploHerencia
{
    public class Chihuahua : Perro
    {
        public override string Ladrar()
        {
            return $"\nEl chihuahua esta ladrando.";
        }

        public override string Comer()
        {
            return $"\nEl chihuahua esta comiendo.";
        }

        public override string Correr()
        {
            return $"\nEl chihuahua esta corriendo.";
        }

        public override string Kgar()
        {
            return $"\nEl chihuahua esta haciendo su diligencia...";
        }


        public override string Dormir()
        {
            return $"\nEl chihuahua se fue a mimir.";
        }
    }
}
