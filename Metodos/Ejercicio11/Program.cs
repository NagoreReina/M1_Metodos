using System;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe un programa que dé la vuelta a un string pasado por parámetro y lo devuelva.
            Console.WriteLine("Introduce una frase");
            string sentence = Console.ReadLine();
            char[] allLeters = sentence.ToCharArray();
            string text = "";
            int i = sentence.Length;
            while (i != 0)
            {
                text += allLeters[i - 1];
                i--;
            }
            Console.WriteLine(text);
        }
    }
}
