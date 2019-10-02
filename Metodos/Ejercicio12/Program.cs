using System;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe un método que reciba un array de ints y lo muestre en pantalla desde la primera posición hasta la última. 
            //Después escribe otra función que reciba un array de ints y lo muestre en pantalla desde la última posición a la primera.  
            //Crea un array en el programa principal y pásalo a cada una de las funciones.
            int[] numbers = { 1, 2, 3, 4, 5, 6 };
            WriteCorrect(numbers);
            Console.WriteLine("");
            WriteReverse(numbers);
        }
        public static void WriteCorrect(int[] a)
        {
            for (int i = 0; i < a.Length; i++) 
            {
                Console.Write(a[i]);
            }
        }
        public static void WriteReverse(int[] a)
        {
            for (int i = a.Length-1; i > -1; i--)
            {
                Console.Write(a[i]);
            }
        }
    }
}
