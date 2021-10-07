using System;

namespace Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            //defincion de un arreglo
            // estructura de una arreglo
            // tipo[] nombre = new tipo[tamaño];
            int[] arreglo = new int[4];
            arreglo[0] = 10;
            arreglo[1] = 20;
            arreglo[2] = 30;
            arreglo[3] = 40;

            for(int a = 0;a<4;a++)
            {
                Console.WriteLine("El valor de la posicion[{0}] es [{1}]",a, arreglo[a]);
            }


            //para limpiar o vaciar una arreglo
            Array.Clear(arreglo,0,4);
            int i = 0;
            while(i<4)
            {
                arreglo[i] = arreglo[i] + i;
                Console.WriteLine("El valor de la posicion[{0}] es [{1}]", i, arreglo[i]);
                i++;
            }

            Console.ReadKey();
        }
    }
}
