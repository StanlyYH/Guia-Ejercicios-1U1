using System;
using GuiaEjercicios.App;

namespace GuiaEjercicios.Ejercicios.Bloque3
{
    // Ejercicio 17:
    // Generar los primeros N términos de Fibonacci.
    // Mostrar también la suma total y el promedio.
    public static class Ejercicio17_Fibonacci
    {
        public static void Run()
        {
            ExerciseRunner.Run("Ejercicio 17: Serie Fibonacci (N términos)", () =>
            {
                // 1) Pedimos N (limitamos para evitar desbordes muy rápido)
                int n = Input.ReadInt("Ingrese N (cantidad de términos, 1-93): ", 1, 93);

                long a = 0;   // primer término
                long b = 1;   // segundo término

                long suma = 0;

                ConsoleUI.Line();
                Console.WriteLine($"Primeros {n} términos de Fibonacci:");
                ConsoleUI.Line();

                for (int i = 1; i <= n; i++)
                {
                    long termino;

                    // Para que salga la serie: 0, 1, 1, 2, 3, 5...
                    if (i == 1) termino = 0;
                    else if (i == 2) termino = 1;
                    else
                    {
                        termino = a + b;
                        a = b;
                        b = termino;
                    }

                    suma += termino;
                    Console.Write(termino + (i < n ? ", " : ""));
                }

                ConsoleUI.Line();

                double promedio = (double)suma / n;

                Console.WriteLine($"Suma total: {suma}");
                Console.WriteLine($"Promedio:   {promedio:0.00}");
            });
        }
    }
}
