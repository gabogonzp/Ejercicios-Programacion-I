using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1; int numero2;int resultado;

            Console.WriteLine("Introduzca un primer numero entero:");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca un segundo numero entero:");
            numero2 = Convert.ToInt32(Console.ReadLine());

            resultado = numero1 - numero2;

            if(10>=resultado)
                for (int i = 1; i <= resultado; i++)
                {
                    Console.Write("{0}", i);
                }
            Console.ReadKey();

        }
    }
}
