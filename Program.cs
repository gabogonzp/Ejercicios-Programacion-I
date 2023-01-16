using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero; int mayor = 0; int digito1 = 0; int digito2 = 0; int digito3 = 0;


            Console.WriteLine("Introduzca un numero de tres digitos:");
            numero = Convert.ToInt32(Console.ReadLine());

            digito1 = numero / 100;
            digito2 = (numero / 10) % 10;
            digito3 = numero % 10;

            if (digito1 % digito2 == 0)
                Console.WriteLine("{0} es un multiplo de {1}", digito1, digito2);
            if(digito1 %digito3 ==0)
                Console.WriteLine("{0} es un multiplo de {1}", digito1, digito3);
            if (digito2 % digito3 == 0)
                Console.WriteLine("{0} es un multiplo de {1}", digito2, digito3);
            if (digito2 % digito1 == 0)
                Console.WriteLine("{0} es un multiplo de {1}", digito3, digito1);
            if (digito3 % digito2 == 0)
                Console.WriteLine("{0} es un multiplo de {1}", digito3, digito2);
            if (digito3 % digito2 == 0)
                Console.WriteLine("{0} es un multiplo de {1}", digito1, digito3);


            Console.ReadKey();
        }
    }
}
