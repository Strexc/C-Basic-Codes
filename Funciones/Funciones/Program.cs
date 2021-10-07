using System;

namespace Funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             TIPOS DE FUNCIONES
            1.- EJECUTA CODIGO
            2.- DEVUELVE VALORES
            3.- RECIBEN VALORES
            4.- RECIBEN Y DEVUELVEN VALORES
             */

            /*1.-
            MostrarHola();// con esto mandamos a llamar la funcion MostrarHola y la ejecuta.
            2.-
             * int b = 7;
            int suma = b + regresavalor();
            Console.WriteLine("La suma de 4 y 7 es: "+suma);
            3.-
            Recivevalor(5);
            4.- */
            int b = 0;
            Console.WriteLine("vamos a hacer una multiplicacion 5 x el numero que tu ingreses\n");
            Console.WriteLine("Dame el valor de A: ");
            b = int.Parse(Console.ReadLine());

            int xa = MultiVal(5, b);
            Console.WriteLine("el resultado de la mutiplicacion es: {0}", xa);


            Console.ReadKey();
        }
        //funcion que solo ejecuta codigo
        public static void MostrarHola()
        {
            Console.WriteLine("Hola soy una función :D");
        }
        //funcion que devuelve un valor
        public static int Regresavalor()
        {
            int a = 4;
            return a;
        }
        //funcion que recive un valor
        public static void Recivevalor(int a)
        {
            int b = 10, suma = 0;
            suma = b + a;

            Console.WriteLine("el resultado de la suma es: {0}", suma);
        }
        //funcion que recive y devuelve un valor
        static int MultiVal(int a, int b)
        {
            int resultado = 0;

            resultado = a * b;

            return resultado;
        }
    }
}
