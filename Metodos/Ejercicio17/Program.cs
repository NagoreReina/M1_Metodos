using System;

namespace Ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crea una aplicación que nos cuente el número de cifras de un número entero positivo (hay que controlarlo) pedido por teclado. 
            //Crea un método que realice esta acción: pasando el número por parámetro, devolverá el número de cifras.
            bool correctNum = false;
            do
            {
                Console.WriteLine("Introduce un numero entero positivo");
                double num = 0;
                int workNum = 0;
                if (Double.TryParse(Console.ReadLine(), out num))
                {
                    workNum = Convert.ToInt32(num);
                    if (workNum > 0)
                    {
                        Console.WriteLine($"El numero introducido tiene {CountNumber(workNum)} cifras");
                        correctNum = true;
                    }
                    else
                    {
                        Console.WriteLine("No has introducido un valor correcto");
                    }
                }
                else
                {
                    Console.WriteLine("No has introducido un valor correcto");
                }
            } while (correctNum == false);
            
        }
        public static int CountNumber(int n)
        {
            int cont = 0;
            while (n > 0)
            {
                n = n / 10;
                cont++;
            }
            return cont;
        }
    }
}
