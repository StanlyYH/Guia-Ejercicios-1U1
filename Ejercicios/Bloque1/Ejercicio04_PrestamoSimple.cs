using System;
using GuiaEjercicios.App;

namespace GuiaEjercicios.Ejercicios.Bloque1
{
    // Ejercicio 4: Préstamo con cuota mensual fija (amortizado)
    // Pedimos: monto, tasa anual y plazo en meses
    // Calculamos: cuota fija mensual e interés total
    public static class Ejercicio04_PrestamoSimple
    {
        public static void Run()
        {
            ExerciseRunner.Run("Ejercicio 4: Préstamo (cuota mensual fija)", () =>
            {
                // Monto del préstamo (principal)
                double monto = Input.ReadDouble("Ingrese el monto del préstamo: ", 0.01, 1_000_000_000);

                // Tasa anual en porcentaje (ej: 12 para 12%)
                double tasaAnualPct = Input.ReadDouble("Ingrese la tasa de interés anual (%): ", 0, 10_000);

                // Plazo en meses
                int meses = Input.ReadInt("Ingrese el plazo en meses: ", 1, 1_000_000);

                // Convertimos tasa anual % a tasa mensual decimal
                double tasaMensual = (tasaAnualPct / 100.0) / 12.0;

                double cuota;

                // Si la tasa es 0%, la cuota es simplemente monto/meses
                if (tasaMensual == 0)
                {
                    cuota = monto / meses;
                }
                else
                {
                    // Fórmula de cuota fija (anualidad):
                    // cuota = P * r * (1+r)^n / ((1+r)^n - 1)
                    double factor = Math.Pow(1 + tasaMensual, meses);
                    cuota = monto * tasaMensual * factor / (factor - 1);
                }

                double totalPagado = cuota * meses;
                double interesTotal = totalPagado - monto;

                ConsoleUI.Line();
                Console.WriteLine($"Monto del préstamo:   L. {monto:0.00}");
                Console.WriteLine($"Tasa anual:           {tasaAnualPct:0.00}%");
                Console.WriteLine($"Plazo:                {meses} meses");
                ConsoleUI.Line();
                Console.WriteLine($"Cuota mensual fija:   L. {cuota:0.00}");
                Console.WriteLine($"Total pagado:         L. {totalPagado:0.00}");
                Console.WriteLine($"Interés total:        L. {interesTotal:0.00}");
            });
        }
    }
}


