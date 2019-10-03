using System;

namespace Ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crea una aplicación que nos calcule el área de un círculo, cuadrado o triángulo. 
               Pediremos de qué figura queremos calcular su área y según lo introducido pedirá los valores 
               necesarios para calcular el área. Crea un método por cada figura para calcular cada área, 
               este devolverá un número real. Muestra el resultado por pantalla
                Circulo: (radio^2)*PI
                Triángulo: (base * altura) / 2
                Cuadrado: lado * lado
             */
            bool figure = false;
            double num = 0;
            double num1 = 0;
            do
            {
                Console.WriteLine("¿Que figura?");
                string value = Console.ReadLine().ToLower();
                switch (value)
                {
                    case "circulo":
                        Console.WriteLine("¿Que radio?");
                        num = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"El área es: {Circle(num)}");
                        figure = true;
                        break;
                    case "triangulo":
                        Console.WriteLine("¿Que base?");
                        num = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("¿Que altura?");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"El área es: {Triangle(num,num1)}");
                        figure = true;
                        break;
                    case "cuadrado":
                        Console.WriteLine("¿Cuanto mide el lado?");
                        num = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"El área es: {Square(num)}");
                        figure = true;
                        break;

                    default:
                        Console.WriteLine("No te he entendido, prueba otra vez");
                        break;
                }
            } while (figure == false);
            

        }
        private static double Circle(double r)
        {
            double result = Math.Pow(r,2)*Math.PI;
            return result;
        }
        private static double Triangle (double b, double h)
        {
            double result = (b*h)/2;
            return result;
        }
        private static double Square (double l)
        {
            double result = l*l;
            return result;
        }
    }
}
