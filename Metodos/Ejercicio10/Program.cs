using System;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe un programa que cuente las palabras en un string pasado por parámetro.
            string sentence = "contando numero de palabras";
            String[] spearator = { " " };
            String[] separatedSentence = sentence.Split(spearator, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine($"La frase tiene {separatedSentence.Length} palabra/s");
        }
    }
}
