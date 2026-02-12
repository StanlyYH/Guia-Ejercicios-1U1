using System;
using GuiaEjercicios.App;

namespace GuiaEjercicios.Ejercicios.Bloque4
{
    // Ejercicio 26:
    // Generar 20 números aleatorios (1-10).
    // Mostrar la frecuencia de cada número y cuál es el más y menos frecuente.
    public static class Ejercicio26_FrecuenciaElementos
    {
        public static void Run()
        {
            ExerciseRunner.Run("Ejercicio 26: Frecuencia de elementos (1-10)", () =>
            {
                int[] numeros = new int[20];
                int[] freq = new int[11]; // usaremos índices 1..10

                Random rnd = new Random();

                // 1) Generamos los 20 números y contamos frecuencia
                for (int i = 0; i < numeros.Length; i++)
                {
                    int n = rnd.Next(1, 11); // 1..10
                    numeros[i] = n;
                    freq[n]++;
                }

                // 2) Mostramos el arreglo generado
                ConsoleUI.Line();
                Console.WriteLine("Números generados:");
                ConsoleUI.Line();
                for (int i = 0; i < numeros.Length; i++)
                {
                    Console.Write(numeros[i] + (i < numeros.Length - 1 ? ", " : ""));
                }
                Console.WriteLine();

                // 3) Mostramos frecuencia por número
                ConsoleUI.Line();
                Console.WriteLine("Frecuencia de cada número:");
                ConsoleUI.Line();

                for (int n = 1; n <= 10; n++)
                {
                    Console.WriteLine($"{n}: {freq[n]}");
                }

                // 4) Encontrar más frecuente y menos frecuente (que haya aparecido)
                int masFrecuenteNum = 1;
                int masFrecuenteCount = freq[1];

                for (int n = 2; n <= 10; n++)
                {
                    if (freq[n] > masFrecuenteCount)
                    {
                        masFrecuenteCount = freq[n];
                        masFrecuenteNum = n;
                    }
                }

                // Menos frecuente: el que tenga la menor frecuencia pero > 0
                int menosFrecuenteNum = -1;
                int menosFrecuenteCount = int.MaxValue;

                for (int n = 1; n <= 10; n++)
                {
                    if (freq[n] > 0 && freq[n] < menosFrecuenteCount)
                    {
                        menosFrecuenteCount = freq[n];
                        menosFrecuenteNum = n;
                    }
                }

                ConsoleUI.Line();
                Console.WriteLine($"Más frecuente:  {masFrecuenteNum} (aparece {masFrecuenteCount} veces)");

                if (menosFrecuenteNum == -1)
                    Console.WriteLine("Menos frecuente: No hay (caso raro, no apareció ninguno).");
                else
                    Console.WriteLine($"Menos frecuente: {menosFrecuenteNum} (aparece {menosFrecuenteCount} veces)");
            });
        }
    }
}
