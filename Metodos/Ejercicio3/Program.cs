using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe una función que devuelva el resultado de sumar los dos parámetros que le pasamos. 
            //Asigna el valor de la llamada a la función en una variable en el programa 	
            //principal y muestra el resultado en la pantalla.

            double sum = MakeASum(1, 2);
            Console.WriteLine($"El resultado es {sum}");



        }
        public static double MakeASum(double n1, double n2)
        {
            double sum = n1 + n2;
            return sum;
        }
    }
}
