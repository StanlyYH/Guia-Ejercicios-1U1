using System;
using GuiaEjercicios.App;

namespace GuiaEjercicios.Ejercicios.Bloque2
{
    // Ejercicio 13:
    // Ingresar día, mes y año. Validar si es una fecha real (considerando bisiestos).
    public static class Ejercicio13_ValidadorFecha
    {
        public static void Run()
        {
            ExerciseRunner.Run("Ejercicio 13: Validador de fecha (día/mes/año)", () =>
            {
                // 1) Pedimos datos
                int anio = Input.ReadInt("Ingrese el año (ej: 2026): ", 1, 9999);
                int mes = Input.ReadInt("Ingrese el mes (1-12): ", 1, 12);
                int dia = Input.ReadInt("Ingrese el día (1-31): ", 1, 31);

                // 2) Calculamos días válidos del mes
                bool bisiesto = EsBisiesto(anio);
                int diasMes = DiasDelMes(mes, bisiesto);

                // 3) Validamos el día según el mes
                bool fechaValida = dia <= diasMes;

                ConsoleUI.Line();
                Console.WriteLine($"Fecha ingresada: {dia:00}/{mes:00}/{anio}");

                if (fechaValida)
                {
                    Console.WriteLine("Resultado: FECHA VÁLIDA ✅");
                }
                else
                {
                    Console.WriteLine("Resultado: FECHA NO VÁLIDA ❌");
                    Console.WriteLine($"Ese mes tiene {diasMes} día(s).");
                }
            });
        }

        private static bool EsBisiesto(int anio)
        {
            // Regla de bisiesto:
            // divisible entre 400 => sí
            // divisible entre 100 => no
            // divisible entre 4   => sí
            return (anio % 400 == 0) || (anio % 4 == 0 && anio % 100 != 0);
        }

        private static int DiasDelMes(int mes, bool bisiesto)
        {
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
