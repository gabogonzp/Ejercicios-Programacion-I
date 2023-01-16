using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero; int mayor = 0; int digito1 = 0; int digito2 = 0; int digito3=0;


            Console.WriteLine("Introduzca un numero de tres digitos:");
            numero = Convert.ToInt32(Console.ReadLine());

            digito1 = numero / 100;
            digito2 = (numero / 10)%10;
            digito3 = numero % 10;

            if(digito1 > digito2)
                if(digito1>digito3)
                    Console.WriteLine("{0} el digito mayor es:", digito1);
                else if (digito3>digito2)
                    Console.WriteLine("{0} el digito mayor es:", digito3);
                else
                    Console.WriteLine("{0} el digito mayor es:", digito2);
            else if (digito2 > digito3)
                Console.WriteLine("{0} el digito mayor es:", digito2);
            else
                Console.WriteLine("{0} el digito mayor es:", digito3);
           

            Console.ReadKey();






        }
    }
}
