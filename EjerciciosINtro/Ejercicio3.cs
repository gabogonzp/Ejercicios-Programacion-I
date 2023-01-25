using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Introductorios
{
    class Ejercicio3
    {
        private static void Main(string[] args)
        {

            int number, a, b;

            Console.WriteLine("Introduzca numero de dos digitos:");
            number = Convert.ToInt32(Console.ReadLine());

            a = number / 10;
            b = number % 10;


            if (NumPrimo(a))
            {
                Console.WriteLine("{0} es un numero primo", a);
            }
            else
            {
                Console.WriteLine("{0} no es un numero primo", a);
            }

            if (NumPrimo(b))
            {
                Console.WriteLine("{0} es un numero primo", b);
            }
            else
            {
                Console.WriteLine("{0} no es un numero primo", b);
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
}
