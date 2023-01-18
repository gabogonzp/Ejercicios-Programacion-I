using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioBisiesto
{
    class Program
    {
        static void Main(string[] args)
        {
            int anio = 0;
            Console.WriteLine("Bienvenido a la calculadora de año bisiesto, introduzca el año que desee comprobar:");
            anio = Convert.ToInt32(Console.ReadLine());

            biSiesto(anio);

            Console.ReadKey();
        }

        private static bool biSiesto(int anio)
        {
            if ((anio%4)==0 && (anio%400==0))
            {
                Console.WriteLine("{0} es un año bisiesto", anio);

            }

            else
            {
                Console.WriteLine("{0} no es un año bisiesto", anio);
            }

            return true;
               
        }
    }
}
