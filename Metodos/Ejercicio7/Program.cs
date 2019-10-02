using System;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe una función a la que le pasamos un año y devuelve true si es bisiesto. 
            //En el programa principal, pídele al usuario un número y muestra en pantalla “El año … es bisiesto” 
            //o “El año … no es bisiesto” y sigue pidiendo números y diciendo si es o no bisiesto hasta que introduzca un 0.
            int year = 1;
            do
            {
                Console.WriteLine("Introduce el año a comprobar");
                year = Convert.ToInt32(Console.ReadLine());
                if (year != 0)
                {
                    if (KnowIfLeap(year))
                    {
                        Console.WriteLine($"El año {year} es bisiesto");
                    }
                    else
                    {
                        Console.WriteLine($"El año {year} NO es bisiesto");
                    }
                }
            } while (year != 0);
            

        }
        public static bool KnowIfLeap(int year)
        {
            bool bisiesto = true;
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        //SI
                        bisiesto = true;
                    }
                    else
                    {
                        //NO
                        bisiesto = false;
                    }

                }
                else
                {
                    //SI
                    bisiesto = true;
                }
            }
            else
            {
                //NO
                bisiesto = false;
            }
            return bisiesto;
        }
    }
}
