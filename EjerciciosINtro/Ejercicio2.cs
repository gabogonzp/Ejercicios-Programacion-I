using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Introductorios
{
    class Ejercicio2
    {
        private static void Main(string[] args)
        {
            int numero;
            int a, b;
            int suma = 0;


            Console.Write("Introduzca numero de dos digitos:");
            numero = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    suma++;
                }
            }

            if (suma > 2 & numero > 0)
            {
                Console.WriteLine("{0} No es un numero primo y negativo", numero);

            }
            else
            {
                Console.WriteLine("{0}  es un numero primo y negativo", numero);
            }


            Console.ReadKey();


        }
    }
}

