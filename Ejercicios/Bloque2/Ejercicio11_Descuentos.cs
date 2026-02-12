using System;
using GuiaEjercicios.App;

namespace GuiaEjercicios.Ejercicios.Bloque2
{
    // Ejercicio 11:
    // Según el monto de compra aplicar descuentos:
    // 5%  (L500 - L999)
    // 10% (L1000 - L2499)
    // 15% (L2500+)
    // Mostrar: precio original, descuento y precio final.
    public static class Ejercicio11_Descuentos
    {
        public static void Run()
        {
            ExerciseRunner.Run("Ejercicio 11: Descuentos escalonados", () =>
            {
                // 1) Pedimos monto de compra (positivo)
                double monto = Input.ReadDouble("Ingrese el monto de compra (L): ", 0.01, 1_000_000_000);

                // 2) Determinamos el porcentaje de descuento según el rango
                double porcentaje = 0;

                if (monto >= 500 && monto <= 999)
                    porcentaje = 0.05;
                else if (monto >= 1000 && monto <= 2499)
                    porcentaje = 0.10;
                else if (monto >= 2500)
                    porcentaje = 0.15;

                // 3) Calculamos descuento y precio final
                double descuento = monto * porcentaje;
                double total = monto - descuento;

                // 4) Mostramos resultados
                ConsoleUI.Line();
                Console.WriteLine($"Precio original: L. {monto:0.00}");
                Console.WriteLine($"Descuento:       {porcentaje * 100:0}%  (L. {descuento:0.00})");
                Console.WriteLine($"Precio final:    L. {total:0.00}");
            });
        }
    }
}
