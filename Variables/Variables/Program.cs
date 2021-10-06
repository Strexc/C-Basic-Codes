using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables y subindices
            int variableA = 2;
            Console.WriteLine("Variable de tipo entero tiene el valor: "+variableA);

            String nombre = "Gustavo Robles";
            Console.WriteLine("El contenido de la cadena es: " +nombre);

            bool ganador = false;
            Console.WriteLine("La variable tipo boolean es: {0}", ganador);

            //imprimir 2 variables en la misma linea
            Console.WriteLine("El valor del entero es: {0}, El valor de la Cadena de Texto es: {1}, El valor de la variable Boleana es: {2}",variableA,nombre,ganador);

            Console.ReadKey();
        }
    }
}
