using System;
using System.Collections;

namespace Colecciones_arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList carros = new ArrayList();
            carros.Add("masda");
            carros.Add("chevi");
            carros.Add("ibiza");
            carros.Add("tsuru");

            //con esta linea de codigo nos inidca el tamaño del arreglo
            Console.WriteLine(carros.Count+"\n");
            int tam = carros.Count;

            for(int a = 0;a < tam; a++)
            {
                Console.WriteLine(carros[a]);
            }


            Console.ReadKey();
        }
    }
}
