using System;

namespace Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escriba una función que reciba un array y un valor booleano. Si el booleano es true, 
            //mostrar el array de modo ascendente, si es false, mostrarlo de modo descendente. 
            //En el programa principal, crear un array y hacer que la función lo muestre primero en modo ascendente y después en modo descendente.
            int[] numbers = { 1, 2, 3, 4, 5, 6 };
            bool reverse = false;
            WriteCorrectOrReverse(numbers, reverse);
            Console.WriteLine("");
            reverse = true;
            WriteCorrectOrReverse(numbers, reverse);
        }
        public static void WriteCorrectOrReverse(int[] a, bool b)
        {
            if (b)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    Console.Write(a[i]);
                }
            }
            else
            {
                for (int i = a.Length - 1; i > -1; i--)
                {
                    Console.Write(a[i]);
                }
            }
        }
    }  
}
