using System;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe una función a la que le damos dos números y que devuelva true si el primer número es más 
            //grande que el segundo número y false en el caso contrario. En el programa principal, pide dos números al usuario, 
            //y pasalos a la función. Muestra en pantalla “El primer número es más grande” o “El primer número no es más grande”.
            Console.WriteLine("Introduce un valor");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduce otro valor");
            double num2 = Convert.ToDouble(Console.ReadLine());
            if (CompareNums(num1, num2))
            {
                Console.WriteLine("El primer número es más grande");
            }
            else
            {
                Console.WriteLine("El primer número no es más grande");
            }
        }
        public static bool CompareNums(double n1, double n2)
        {
            bool maxNum = true; ;
            if (n1 > n2)
            {
                maxNum = true;
            }
            else 
            {
                maxNum = false;
            }
            return maxNum;
        }
    }
}
