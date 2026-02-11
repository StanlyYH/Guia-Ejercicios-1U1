using System;
using GuiaEjercicios.App;

namespace GuiaEjercicios.Ejercicios.Bloque1
{
    // Ejercicio 7: Conversión de unidades de almacenamiento
    // Convierte entre Bytes, KB, MB, GB y TB según elección del usuario.
    public static class Ejercicio07_Almacenamiento
    {
        public static void Run()
        {
            ExerciseRunner.Run("Ejercicio 7: Conversión de almacenamiento (Bytes, KB, MB, GB, TB)", () =>
            {
                Console.WriteLine("Unidades disponibles:");
                Console.WriteLine("1) Bytes");
                Console.WriteLine("2) KB");
                Console.WriteLine("3) MB");
                Console.WriteLine("4) GB");
                Console.WriteLine("5) TB");
                ConsoleUI.Line();

                int from = Input.ReadInt("Convertir DESDE (1-5): ", 1, 5);
                int to = Input.ReadInt("Convertir HACIA (1-5): ", 1, 5);

                if (from == to)
                {
                    ConsoleUI.Error("La unidad de origen y destino no pueden ser la misma.");
                    return;
                }

                ConsoleUI.Line();
                double value = Input.ReadDouble("Ingrese el valor (positivo): ", 0.0000001, 1e18);

                // Convertimos todo a Bytes primero (base 1024)
                double bytes = ToBytes(value, from);

                // Luego de Bytes a la unidad destino
                double result = FromBytes(bytes, to);

                ConsoleUI.Line();
                Console.WriteLine($"Entrada:  {value:0.######} {UnitName(from)}");
                Console.WriteLine($"Salida:   {result:0.######} {UnitName(to)}");
            });
        }

        private static string UnitName(int unit)
        {
            return unit switch
            {
                1 => "Bytes",
                2 => "KB",
                3 => "MB",
                4 => "GB",
                5 => "TB",
                _ => "?"
            };
        }

        private static double ToBytes(double value, int unit)
        {
            const double k = 1024.0;

            // Convertir valor a Bytes según unidad de origen
            return unit switch
            {
                1 => value,                 // Bytes
                2 => value * k,             // KB -> Bytes
                3 => value * k * k,         // MB -> Bytes
                4 => value * k * k * k,     // GB -> Bytes
                5 => value * k * k * k * k, // TB -> Bytes
                _ => value
            };
        }

        private static double FromBytes(double bytes, int unit)
        {
            const double k = 1024.0;

            // Convertir Bytes a la unidad destino
            return unit switch
            {
                1 => bytes,                         // Bytes
                2 => bytes / k,                     // Bytes -> KB
                3 => bytes / (k * k),               // Bytes -> MB
                4 => bytes / (k * k * k),           // Bytes -> GB
                5 => bytes / (k * k * k * k),       // Bytes -> TB
                _ => bytes
            };
        }
    }
}

