using System;
using GuiaEjercicios.App;

namespace GuiaEjercicios.Ejercicios.Bloque3
{
    // Ejercicio 15:
    // Solicitar un número y mostrar su tabla del 1 al 12 con formato alineado.
    public static class Ejercicio15_TablaMultiplicar
    {
        public static void Run()
        {
            ExerciseRunner.Run("Ejercicio 15: Tabla de multiplicar (1 al 12)", () =>
            {
                // 1) Pedimos el número
                int n = Input.ReadInt("Ingrese un número: ", -1_000_000, 1_000_000);

                ConsoleUI.Line();
                Console.WriteLine("Tabla del " + n);
                ConsoleUI.Line();

                // 2) Mostramos del 1 al 12
                for (int i = 1; i <= 12; i++)
                {
                    int resultado = n * i;

                    // Formato alineado (espacios fijos)
                    // Ejemplo:  7 x  3 =   21
                    Console.WriteLine($"{n,4} x {i,2} = {resultado,6}");
                }
            });
        }
    }
}
