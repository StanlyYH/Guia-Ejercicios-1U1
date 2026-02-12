using System;
using GuiaEjercicios.App;

namespace GuiaEjercicios.Ejercicios.Bloque2
{
    // Ejercicio 10:
    // Leer una nota (0-100) y mostrar:
    // - Letra (A, B, C, D, F)
    // - Descripción (Excelente, Muy bueno, etc.)
    // - Si aprobó o reprobó
    public static class Ejercicio10_CalificacionesUNAH
    {
        public static void Run()
        {
            ExerciseRunner.Run("Ejercicio 10: Sistema de calificaciones UNAH (0-100)", () =>
            {
                // 1) Pedimos la nota y validamos rango 0-100
                double nota = Input.ReadDouble("Ingrese la nota (0 a 100): ", 0, 100);

                // 2) Obtenemos letra y descripción
                string letra = GetLetra(nota);
                string descripcion = GetDescripcion(letra);

                // 3) Regla de aprobación (comúnmente >= 65)
                bool aprobo = nota >= 65;

                ConsoleUI.Line();
                Console.WriteLine($"Nota:        {nota:0.00}");
                Console.WriteLine($"Letra:       {letra}");
                Console.WriteLine($"Descripción: {descripcion}");
                Console.WriteLine($"Resultado:   {(aprobo ? "APROBÓ" : "REPROBÓ")}");
            });
        }

        private static string GetLetra(double nota)
        {
            // Escala simple (puedes ajustar si tu profe usa otra)
            if (nota >= 90) return "A";
            if (nota >= 80) return "B";
            if (nota >= 70) return "C";
            if (nota >= 65) return "D";
            return "F";
        }

        private static string GetDescripcion(string letra)
        {
            // Descripción según letra
            return letra switch
            {
                "A" => "Excelente",
                "B" => "Muy bueno",
                "C" => "Bueno",
                "D" => "Suficiente",
                _   => "Reprobado"
            };
        }
    }
}
