using System;
using System.Globalization;

namespace GuiaEjercicios.App
{
    public static class Input
    {
        public static int ReadInt(string prompt, int min = int.MinValue, int max = int.MaxValue)
        {
            while (true)
            {
                Console.Write(prompt);
                string? txt = Console.ReadLine();

                if (int.TryParse(txt, out int value) && value >= min && value <= max)
                    return value;

                ConsoleUI.Error($"Entrada inválida. Ingrese un entero entre {min} y {max}.");
            }
        }

        public static double ReadDouble(string prompt, double min = double.MinValue, double max = double.MaxValue)
        {
            while (true)
            {
                Console.Write(prompt);
                string? txt = Console.ReadLine();

                // Acepta coma o punto como decimal
                txt = txt?.Trim().Replace(',', '.');

                if (double.TryParse(txt, NumberStyles.Any, CultureInfo.InvariantCulture, out double value)
                    && value >= min && value <= max)
                {
                    return value;
                }

                ConsoleUI.Error($"Entrada inválida. Ingrese un número entre {min} y {max}.");
            }
        }

        public static string ReadString(string prompt, bool allowEmpty = false)
        {
            while (true)
            {
                Console.Write(prompt);
                string? txt = Console.ReadLine();

                if (txt is null) txt = "";
                txt = txt.Trim();

                if (allowEmpty || txt.Length > 0)
                    return txt;

                ConsoleUI.Error("Entrada inválida. No puede estar vacío.");
            }
        }

        public static char ReadCharOption(string prompt, params char[] allowed)
        {
            while (true)
            {
                Console.Write(prompt);
                string? txt = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(txt))
                {
                    char c = char.ToUpperInvariant(txt.Trim()[0]);
                    foreach (var a in allowed)
                        if (char.ToUpperInvariant(a) == c) return c;
                }

                ConsoleUI.Error($"Opción inválida. Permitidas: {string.Join(", ", allowed)}");
            }
        }
    }
}

