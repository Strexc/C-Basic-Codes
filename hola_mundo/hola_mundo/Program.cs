using System;

namespace hola_mundo//es un bloque de codigo que ejecuta un programa y tenemos acceso con using.
{
    class Program
    {
        static void Main(string[] args)
        {
            //varibles TipodeDato NombreDeLaVariable Inicializacion
            int numero = 0;
            String cadena = "Gustavo Robles";
            Console.Write("El participante "+cadena+" Es el numero: "+numero);

            /*Console.Write("Hello world!\n");
            Console.WriteLine("Welcome to C Sharp");*/
            Console.ReadKey();
        }
    }
}