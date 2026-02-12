using System;
using GuiaEjercicios.App;

namespace GuiaEjercicios.Ejercicios.Bloque4
{
    // Ejercicio 23:
    // Ingresar N calificaciones en un arreglo.
    // Calcular: promedio, máxima, mínima, aprobados/reprobados y desviación estándar.
    public static class Ejercicio23_EstadisticasCalificaciones
    {
        public static void Run()
        {
            ExerciseRunner.Run("Ejercicio 23: Estadísticas de calificaciones", () =>
            {
                // 1) Pedimos cuántas calificaciones se van a ingresar
                int n = Input.ReadInt("¿Cuántas calificaciones desea ingresar? (1-1000): ", 1, 1000);

                // 2) Creamos el arreglo
                double[] notas = new double[n];

                // Nota mínima aprobatoria (cámbiala si tu profe usa otra)
                const double notaAprobacion = 65.0;

                // Variables para cálculos básicos
                double suma = 0;
                double max = double.MinValue;
                double min = double.MaxValue;
                int aprobados = 0;
                int reprobados = 0;

                ConsoleUI.Line();
                Console.WriteLine("Ingrese las calificaciones (0 a 100):");
                ConsoleUI.Line();

                // 3) Llenamos el arreglo y vamos calculando max, min, suma, etc.
                for (int i = 0; i < n; i++)
                {
                    double nota = Input.ReadDouble($"Nota #{i + 1}: ", 0, 100);
                    notas[i] = nota;

                    suma += nota;

                    if (nota > max) max = nota;
                    if (nota < min) min = nota;

                    if (nota >= notaAprobacion) aprobados++;
                    else reprobados++;
                }

                // 4) Promedio
                double promedio = suma / n;

                // 5) Desviación estándar (poblacional)
                // Fórmula: sqrt( sum((xi - prom)^2) / N )
                double sumaCuadrados = 0;
                for (int i = 0; i < n; i++)
                {
                    double diff = notas[i] - promedio;
                    sumaCuadrados += diff * diff;
                }

                double varianza = sumaCuadrados / n; // poblacional
                double desviacion = Math.Sqrt(varianza);

                // 6) Mostramos resultados
                ConsoleUI.Line();
                Console.WriteLine("RESULTADOS");
                ConsoleUI.Line();
                Console.WriteLine($"Cantidad de notas: {n}");
                Console.WriteLine($"Promedio:          {promedio:0.00}");
                Console.WriteLine($"Máxima:            {max:0.00}");
                Console.WriteLine($"Mínima:            {min:0.00}");
                Console.WriteLine($"Aprobados (>=65):  {aprobados}");
                Console.WriteLine($"Reprobados (<65):  {reprobados}");
                Console.WriteLine($"Desv. estándar:    {desviacion:0.00}");
            });
        }
    }
}
