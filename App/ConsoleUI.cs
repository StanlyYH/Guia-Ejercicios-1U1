using System;

namespace GuiaEjercicios.App
{
    public static class ConsoleUI
    {
        public static void Clear() => Console.Clear();

        public static void Title(string text)
        {
            Line();
            Console.WriteLine(text);
            Line();
        }

        public static void Line() => Console.WriteLine(new string('-', 60));

        public static void Pause()
        {
            Console.WriteLine();
            Console.Write("Presione ENTER para continuar...");
            Console.ReadLine();
        }

        public static void Error(string message)
        {
            Console.WriteLine($"[ERROR] {message}");
        }

        public static void Info(string message)
        {
            Console.WriteLine($"[INFO] {message}");
        }
    }
}
