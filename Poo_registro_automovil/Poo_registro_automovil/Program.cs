using System;

namespace Poo_registro_automovil
{
    class Program
    {
        static void Main(string[] args)
        {
            Automovil auto = new Automovil(500,"Ibiza");
            Console.WriteLine("La Marca del auto es: {0}",auto.most_marca);
            Console.WriteLine("El precio del auto es: ${0}", auto.most_precio);
            Console.WriteLine("\n");
            Console.WriteLine(auto.ToString());
            Console.ReadKey();
        }
    }

    class Automovil
    {
        //atributos
        private int precio;
        private string marca;
        //constructor
        public Automovil(int p, string m)
        {
            this.precio = p;
            this.marca = m;
        }
        public string most_marca
        {
            get
            {
                return marca;
            }
        }
        public int most_precio
        {
            get
            {
                return precio;
            }
        }

        public override string ToString()
        {
            return "La marca del auto es: " + marca + " El precio del auto es: $" + precio;
        }
    }
}
