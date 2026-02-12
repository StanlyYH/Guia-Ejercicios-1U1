using System;
using GuiaEjercicios.App;

namespace GuiaEjercicios.Ejercicios.Bloque2
{
    // Ejercicio 14:
    // Simular retiro:
    // - Verificar múltiplo de 20
    // - No exceder el saldo (saldo fijo en código)
    // - Mostrar desglose de billetes
    public static class Ejercicio14_Cajero
    {
        public static void Run()
        {
            ExerciseRunner.Run("Ejercicio 14: Cajero automático (retiro)", () =>
            {
                // 1) Saldo inicial (puedes cambiarlo si quieres)
                int saldo = 5000;

                Console.WriteLine($"Saldo disponible: L. {saldo}");
                ConsoleUI.Line();

                // 2) Pedimos monto a retirar (entero)
                int retiro = Input.ReadInt("Ingrese el monto a retirar: ", 1, saldo);

                // 3) Validamos que sea múltiplo de 20
                if (retiro % 20 != 0)
                {
                    ConsoleUI.Error("El monto debe ser múltiplo de 20.");
                    return;
                }

                // 4) Validamos que no exceda el saldo
                if (retiro > saldo)
                {
                    ConsoleUI.Error("El monto excede el saldo disponible.");
                    return;
                }

                // 5) Desglose de billetes (greedy: del mayor al menor)
                int[] billetes = { 500, 200, 100, 50, 20 };
                int restante = retiro;

                ConsoleUI.Line();
                Console.WriteLine("Desglose de billetes:");

                foreach (int b in billetes)
                {
                    int cantidad = restante / b;
                    restante = restante % b;

                    Console.WriteLine($"L. {b,3}: {cantidad}");
                }

                // Como obligamos múltiplo de 20, el restante debería ser 0
                ConsoleUI.Line();

                int saldoFinal = saldo - retiro;
                Console.WriteLine($"Retiro aprobado: L. {retiro}");
                Console.WriteLine($"Saldo restante:  L. {saldoFinal}");
            });
        }
    }
}
