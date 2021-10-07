using System;

namespace Matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            //una Matriz es un arreglo de 2 dimenciones
            // forma de declarar una Matriz
            //tipo[,] nombre= new tipo[tamaño,tamaño];

            int[,] matriz = new int[3,3];
            /*
               0 1 2 b
             0 x x x     1 2 3
             1 x x x     4 5 6
             2 x x x     7 8 9
             a
            */
            //     a  b
            matriz[0, 0] = 1;
            matriz[0, 1] = 2;
            matriz[0, 2] = 3;

            matriz[1, 0] = 4;
            matriz[1, 1] = 5;
            matriz[1, 2] = 6;

            matriz[2, 0] = 7;
            matriz[2, 1] = 8;
            matriz[2, 2] = 9;

            int a, b = 0;
            // imprimir matriz pero solo mostrar numero pares
            for(a = 0;a<3; a++)
            {
                for(b= 0;b <3;  b++)
                {
                    if(matriz[a,b]%2==0)
                    {
                        Console.Write("[{0}]", matriz[a, b]);
                    }
                    else
                    {
                        matriz[a, b] = 0;
                        Console.Write("[{0}]", matriz[a, b]);
                    }
                }
                Console.Write("\n");
            }
        }
    }
}
