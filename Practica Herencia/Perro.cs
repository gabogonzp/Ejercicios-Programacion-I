using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploHerencia
{
    public abstract class Perro
    {
       
         public virtual string Ladrar()
        {
            return $"\nPerro ladrando";
        }

        public virtual string Correr()
        {
            return "El perro esta corriendo";
        }

        public virtual string Comer()
        {
            return "El perro esta comiendo";
            
        }

        public virtual string Kgar()
        {
            return "El perro esta haciendo su diligencia";
        }

        public virtual string Dormir()
        {
            return "Perro se fue a dormir...";
        }
    }
}
