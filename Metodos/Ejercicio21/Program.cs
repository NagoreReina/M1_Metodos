using System;

namespace Ejercicio21
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Diseña  un  método  PedirMes().  Solicita  un  número  de  mes  y  valida  que  se  trata  de  un número de mes correcto. 
             Devuelve dicho número de mes. Si es incorrecto, devolverá 0.
              
             Diseña un método PedirAnio(). Recibe como parámetros los límites entre los que debe de estar el año que se debe solicitar por teclado. 
             Devuelve el año aleatorio entre dichos límites.  Validar que el límite máximo sea mayor que el límite mínimo y en caso contrario, 
             cambiarles el valor.

             Diseña un método PedirDia(). Solicita un número de día por teclado, y dado un mes y un año  válidos  recibidos  por  parámetro,  
             devuelve  un  día  correcto.  (Nota:  puede  llamar  al método EsBisiesto) 

             Crea un nuevo método MostrarSiguienteDia() que recibe un día, un mes y un año válido (estos tres datos forman la fecha actual) y 
             muestra en pantalla 2 fechas: la actual y la del día siguiente, a calcular a partir del día actual.  

             Pruébalo  en  un  programa  que  pida  al  usuario  una  fecha (PedirDia(),PedirMes(), PedirAnio()) y muestre la fecha del día siguiente. 
   			           Ejemplo:  
    		               Fecha actual: 31/12/2011 
             
             */
            bool operated = false;
            do
            {
                Console.WriteLine("Vamos a generar una fecha, lo primero, sacaremos un año aleatorio, para eso, necesitaremos que introduzcas dos valores");
                Console.WriteLine("Introduce el primer valor");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Introduce el segundo valor");
                int num2 = Convert.ToInt32(Console.ReadLine());
                int calculatedYear = AskYear(num, num2);
                Console.WriteLine("Bien, ahora introduce un mes (utilizando numeros)");
                num = AskMonth(Console.ReadLine());
                if (num != 0)
                {
                    int month = num; 
                    Console.WriteLine("Bien, ahora introduce un dia (utilizando numeros)");
                    num = AskDay(Console.ReadLine(),month, calculatedYear);
                    if (num != 0)
                    {
                        Console.WriteLine("----------------------------");
                        LookNextDay(calculatedYear, month, num);
                        Console.WriteLine("----------------------------");
                        operated = true;
                    }
                    else
                    {
                        Console.WriteLine("El dia introducido no es correcto, probemos otra vez");
                    }
                }
                else
                {
                    Console.WriteLine("El mes introducido no es correcto, probemos otra vez");
                }

            } while (!operated);
            

        }
        public static int AskMonth(string m)
        {
            int value = 0;
            if (Int32.TryParse(m, out value))
            {
                if (value > 0 && value < 13)
                {
                    return value;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }
        public static int AskYear(int y1, int y2)
        {
            Random randNum = new Random();
            if (y1 > y2)
            {
                return randNum.Next(y2, y1 + 1);
            }
            else
            {
                return randNum.Next(y1, y2 + 1);
            }
            
            
        }

        public static int AskDay(string d, int m, int y)
        {
            int day = 0;
            if (Int32.TryParse(d, out day))
            {
                if (day > 0 && day <= 31)
                {
                    if (m == 2)
                    {
                        if (DateTime.IsLeapYear(y))
                        {
                            if (day <= 29)
                            {
                                return day;
                            }

                        }
                        else
                        {
                            if (day <= 28)
                            {
                                return day;
                            }

                        }
                    }
                    else if (m == 1 || m == 3 || m == 5 || m == 7 || m == 8 || m == 10 || m == 12)
                    {
                        if (day <= 31)
                        {
                            return day;
                        }

                    }
                    else
                    {
                        if (day <= 30)
                        {
                            return day;
                        }

                    }
                }

            }
            return 0;
        }

        public static void LookNextDay(int y, int m, int d)
        {
            DateTime introducedData = new DateTime(y,m,d);
            DateTime tomorrow = introducedData.AddDays(1);
            Console.WriteLine($"La fecha inicial es {introducedData.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"y el dia siguiente es {tomorrow.ToString("dd/MM/yyyy")}");

        }

    }
}
