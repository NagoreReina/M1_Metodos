using System;

namespace Ejercicio22
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crea una aplicación que nos convierta un número en base decimal a binario. 
             * Esto lo realizará un método al que le pasaremos el número como parámetro, devolverá un String con el número convertido a binario. 
             
             * Para convertir un numero decimal a binario, debemos dividir entre 2 el número y el resultado de esa división se divide entre 2 de 
             * nuevo hasta que no se pueda dividir más, el resto que obtengamos de cada división formará el número binario, de abajo a arriba.
                Veamos un ejemplo: si introducimos un 8 nos deberá devolver 1000
             */
            do
            {
                Console.WriteLine("Introduce un valor");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{num} en binario es {ConvertToBinary(num)}");
            } while (true);

        }
        public static string ConvertToBinary(int n)
        {
            int num = n;
            string text = "";
            while(num!=0)
            {
                text = num % 2 + text;
                num = num / 2;
            }
            return text;
        }
    }
}
