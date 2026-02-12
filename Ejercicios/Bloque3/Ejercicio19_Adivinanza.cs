using System;
using System.Collections.Generic;
using GuiaEjercicios.App;

namespace GuiaEjercicios.Ejercicios.Bloque3
{
    // Ejercicio 19:
    // - Generar un número aleatorio (1-100)
    // - El usuario tiene 7 intentos
    // - Dar pistas: "mayor" o "menor"
    // - Mostrar estadísticas al final
    public static class Ejercicio19_Adivinanza
    {
        public static void Run()
        {
            ExerciseRunner.Run("Ejercicio 19: Juego de adivinanza (1-100, 7 intentos)", () =>
            {
                // 1) Generamos el número secreto entre 1 y 100
                Random rnd = new Random();
                int secreto = rnd.Next(1, 101); // 101 no se incluye

                int maxIntentos = 7;
                bool gano = false;

                // Guardamos los intentos para estadísticas
                List<int> intentos = new List<int>();

                ConsoleUI.Info("Adivina el número entre 1 y 100. Tienes 7 intentos.");
                ConsoleUI.Line();

                // 2) Ciclo de intentos
                for (int i = 1; i <= maxIntentos; i++)
                {
                    int guess = Input.ReadInt($"Intento {i}/{maxIntentos} - Tu número: ", 1, 100);
                    intentos.Add(guess);

                    if (guess == secreto)
                    {
                        ConsoleUI.Line();
                        Console.WriteLine("¡Correcto! 🎉 Adivinaste el número.");
                        gano = true;
                        break;
                    }
                    else if (guess < secreto)
                    {
                        Console.WriteLine("Pista: el número secreto es MAYOR.");
                    }
                    else
                    {
                        Console.WriteLine("Pista: el número secreto es MENOR.");
                    }

                    ConsoleUI.Line();
                }

                // 3) Estadísticas finales
                ConsoleUI.Line();
                Console.WriteLine("ESTADÍSTICAS");
                ConsoleUI.Line();

                Console.WriteLine($"Número secreto: {secreto}");
                Console.WriteLine($"Resultado: {(gano ? "GANÓ ✅" : "PERDIÓ ❌")}");
                Console.WriteLine($"Intentos usados: {intentos.Count} de {maxIntentos}");

                // Lista de intentos
                Console.Write("Tus intentos: ");
                for (int i = 0; i < intentos.Count; i++)
                {
                    Console.Write(intentos[i]);
                    if (i < intentos.Count - 1) Console.Write(", ");
                }
                Console.WriteLine();

                // Extra simple: qué tan cerca estuvo (mejor intento)
                int mejorDiferencia = int.MaxValue;
                int mejorIntento = 0;

                foreach (int g in intentos)
                {
                    int diff = Math.Abs(g - secreto);
                    if (diff < mejorDiferencia)
                    {
                        mejorDiferencia = diff;
                        mejorIntento = g;
                    }
                }

                Console.WriteLine($"Intento más cercano: {mejorIntento} (diferencia {mejorDiferencia})");
            });
        }
    }
}
