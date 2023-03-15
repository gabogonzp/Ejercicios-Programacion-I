using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaCentralita
{
    
        public class Centralita : Llamada
        {
            public List<(string, string)> Lista { get; set; }
            public Centralita(string numOrigen, string numDestino) : base(numOrigen, numDestino)
            {
                Lista = new List<(string, string)>();

                 void AgregarDatos(List<(string, string)> Lista)
                {

                     numOrigen = Console.ReadLine();
                     numDestino = Console.ReadLine();
                    Lista.Add((numOrigen, numDestino));

                    Console.WriteLine(Lista);
                }

            }
        }
    }
    

