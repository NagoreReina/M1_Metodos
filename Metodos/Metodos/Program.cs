using System;

namespace Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un nombre");
            string name = Console.ReadLine();
            SaludarNombre(name);
        }
        public static void SaludarNombre(string name)
        {
            Console.WriteLine($"Hola {name}");
        }
    }

}
