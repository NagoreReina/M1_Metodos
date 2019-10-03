using System;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crea una aplicación que nos calcule el factorial de un número pedido por teclado, 
            //lo realizará mediante un método al que le pasamos el número como parámetro. 
            //Para calcular el factorial, se multiplica los números anteriores hasta llegar a uno. 
            //Por ejemplo, si introducimos un 5, realizará esta operación 5*4*3*2*1=120.

            Console.WriteLine("¿De que número quieres calcular el factorial?");
            int value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"El resultado es {CalculateFactorial(value)}");
        }
        public static int CalculateFactorial(int n)
        {
            int result = 1;
            for (int i = 0; i < n; i++)
            {
                result *= n - i;
            }
            return result;
        }
    }
}
