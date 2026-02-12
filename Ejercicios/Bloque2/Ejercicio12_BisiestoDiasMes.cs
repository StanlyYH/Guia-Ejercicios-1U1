using System;
using GuiaEjercicios.App;

namespace GuiaEjercicios.Ejercicios.Bloque2
{
    // Ejercicio 12:
    // Solicitar año y mes, determinar si es bisiesto y mostrar cuántos días tiene ese mes.
    public static class Ejercicio12_BisiestoDiasMes
    {
        public static void Run()
        {
            ExerciseRunner.Run("Ejercicio 12: Año bisiesto y días del mes", () =>
            {
                // 1) Pedimos datos
                int anio = Input.ReadInt("Ingrese el año (ej: 2026): ", 1, 9999);
                int mes = Input.ReadInt("Ingrese el mes (1-12): ", 1, 12);

                // 2) Calculamos si es bisiesto
                bool bisiesto = EsBisiesto(anio);

                // 3) Obtenemos días del mes
                int dias = DiasDelMes(mes, bisiesto);

                ConsoleUI.Line();
                Console.WriteLine($"Año: {anio}  -> {(bisiesto ? "Bisiesto" : "No bisiesto")}");
                Console.WriteLine($"Mes: {mes}   -> Días: {dias}");
            });
        }

        private static bool EsBisiesto(int anio)
        {
            // Regla:
            // - divisible entre 400 => bisiesto
            // - divisible entre 100 => NO bisiesto
            // - divisible entre 4   => bisiesto
            return (anio % 400 == 0) || (anio % 4 == 0 && anio % 100 != 0);
        }

        private static int DiasDelMes(int mes, bool bisiesto)
        {
            // Días por mes (febrero depende de bisiesto)
            return mes switch
            {
                1 => 31,
                2 => bisiesto ? 29 : 28,
                3 => 31,
                4 => 30,
                5 => 31,
                6 => 30,
                7 => 31,
                8 => 31,
                9 => 30,
                10 => 31,
                11 => 30,
                12 => 31,
                _ => 0
            };
        }
    }
}
