using System;

namespace Operadores_Logicos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operadores Logicos
            /* 
             * == igual
             * != diferente
             * < or > mayor y menor que
             * <= or >= mayor igual y menor igual que
             * && operador Y
             * || operador O
             **/

            int varA = 1;
            int varB = 2;
            int A_suma = 0;
            A_suma = varA + varB;

            Console.WriteLine("El valor de A es: {0}, El valor de B es: {1}",varA,varB);
            Console.WriteLine("La suma de A + B es: {0}", A_suma);
            Console.WriteLine("");

            Boolean res;

            res = varB == varA;

            /*
             B > A = True
             B < A = False
             B >= B = true
             A != B = true
             A == B = false
             */
            Console.WriteLine(res);

            Console.ReadKey();//pausa la consola hasta que preciones una tecla.
        }
    }
}
 