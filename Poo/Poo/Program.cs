using System;

namespace Poo
{
    class Program
    {
        static void Main(string[] args)
        {
            Automovil auto = new Automovil();
            auto.Acelerar();
            auto.Velocidad = 100;
            Console.WriteLine("La velocidad actual es: {0}",auto.Velocidad);
            Console.WriteLine("\n");

            Console.WriteLine("Cual es el ID de tu auto?");
            auto.asignar_id = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("El ID del auto es: {0}",auto.mostrar_id);
            Console.WriteLine("\n");

            Console.WriteLine("Cual es la Marca de tu auto?");
            auto.Asignar_Marca = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("La Marca del auto es: {0}", auto.Mostrar_Marca);
            Console.WriteLine("\n");

            Console.WriteLine("Cual es el precio de tu auto?");
            auto.asig_mos_prec = 5000;
            Console.WriteLine("\n");
            Console.WriteLine("El precio del auto es: ${0}", auto.asig_mos_prec);
            Console.WriteLine("\n");
            Console.ReadKey();
        }
    }

    class Automovil
    {
        //atributos
        public int Velocidad = 0;
        private string Id = "";
        private string Marca = "";
        private int Precio = 0;

        //metodos
        public void Acelerar()
        {
            Console.WriteLine("El auto esta acelerando");
        }
        public string mostrar_id
        {
            get
            {
                return Id;
            }
        }

        public string asignar_id
        {
            set
            {
                Id = value;
            }
        }
        public string Mostrar_Marca
        {
            get
            {
                return Marca;
            }
        }

        public string Asignar_Marca
        {
            set
            {
               Marca = value;
            }
        }

        public int asig_mos_prec
        {
            get
            {
                return Precio;
            }
             set
             { 
                Precio = value; 
            }
        }
    }

}

