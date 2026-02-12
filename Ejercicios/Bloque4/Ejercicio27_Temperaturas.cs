using System;
using GuiaEjercicios.App;

namespace GuiaEjercicios.Ejercicios.Bloque4
{
    // Ejercicio 27:
    // Registrar temperaturas de 7 días y mostrar:
    // - Promedio semanal
    // - Días sobre el promedio
    // - Día más caluroso
    // - Día más frío
    // - Variación entre días consecutivos
    public static class Ejercicio27_Temperaturas
    {
        public static void Run()
        {
            ExerciseRunner.Run("Ejercicio 27: Arreglo de temperaturas (7 días)", () =>
            {
                double[] temps = new double[7];

                ConsoleUI.Line();
                Console.WriteLine("Ingrese las temperaturas de los 7 días:");
                ConsoleUI.Line();

                // 1) Guardamos temperaturas
                for (int i = 0; i < 7; i++)
                {
                    temps[i] = Input.ReadDouble($"Día {i + 1}: ", -100, 100);
                }

                // 2) Promedio semanal
                double suma = 0;
                for (int i = 0; i < 7; i++)
                    suma += temps[i];

                double promedio = suma / 7.0;

                // 3) Días sobre el promedio
                int sobrePromedio = 0;
                for (int i = 0; i < 7; i++)
                {
                    if (temps[i] > promedio)
                        sobrePromedio++;
                }

                // 4) Día más caluroso y más frío
                double max = temps[0];
                double min = temps[0];
                int diaMax = 1;
                int diaMin = 1;

                for (int i = 1; i < 7; i++)
                {
                    if (temps[i] > max)
                    {
                        max = temps[i];
                        diaMax = i + 1;
                    }

                    if (temps[i] < min)
                    {
                        min = temps[i];
                        diaMin = i + 1;
                    }
                }

                // 5) Variación entre días consecutivos
                // Variación = temp(día i) - temp(día i-1)
                ConsoleUI.Line();
                Console.WriteLine("RESULTADOS");
                ConsoleUI.Line();
                Console.WriteLine($"Promedio semanal: {promedio:0.00}°");
                Console.WriteLine($"Días sobre el promedio: {sobrePromedio}");
                Console.WriteLine($"Día más caluroso: Día {diaMax} con {max:0.00}°");
                Console.WriteLine($"Día más frío:     Día {diaMin} con {min:0.00}°");

                ConsoleUI.Line();
                Console.WriteLine("Variación entre días consecutivos:");
                ConsoleUI.Line();

                for (int i = 1; i < 7; i++)
                {
                    double variacion = temps[i] - temps[i - 1];
                    Console.WriteLine($"Día {i} -> Día {i + 1}: {variacion:+0.00;-0.00;0.00}°");
                }
            });
        }
    }
}
