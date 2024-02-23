using System;

namespace Sentencias
{
    class SentenciaIf
    {
        public static void Main (string[] args)
        {
            int numeroEntero = int.Parse(Console.ReadLine());

            if (numeroEntero == 7) 
                Console.WriteLine("Numero entero es 7,");
                else if (numeroEntero < 0)
                    Console.WriteLine("Numero entero es negativo, ");
                else 
                Console.WriteLine("Numero entero no es ninguno de los casos programados");
            }

        }
    }
