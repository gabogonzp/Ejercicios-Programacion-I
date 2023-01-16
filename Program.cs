using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int a, b;
            int suma = 0;


            Console.Write("Introduzca numero de dos digitos:");
            numero = Convert.ToInt32(Console.ReadLine());


            a = numero % 10;
            b = numero / 10;
            suma = a + b;

            Console.WriteLine(suma);
            Console.ReadKey();


        }
    }
}
