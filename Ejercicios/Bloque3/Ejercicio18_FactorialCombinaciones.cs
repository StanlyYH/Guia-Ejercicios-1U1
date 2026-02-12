using System;
using GuiaEjercicios.App;

namespace GuiaEjercicios.Ejercicios.Bloque3
{
    // Ejercicio 18:
    // Calcular factorial de N y luego calcular combinaciones:
    // C(n,r) = n! / (r!(n-r)!)
    public static class Ejercicio18_FactorialCombinaciones
    {
        public static void Run()
        {
            ExerciseRunner.Run("Ejercicio 18: Factorial y Combinaciones C(n,r)", () =>
            {
                // 1) Factorial de N
                int N = Input.ReadInt("Ingrese N para calcular N! (0-20): ", 0, 20);
                long factN = Factorial(N);

                ConsoleUI.Line();
                Console.WriteLine($"{N}! = {factN}");
                ConsoleUI.Line();

                // 2) Combinaciones C(n,r)
                int n = Input.ReadInt("Ingrese n (0-20): ", 0, 20);
                int r = Input.ReadInt("Ingrese r (0-n): ", 0, n);

                // Validación simple (por si acaso)
                if (r > n)
                {
                    ConsoleUI.Error("r no puede ser mayor que n.");
                    return;
                }

                long comb = Combinacion(n, r);

                ConsoleUI.Line();
                Console.WriteLine($"C({n},{r}) = {comb}");
            });
        }

        private static long Factorial(int x)
        {
            // Factorial: 0! = 1
            long result = 1;
            for (int i = 2; i <= x; i++)
                result *= i;

            return result;
        }

        private static long Combinacion(int n, int r)
        {
            // C(n,r) = n! / (r! (n-r)!)
            long fn = Factorial(n);
            long fr = Factorial(r);
            long fnr = Factorial(n - r);

            return fn / (fr * fnr);
        }
    }
}
