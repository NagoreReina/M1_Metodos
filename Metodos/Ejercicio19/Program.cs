using System;

namespace Ejercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            //Modificar el ejercicio de la calculadora para introducir métodos: Sumar(),Restar(), Dividir()...

            int option = 0;
            do
            {
                Console.WriteLine("\t *************** \n  \t   Calculadora \n \t *************** \n \t(escoge una opción) \n \t 1. Suma \n \t 2. Resta \n \t 3. Multiplicar \n \t 4. Potencia \n \t 5. División \n \t 6. Raiz \n \t 7. Salir");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        MakeSum();
                        break;
                    case 2:
                        MakeSubtraction();

                        break;
                    case 3:
                        MakeMultiplication();
                        break;
                    case 4:
                        MakeElevate();

                        break;
                    case 5:
                        MakeDivision();
                        break;
                    case 6:
                        MakeRoot();
                        break;
                    case 7:
                        Console.WriteLine("Programa cerrado");
                        break;
                    default:
                        Console.WriteLine($"opción {option} no disponible, vuelva a intentarlo");
                        break;
                }
            } while (option != 7);
        }
        public static void MakeSum()
        {
            Console.WriteLine("Introduce el primer valor");
            double num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el segundo valor");
            double num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Operación seleccionada: Suma");
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        }
        public static void MakeSubtraction()
        {
            Console.WriteLine("Introduce el primer valor");
            double num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el segundo valor");
            double num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Operación seleccionada: Resta");
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
        }
        public static void MakeDivision()
        {
            Console.WriteLine("Introduce el primer valor");
            double num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el segundo valor");
            double num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Operación seleccionada: División");
            Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
        }
        public static void MakeMultiplication()
        {
            Console.WriteLine("Introduce el primer valor");
            double num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el segundo valor");
            double num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Operación seleccionada: Multiplicación");
            Console.WriteLine($"{num1} x {num2} = {num1 * num2}");
        }
        public static void MakeElevate()
        {
            Console.WriteLine("Introduce el primer valor");
            double num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el segundo valor");
            double num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Operación seleccionada: Potencia");
            Console.WriteLine($"{num1} ^ {num2} = {Math.Pow(num1, num2)}");
        }
        public static void MakeRoot()
        {
            Console.WriteLine("Introduce el valor");
            double num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Operación seleccionada: Raiz");
            Console.WriteLine($"Raiz cuadrada de {num1}  = {Math.Sqrt(num1)}");
        }
    }
}
