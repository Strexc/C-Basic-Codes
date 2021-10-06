using System;

namespace OperadoresAritmeticos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Operadores Aritmeticos \n");
            /*
             suma + 
             resta - 
             division /
             multiplicacion *
             modulo % devuelve el residuo que queda de la division
             */

            float a, b, resultado = 0;
            Console.WriteLine("el valor de A es 4 y el valor de B es 10");
            a = 4;
            b = 10;

            Console.WriteLine("*****************************************");
            Console.WriteLine("* La suma de A + B es: {0}               *",resultado=a+b);
            Console.WriteLine("* La resta de A - B es: {0}              *", resultado = a - b);
            Console.WriteLine("* La Division de de A / B es: {0}       *", resultado = a / b);
            Console.WriteLine("* La Multiplicacion de de A * B es: {0}  *", resultado = a * b);
            Console.WriteLine("* El mod de B % A es: {0}                 *", resultado = b % a);
            Console.WriteLine("*****************************************");
            Console.ReadKey();
        }
    }
}
