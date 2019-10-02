using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe una función que escriba “Hola” 3 veces. Llámala desde el programa principal.
            SayHello();
        }
        public static void SayHello()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Hola");
            }
        }
    }
}
