using System;

namespace Ejercicio18
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crea un aplicación que nos convierta una cantidad de euros introducida por teclado a otra moneda, 
             estas pueden ser a dólares, yenes o libras. El método tendrá como parámetros, la cantidad de euros 
             y la moneda a pasar que sera una cadena, este no devolverá ningún valor, mostrará un mensaje indicando el cambio (void).
                - 0.86 libras es un 1 €
                - 1.28611 $ es un 1 €
                - 129.852 yenes es un 1 €
             */
            bool allDone = false;
            do
            {
                Console.WriteLine("Introduce la cantidad de euros que quieres convertir");
                double num = 0;
                if (Double.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("Introduce la moneda a la que quieres convertir (libra, dolar, yen)");
                    string coin = Console.ReadLine().ToLower();
                    ConvertToOther(num, coin);
                }
                else
                {
                    Console.WriteLine("No has introducido un valor correcto");
                }
            } while (!allDone);
            
        }
        public static void ConvertToOther(double e, string c)
        {
            switch (c)
            {
                case "libra":
                    Console.WriteLine($"{e} euros son {e * 0.86} libra/s");
                    break;
                case "dolar":
                    Console.WriteLine($"{e} euros son {e * 1.28611} dolar/es");
                    break;
                case "yen":
                    Console.WriteLine($"{e} euros son {e * 129.852} yen/es");
                    break;
                default:
                    Console.WriteLine("No has introducido una moneda correcta");
                    break;
            }
        }
    }
}
