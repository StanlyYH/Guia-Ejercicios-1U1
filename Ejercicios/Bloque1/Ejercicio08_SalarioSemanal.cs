using System;
using GuiaEjercicios.App;

namespace GuiaEjercicios.Ejercicios.Bloque1
{
    // Ejercicio 8: Salario semanal con horas extra
    // Horas > 44 se pagan al 150% (1.5x).
    // Se muestra desglose y total.
    public static class Ejercicio08_SalarioSemanal
    {
        public static void Run()
        {
            ExerciseRunner.Run("Ejercicio 8: Salario semanal (horas extra al 150%)", () =>
            {
                double horas = Input.ReadDouble("Ingrese horas trabajadas (puede ser decimal): ", 0, 200);
                double tarifa = Input.ReadDouble("Ingrese tarifa por hora: ", 0.01, 1_000_000);

                double horasNormales = Math.Min(horas, 44);
                double horasExtras = Math.Max(0, horas - 44);

                double pagoNormal = horasNormales * tarifa;
                double pagoExtra = horasExtras * tarifa * 1.5;

                double total = pagoNormal + pagoExtra;

                ConsoleUI.Line();
                Console.WriteLine($"Horas normales: {horasNormales:0.##}  x L. {tarifa:0.00} = L. {pagoNormal:0.00}");
                Console.WriteLine($"Horas extra:    {horasExtras:0.##}  x L. {tarifa:0.00} x 1.50 = L. {pagoExtra:0.00}");
                ConsoleUI.Line();
                Console.WriteLine($"TOTAL A PAGAR:  L. {total:0.00}");
            });
        }
    }
}

