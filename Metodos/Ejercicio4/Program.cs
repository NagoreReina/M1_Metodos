using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe una función que devuelva el resultado de sumar los dos parámetros que le pasamos. 
            //En el programa principal, pide al usuario 2 números. Usa esos 2 números como parámetros de la función 
            //y después asigna el valor que devuelve la función a una tercera variable en el programa. 
            //Finalmente, muestra el valor de la variable en la pantalla.

            Console.WriteLine("Introduce un valor");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduce otro valor");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double sum = MakeASum(num1, num2);
            Console.WriteLine($"El resultado es {sum}");
        }
        public static double MakeASum(double n1, double n2)
        {
            double sum = n1 + n2;
            return sum;
        }
    }
}
