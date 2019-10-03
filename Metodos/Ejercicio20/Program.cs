using System;

namespace Ejercicio20
{
    class Program
    {

        static void Main(string[] args)
        {
            /*Método EsPerfecto() que determine si un número es o no perfecto. A este método se le pasa un número y devuelve: 
            - Verdadero: si el número es perfecto 
            - Falso: si no es perfecto 

            Un número es perfecto si la suma de sus divisores excepto él, es igual al propio número. Ejemplo: 
            6=1+2+3 es perfecto 

            Utilízalo  en  un  programa que  pida  por  teclado  números  hasta que  se teclee  un  0  e  indique  los siguientes resultados: 
  		    Cantidad de números pares  
  		    Cantidad de números perfectos 
  		    Cantidad de múltiplos de 5

             */
            int value = 1;
            int countOfPerfects = 0;
            int countOfEvens = 0;
            int countOfMultiples = 0;
            do
            {
                Console.WriteLine("Introduce un numero");
                value = Convert.ToInt32(Console.ReadLine());
                if (value != 0)
                {
                    
                    if (IsEven(value))
                    {
                        countOfEvens++;
                    }
                    if (IsPerfect(value))
                    {
                        countOfPerfects++;
                    }
                    if (Ismultiple5(value))
                    {
                        countOfMultiples++;
                    }
                }
            } while (value != 0);
            Console.WriteLine($"Has intrudicido {countOfEvens} numero/s par/es, {countOfPerfects} numero/s perfecto/s y {countOfMultiples} numero/s multiplo/s de 5");
        }
        public static bool IsPerfect(int n)
        {
            int result = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    result += i;
                }
            }
            if (result == n)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static bool IsEven(int n)
        {
            if (n % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Ismultiple5(int n)
        {
            if (n % 5 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
