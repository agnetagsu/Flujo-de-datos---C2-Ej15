using System;

namespace Flujo_de_datos___C2_Ej15
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;

            Console.WriteLine("Introduce un numero:");
            i = Convert.ToInt32(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.WriteLine("Es divisible por 2");
            }
            else
            {
                Console.WriteLine("No es divisible por 2");
            }
        }
    }
}
