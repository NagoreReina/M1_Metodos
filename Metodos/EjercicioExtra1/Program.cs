using System;

namespace EjercicioExtra1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Realizar el juego del ahorcado utilizando métodos
            //CREACIÓN DE LA PARTIDA---------------------------
            int trys = 4;
            string userIntro = "";
            string[] words = { "PATATA", "MELOCOTON", "AGUACATE", "TETERA", "SORPRESA", "SOL", "LUNA", "MAGIA", "HORAS", "FRITO", "UNIVERSO", "MURCIELAGO", "MARTILLO", "CANASTA", "NUMERO", "CONSONANTE", "SENTADO", "SONRISA", "MARGARITA", "TRIDENTE" };
            string gameWorld = CalculateWorld(words);
            string[] gameScreen = GenerateSpaces(gameWorld.Length); //Este primero es para el inicio
            //AQUI ACABA LA CREACIÓN DE LA PARTIDA -------------------

            bool gameEnd = false;
            do
            {
                //PANTALLA DE JUEGO
                Console.WriteLine("==============================");
                for (int i = 0; i < gameScreen.Length; i++)
                {
                    Console.Write(gameScreen[i]);
                }
                Console.WriteLine("\n==============================");

                //ACIONES DEL JUGADOR
                Console.WriteLine("¿Quieres intentar resolverlo? (Yes/No)");
                userIntro = Console.ReadLine().ToLower();
                if (userIntro == "yes" || userIntro == "y")
                {
                    Console.WriteLine("Introduce tu respuesta");
                    if (MakeAnAnswer(Console.ReadLine().ToUpper(), gameWorld))
                    {
                        Console.WriteLine("¡HAS GANADO EL JUEGO!");
                        System.Threading.Thread.Sleep(4000);
                        gameEnd = true;
                    }
                    else
                    {
                        trys--;
                        if (trys <= 0)
                        {
                            gameEnd = true;
                        }
                        Console.WriteLine($"La respuesta introducida no es correcta te quedan {trys}/4");
                        System.Threading.Thread.Sleep(3000);
                    }
                }
                else if (userIntro == "no" || userIntro == "n")
                {
                    bool correctLetter = false;
                    do
                    {
                        Console.WriteLine("Introduce una letra");
                        string letter = Console.ReadLine().ToUpper();
                        if (letter.Length > 1 || letter == null || Char.IsDigit(letter,0))
                        {
                            Console.WriteLine("El valor que has introducido no es correcto");
                        }
                        else
                        {
                            correctLetter = true;
                            if(!IntroduceLetter(letter, gameWorld, gameScreen))
                            {
                                Console.WriteLine("La letra introducida no es correcta");
                                trys--;
                                if (trys <= 0)
                                {
                                    gameEnd = true;
                                }
                                Console.WriteLine($"La respuesta introducida no es correcta te quedan {trys}/4");
                                System.Threading.Thread.Sleep(3000);
                            }
                        }
                    } while (!correctLetter);

                }
                Console.Clear();
            } while (!gameEnd);
            

        }
        public static string CalculateWorld(string[] w)
        {
            Random randWorld = new Random();
            string gameWorld = w[randWorld.Next(0, w.Length)];
            
            return gameWorld;

        }
        public static string[] GenerateSpaces(int n)
        {
            string[] text = new string[n];
            for (int i = 0; i < n; i++)
            {
                text[i] = "_ ";
            }
            return text;
        }
        public static bool MakeAnAnswer(string answer, string gameWorld)
        {
            if (answer == gameWorld)
            {
                return true;
            }
            return false;
        }
        public static bool IntroduceLetter(string letter, string gameWord, string[] gameState)
        {
            if (gameWord.Contains(letter))
            {
                for (int i = 0; i < gameWord.Length; i++)
                {
                    string c = gameWord[i].ToString();
                    if (letter == c)
                    {
                        gameState[i] = c + " ";
                    }
                }
                return true;
            }
            return false;
        }

    }
}
