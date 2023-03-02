using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Garaje
    {
        private Coche[] _coche;
        private int _limite;
        private int _numCoches;

        public Garaje(int limite)
        {
            this._coche = new Coche[limite];
            _limite = limite;
            _numCoches = 0;
        }

        public void aceptarCoche(Coche a)
        {
            if (a != null && _numCoches < 1)
            {
                _coche[_numCoches] = a;
                _numCoches++;
            }

        }

        public void moverCoche(Coche a)
        {
            if (a!=null && _numCoches != 0)
            {
                _coche[1] = null;
            }
        }


       public Coche coche { get; set; }

        public string Averia_asociada { get; set; }

        public int NumeroAtendidos { get; set; }


    }
}
