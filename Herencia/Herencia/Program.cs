using System;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Automovil auto1 = new Automovil();
            Avion avion1 = new Avion();

            auto1.muestraprecio();
            avion1.muestraprecio();
            Console.ReadKey();
        }
    }

    class Transporte
    {
        //atributos
        protected string Nombre;
        protected int precio;
        protected int NumPasajeros;

    }

    class Automovil: Transporte
    {
        //atributos
        //metodo
        public void muestraprecio()
        {
            precio = 500;
            Console.WriteLine("El precio de este transporte es: ${0}", precio);
        }
    }
    class Avion: Transporte
    {
        //atributos
        //metodo
        public void muestraprecio()
        {
            precio = 700;
            Console.WriteLine("El precio de este transporte es: ${0}", precio);
        }
    }
}
