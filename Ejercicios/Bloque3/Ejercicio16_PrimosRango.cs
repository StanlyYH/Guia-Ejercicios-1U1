using System;
using GuiaEjercicios.App;

namespace GuiaEjercicios.Ejercicios.Bloque3
{
    // Ejercicio 16:
    // Dado un rango (inicio, fin), mostrar todos los números primos y contar cuántos hay.
    public static class Ejercicio16_PrimosRango
    {
        public static void Run()
        {
            ExerciseRunner.Run("Ejercicio 16: Números primos en un rango", () =>
            {
                // 1) Pedimos el rango
                int inicio = Input.ReadInt("Ingrese el inicio del rango: ", -1_000_000, 1_000_000);
                int fin = Input.ReadInt("Ingrese el fin del rango: ", -1_000_000, 1_000_000);

                // 2) Si viene al revés, lo acomodamos
                if (inicio > fin)
                {
                    int temp = inicio;
                    inicio = fin;
                    fin = temp;
                }

                ConsoleUI.Line();
                Console.WriteLine($"Primos entre {inicio} y {fin}:");
                ConsoleUI.Line();

                int contador = 0;

                // 3) Recorremos el rango y verificamos si es primo
                for (int n = inicio; n <= fin; n++)
                {
                    if (EsPrimo(n))
                    {
                        Console.Write(n + " ");
                        contador++;
                    }
                }

                ConsoleUI.Line();
                Console.WriteLine($"Cantidad de números primos: {contador}");
            });
        }

        private static bool EsPrimo(int n)
        {
            // Números menores que 2 NO son primos
            if (n < 2) return false;

            // 2 sí es primo
            if (n == 2) return true;

            // Los pares mayores que 2 NO son primos
            if (n % 2 == 0) return false;

            // Revisamos divisores hasta la raíz cuadrada
            int limite = (int)Math.Sqrt(n);
            for (int i = 3; i <= limite; i += 2)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }
    }
}
