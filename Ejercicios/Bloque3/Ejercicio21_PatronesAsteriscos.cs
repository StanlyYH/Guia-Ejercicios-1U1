using System;
using GuiaEjercicios.App;

namespace GuiaEjercicios.Ejercicios.Bloque3
{
    // Ejercicio 21:
    // Menú para generar patrones:
    // 1) Triángulo
    // 2) Triángulo invertido
    // 3) Rombo
    // 4) Cuadrado hueco
    // El usuario define el tamaño.
    public static class Ejercicio21_PatronesAsteriscos
    {
        public static void Run()
        {
            ExerciseRunner.Run("Ejercicio 21: Patrones de asteriscos (menú)", () =>
            {
                Console.WriteLine("Seleccione un patrón:");
                Console.WriteLine("1) Triángulo");
                Console.WriteLine("2) Triángulo invertido");
                Console.WriteLine("3) Rombo");
                Console.WriteLine("4) Cuadrado hueco");
                ConsoleUI.Line();

                int op = Input.ReadInt("Opción: ", 1, 4);

                // Tamaño (positivo)
                // Para rombo, este tamaño será la "mitad" (ej: 4 => altura total 7)
                int n = Input.ReadInt("Ingrese el tamaño (1-30): ", 1, 30);

                ConsoleUI.Line();

                switch (op)
                {
                    case 1: Triangulo(n); break;
                    case 2: TrianguloInvertido(n); break;
                    case 3: Rombo(n); break;
                    case 4: CuadradoHueco(n); break;
                }
            });
        }

        private static void Triangulo(int n)
        {
            // Triángulo:
            // *
            // **
            // ***
            for (int fila = 1; fila <= n; fila++)
            {
                Console.WriteLine(new string('*', fila));
            }
        }

        private static void TrianguloInvertido(int n)
        {
            // Triángulo invertido:
            // ***
            // **
            // *
            for (int fila = n; fila >= 1; fila--)
            {
                Console.WriteLine(new string('*', fila));
            }
        }

        private static void Rombo(int n)
        {
            // Rombo de altura total (2n - 1)
            // Ej n=4:
            //    *
            //   ***
            //  *****
            // *******
            //  *****
            //   ***
            //    *

            // Parte de arriba (incluye el centro)
            for (int i = 1; i <= n; i++)
            {
                int espacios = n - i;
                int estrellas = 2 * i - 1;

                Console.WriteLine(new string(' ', espacios) + new string('*', estrellas));
            }

            // Parte de abajo
            for (int i = n - 1; i >= 1; i--)
            {
                int espacios = n - i;
                int estrellas = 2 * i - 1;

                Console.WriteLine(new string(' ', espacios) + new string('*', estrellas));
            }
        }

        private static void CuadradoHueco(int n)
        {
            // Cuadrado hueco:
            // *****
            // *   *
            // *   *
            // *****

            // Si n = 1, solo imprime "*"
            if (n == 1)
            {
                Console.WriteLine("*");
                return;
            }

            // Primera fila
            Console.WriteLine(new string('*', n));

            // Filas del medio
            for (int fila = 2; fila <= n - 1; fila++)
            {
                Console.WriteLine("*" + new string(' ', n - 2) + "*");
            }

            // Última fila
            Console.WriteLine(new string('*', n));
        }
    }
}
