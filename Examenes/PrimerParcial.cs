using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialProgramacionI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se le pide al usuario su palabra para decodificar
            Console.WriteLine("Introduzca elementos a ser descifrados:");

            //Se lee la palabra y se le asigna a la variable string "codificado"
            string codificado = Console.ReadLine();

            //Se le aplica el metodo "Trans" de la clase "Rot13" a la variable "codificado"
            codificado = Rot13.Trans(codificado);
            Console.WriteLine(codificado);

            Console.ReadKey();
        }
        
             class Rot13
        {
            public static string Trans(string codificado)
            {
                //Creo un array de characters y lo lleno con el string leido en la variable "codificado"
                //Convierto el string en characters individuales, cada uno con un indice individual en el array
                char[] array = codificado.ToCharArray();

                //Creo un for loop para poder iterar sobre cada character en el array, pidiendole a "i" que se sume en valor por cada char leido
                for (int i = 0; i < array.Length; i++)
                {
                    //A cada elemento en el array, le asigno la variable "numero" que todavia esta vacia
                    int numero = array[i];

                    //Determino los bordes del alfabeto, haciendo que la variable numero compare los elementos en el array
                    if (numero >= 'A' && numero <= 'Z')
                    {
                        //Si los elementos estan antes de la mitad del alfabeto, que se les reste o sume 13 a partir del character leido
                        //Cada letra tiene su propio valor numerico que lo identifica en la secuencia de characters que utilizan los programas
                        //Por ende, en vez de estar buscando cual es el valor numerico de letras puntuales como A o Z, puedo decirle al programa que 
                        //A partir del character, sume o reste de su valor numerico para encontrar a otros characters via el mismo
                        if (numero > 'M')
                        {
                            numero -= 13;
                        }
                        else
                        {
                            numero += 13;
                        }
                    }

                    
                    //Cree una nueva instancia del array, llenandolo del char correspondiente por cada valor que leyo y transformo en la ultima operacion
      
                    array[i] = (char)numero;
                }
                return new string(array);
            }


        }
    }


             
    }

