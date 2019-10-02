using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Escribe una función que escriba “Hola” tantas veces como el número que le pasamos de parámetro. 
            //Llámala desde el programa principal dos veces, primero con 5 y después con 3.

            SayHello(5);
            Console.WriteLine("---------------");
            SayHello(3);
        }
        public static void SayHello(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Hola");
            }
        }
    }
}
