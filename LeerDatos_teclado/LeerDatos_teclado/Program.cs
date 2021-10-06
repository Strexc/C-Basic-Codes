using System;

namespace LeerDatos_teclado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Solicitar datos al usuario\n");
            float a = 0;
            float b = 0;
            string name = "";

            Console.WriteLine("Ingresa tu nombre: ");
            name = Console.ReadLine();

            Console.WriteLine("Hola {0}, ¿Que tal tu Día", name);


            Console.WriteLine("Hagamos una suma");
            Console.WriteLine("Ingresa el valor de A");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el valor de B");
            b = float.Parse(Console.ReadLine());

            Console.WriteLine("El valor de A es: {0}, el valor de B es: {1}", a, b);


            /* otras formas de leer numeros enteros o flotantes
             TryParse valida si se ingreso un numero valido en caso de que no da error*/

            Console.WriteLine("Ingresa un numero");
            if (!float.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Numero ingresado invalido");
            }
            else
            {
                Console.WriteLine("Su numero es: {0}", a);
            }

            //Usando Convert.ToInt32 converitomos la cadena de texto en un numero del tipo entero
            Console.WriteLine("Ingresa un numero");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El numero es: {0}", c);

            Console.ReadKey();
        }
    }
}
