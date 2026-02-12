using System;
using GuiaEjercicios.App;

namespace GuiaEjercicios.Ejercicios.Bloque5
{
    // Ejercicio 28:
    // Matriz de N estudiantes x 3 parciales.
    // Calcular:
    // - Promedio por estudiante
    // - Promedio por parcial
    // - Estudiante con mejor promedio
    // - Parcial más difícil (menor promedio)
    public static class Ejercicio28_MatrizNotas
    {
        public static void Run()
        {
            ExerciseRunner.Run("Ejercicio 28: Matriz de notas (N x 3 parciales)", () =>
            {
                // 1) Pedimos N estudiantes
                int n = Input.ReadInt("Ingrese la cantidad de estudiantes (1-200): ", 1, 200);

                // 2) Matriz N x 3
                double[,] notas = new double[n, 3];

                ConsoleUI.Line();
                Console.WriteLine("Ingrese las notas (0 a 100) de cada estudiante en 3 parciales.");
                ConsoleUI.Line();

                // 3) Llenar la matriz
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"Estudiante #{i + 1}:");
                    for (int p = 0; p < 3; p++)
                    {
                        notas[i, p] = Input.ReadDouble($"  Parcial {p + 1}: ", 0, 100);
                    }
                    ConsoleUI.Line();
                }

                // 4) Promedios por estudiante
                double[] promEst = new double[n];
                int mejorEst = 0;
                double mejorProm = -1;

                for (int i = 0; i < n; i++)
                {
                    double suma = 0;
                    for (int p = 0; p < 3; p++)
                        suma += notas[i, p];

                    double prom = suma / 3.0;
                    promEst[i] = prom;

                    if (prom > mejorProm)
                    {
                        mejorProm = prom;
                        mejorEst = i;
                    }
                }

                // 5) Promedios por parcial
                double[] promParcial = new double[3];
                for (int p = 0; p < 3; p++)
                {
                    double suma = 0;
                    for (int i = 0; i < n; i++)
                        suma += notas[i, p];

                    promParcial[p] = suma / n;
                }

                // 6) Parcial más difícil (menor promedio)
                int parcialDificil = 0;
                double menorPromParcial = promParcial[0];

                for (int p = 1; p < 3; p++)
                {
                    if (promParcial[p] < menorPromParcial)
                    {
                        menorPromParcial = promParcial[p];
                        parcialDificil = p;
                    }
                }

                // 7) Mostrar resultados
                ConsoleUI.Line();
                Console.WriteLine("PROMEDIO POR ESTUDIANTE");
                ConsoleUI.Line();

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"Estudiante #{i + 1}: {promEst[i]:0.00}");
                }

                ConsoleUI.Line();
                Console.WriteLine("PROMEDIO POR PARCIAL");
                ConsoleUI.Line();

                for (int p = 0; p < 3; p++)
                {
                    Console.WriteLine($"Parcial {p + 1}: {promParcial[p]:0.00}");
                }

                ConsoleUI.Line();
                Console.WriteLine($"Mejor estudiante: Estudiante #{mejorEst + 1} con promedio {mejorProm:0.00}");
                Console.WriteLine($"Parcial más difícil: Parcial {parcialDificil + 1} con promedio {menorPromParcial:0.00}");
            });
        }
    }
}
