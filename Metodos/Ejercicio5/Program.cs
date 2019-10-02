using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe un programa que pida al usuario dos números. Usa esos 2 números en una función que divide el primero por el segundo 
            //y devuelve el resultado. Muestra el resultado que devuelve la función en pantalla. 
            //Después vuelve a pedir los números y hacer todo otra vez hasta que el usuario introduzca un 0 como segundo número.
            double num2 = 1;
            do
            {
                Console.WriteLine("Introduce un valor");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Introduce otro valor");
                num2 = Convert.ToDouble(Console.ReadLine());
                double result = MakeADiv(num1, num2);
                if (num2 != 0)
                {
                    Console.WriteLine("-------------");
                    Console.WriteLine($"El resultado es {result}");
                    Console.WriteLine("-------------");
                }
                else
                {
                    Console.WriteLine("Cerrando programa");

                }

            } while (num2 != 0);

        }
        public static double MakeADiv(double n1, double n2)
        {
            double result = n1 / n2;
            return result;
        }
    }
}
