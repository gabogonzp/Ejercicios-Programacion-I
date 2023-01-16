using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Introductorios
{
    class Ejercicio4
    {
        private static void Main(string[] args)
        {

            int number, a, b,suma;

            Console.WriteLine("Introduzca numero de dos digitos:");
            number = Convert.ToInt32(Console.ReadLine());

            a = number / 10;
            b = number % 10;
            suma = a + b;



            if (NumPrimo(suma))
            {
                Console.WriteLine("{0} es un numero primo", suma);
            }
            else
            {
                Console.WriteLine("{0} no es un numero primo", suma);
            }

            

            Console.ReadKey();
        }

        private static bool NumPrimo(int numero)
        {
            for (int i = 2; i < numero; i++)
            {
                if ((numero % i) == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            return true;

        }

    }

}

