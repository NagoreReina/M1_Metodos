using System;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Diseña un método EsPar() que reciba como parámetro un entero y devuelva si ese número es par o no. 
            //Utilízalo en un programa que lea un número por teclado y determine si es par o no.
            Console.WriteLine("Introduce el numero a comprobar");
            
            int num = Convert.ToInt32(Console.ReadLine());
            if (KnowIfEvenOrOdd(num))
            {
                Console.WriteLine("Par");
            }
            else
            {

                Console.WriteLine("Impar");
            }

        }
        public static bool KnowIfEvenOrOdd(int n1)
        {
            bool even = false;
            if (n1 % 2 == 0)
            {
                even = true;
            }
            else
            {
                even = false;
            }
            return even;
        }
    }
}
