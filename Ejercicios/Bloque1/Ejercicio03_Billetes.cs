using System;
using GuiaEjercicios.App;

namespace GuiaEjercicios.Ejercicios.Bloque1
{
    // Ejercicio 3: Desglose de billetes
    // Dado un monto, mostrar cuántos billetes de cada denominación se necesitan.
    public static class Ejercicio03_Billetes
    {
        public static void Run()
        {
            ExerciseRunner.Run("Ejercicio 3: Desglose de billetes", () =>
            {
                // Pedimos un monto entero (por ejemplo en Lempiras)
                int monto = Input.ReadInt("Ingrese el monto (entero, sin centavos): ", 0, int.MaxValue);

                // Denominaciones típicas (ajusta si tu guía usa otras)
                int[] billetes = { 500, 200, 100, 50, 20, 10, 5, 2, 1 };

                ConsoleUI.Line();
                Console.WriteLine($"Monto ingresado: L. {monto}");
                Console.WriteLine("Desglose:");

                int restante = monto;

                // Vamos sacando billetes desde el más grande al más pequeño
                foreach (int b in billetes)
                {
                    int cantidad = restante / b;   // cuántos billetes de este valor caben
                    restante = restante % b;       // lo que queda después de usar esos billetes

                    Console.WriteLine($"L. {b,3}: {cantidad}");
                }

                ConsoleUI.Line();
                Console.WriteLine($"Restante final: L. {restante} (debería quedar 0)");
            });
        }
    }
}
