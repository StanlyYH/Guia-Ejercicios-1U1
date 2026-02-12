using System;
using GuiaEjercicios.App;

namespace GuiaEjercicios.Ejercicios.Bloque2
{
    // Ejercicio 9:
    // Dados tres lados, determinar si forman un triángulo válido y clasificarlo:
    // - Por lados: equilátero, isósceles, escaleno
    // - Por ángulos: rectángulo, acutángulo, obtusángulo
    public static class Ejercicio09_Triangulos
    {
        public static void Run()
        {
            ExerciseRunner.Run("Ejercicio 9: Triángulos (por lados y por ángulos)", () =>
            {
                // 1) Pedimos los 3 lados (positivos)
                double a = Input.ReadDouble("Ingrese lado A: ", 0.000001, 1_000_000);
                double b = Input.ReadDouble("Ingrese lado B: ", 0.000001, 1_000_000);
                double c = Input.ReadDouble("Ingrese lado C: ", 0.000001, 1_000_000);

                ConsoleUI.Line();

                // 2) Validación: para ser triángulo, la suma de dos lados debe ser mayor que el tercero
                if (!EsTrianguloValido(a, b, c))
                {
                    ConsoleUI.Error("Los valores ingresados NO forman un triángulo válido.");
                    return;
                }

                // 3) Clasificación por lados
                string tipoLados = ClasificarPorLados(a, b, c);

                // 4) Clasificación por ángulos (usando comparación de cuadrados)
                string tipoAngulos = ClasificarPorAngulos(a, b, c);

                Console.WriteLine($"Lados: A={a:0.##}, B={b:0.##}, C={c:0.##}");
                ConsoleUI.Line();
                Console.WriteLine($"Por lados:   {tipoLados}");
                Console.WriteLine($"Por ángulos: {tipoAngulos}");
            });
        }

        private static bool EsTrianguloValido(double a, double b, double c)
        {
            return (a + b > c) && (a + c > b) && (b + c > a);
        }

        private static string ClasificarPorLados(double a, double b, double c)
        {
            // Nota: usamos una tolerancia pequeña porque son números decimales
            const double eps = 1e-9;

            bool ab = Math.Abs(a - b) < eps;
            bool ac = Math.Abs(a - c) < eps;
            bool bc = Math.Abs(b - c) < eps;

            if (ab && ac) return "Equilátero";
            if (ab || ac || bc) return "Isósceles";
            return "Escaleno";
        }

        private static string ClasificarPorAngulos(double a, double b, double c)
        {
            // Ordenamos para asegurar que c sea el lado más grande
            double[] lados = { a, b, c };
            Array.Sort(lados);
            double x = lados[0];
            double y = lados[1];
            double z = lados[2]; // el mayor

            // Comparamos x^2 + y^2 con z^2
            double izq = x * x + y * y;
            double der = z * z;

            // Tolerancia para comparación (evita errores por decimales)
            double eps = 1e-6 * der;

            if (Math.Abs(izq - der) <= eps) return "Rectángulo";
            if (izq > der) return "Acutángulo";
            return "Obtusángulo";
        }
    }
}
