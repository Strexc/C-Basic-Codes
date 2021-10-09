using System;
using System.Collections;
using System.Collections.Generic;

namespace coleccion_pila
{
    class Program
    {
        static void Main(string[] args)
        {

            //la pila o Stack almacena los valores de tal modo que el ultimo que ingresemos sera el primero dato

            //asi se estructura la pila para solo recivir un tipo de dato
            // Stack <tipo> nombre = new Stack<tipo>();
            // asi se estructura la piila para recivir cualquier tipo de valor
            // Stack nombre = new Stack();
            Stack miPila = new Stack();

            // push > sirve para ingresar elementos en la pila
            // pop > sirve para sacar el ultimo elemento que se ingreso a la pila reduciendo el tamaño de la pila

            miPila.Push(10);
            miPila.Push(20);
            miPila.Push(30);
            miPila.Push(40);

            //saber el tamaño de la pila
            //Console.WriteLine(miPila.Count);
            int num = 0,tam = 0;
            tam = miPila.Count;
            //asi sacamos el ultimo valor asegurandonos que sean enteros.
            //num = (int)miPila.Pop();

            //para limpiar o vaciar la pila usamos: 
            //miPila.Clear();

            Console.WriteLine("Mostraremos los valores de la pila del ultimo al primero\n");
            for (num = 0; num < tam; num++)
            {
                Console.Write("[{0}]\t",(int)miPila.Pop());
            }

            Console.ReadKey();
        }
    }
}
