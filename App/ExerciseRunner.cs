using System;

namespace GuiaEjercicios.App
{
    public static class ExerciseRunner
    {
        // Ejecuta un ejercicio con plantilla estándar: título + ciclo Repetir/Volver
        public static void Run(string title, Action body)
        {
            int option;
            do
            {
                ConsoleUI.Clear();
                ConsoleUI.Title(title);

                body();

                ConsoleUI.Line();
                Console.WriteLine("1) Repetir ejercicio");
                Console.WriteLine("0) Volver al menú anterior");
                option = Input.ReadInt("Seleccione una opción: ", 0, 1);

            } while (option == 1);
        }
    }
}
