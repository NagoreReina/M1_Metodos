using System;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe un programa que cuente las vocales de un string pasado por parámetro.
            Console.WriteLine("Introduce una frase:");
            string userInput = Console.ReadLine().ToLower();
            int vowelCount = 0;
            for (int i = 0; i < userInput.Length; i++)
            {
                string c = userInput[i].ToString();
                if ("aeiou".Contains(c))
                {
                    vowelCount++;
                }
            }
            Console.WriteLine(vowelCount);
        }
    }
}
