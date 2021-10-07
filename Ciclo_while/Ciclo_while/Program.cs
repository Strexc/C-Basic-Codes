using System;

namespace Ciclo_while
{
    class Program
    {
        static void Main(string[] args)
        {
            //ciclo es un bloque de codigo que se ejecuta un determinado numero de veces
            /*
             * ciclo while 
             * ciclo do - while
             * ciclo for
             * ciclo foreach
             */

            /*
            while(condicion)
            {
               bloque de instrucciones.
            }*/

            int numero = 0;
            Console.WriteLine("Ciclo While");

            while (numero < 5)
            {
                Console.WriteLine("Vamos en el numero: {0}", numero);
                numero++;
            }

            numero = 0;
            Console.WriteLine("\nCiclo Do - While");

            do
            {
                Console.WriteLine("Vamos en el numero: {0}", numero);
                numero++;
            } while (numero < 3);

            numero = 0;
            Console.WriteLine("\nCiclo FOR");

            for(numero = 0;numero<=5;numero++)
            {
                Console.WriteLine("Vamos en el numero: {0}", numero);
            }

            Console.ReadKey();
        }
    }
}
