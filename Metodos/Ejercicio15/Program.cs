using System;

namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crea una aplicación que nos genere una cantidad de números enteros aleatorios (preguntar cuántos quiere generar). 
            //Crea un método donde pasamos como parámetros entre qué números queremos que los genere (preguntamos al usuario los límites). 
            //Este método devolverá un número entero aleatorio entre ese rango. Muestra estos números por pantalla.

            Console.WriteLine("¿Cuántos números quieres generar?");
            int value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ahora necesito que introduzcas el rango");
            Console.WriteLine("Introduce el primer valor");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el segundo valor");
            int num2 = Convert.ToInt32(Console.ReadLine());
            while (value > 0)
            {
                if (num2 < num1)
                {
                    Console.WriteLine($"El {value}º numero generado es {CalculateRandom(num2, num1)}");
                }
                else
                {
                    Console.WriteLine($"El {value}º numero generado es {CalculateRandom(num1, num2)}");
                }
                value--;
            }
            

        }
        private static int CalculateRandom(int n1, int n2)
        {
            Random randNum = new Random();
            int result = randNum.Next(n1,n2+1);
            return result;
        }
    }
}
