using System;
using GuiaEjercicios.App;

namespace GuiaEjercicios.Ejercicios.Bloque4
{
    // Ejercicio 25:
    // Crear arreglo de N elementos.
    // Menú para:
    // - Rotar K posiciones a la izquierda
    // - Rotar K posiciones a la derecha
    // - Invertir el arreglo
    public static class Ejercicio25_RotacionArreglo
    {
        public static void Run()
        {
            ExerciseRunner.Run("Ejercicio 25: Rotación e inversión de arreglo", () =>
            {
                // 1) Pedimos N y llenamos el arreglo
                int n = Input.ReadInt("Ingrese N (cantidad de elementos, 1-200): ", 1, 200);
                int[] arr = new int[n];

                ConsoleUI.Line();
                Console.WriteLine("Ingrese los elementos del arreglo:");
                ConsoleUI.Line();

                for (int i = 0; i < n; i++)
                {
                    arr[i] = Input.ReadInt($"Elemento #{i + 1}: ", -1_000_000_000, 1_000_000_000);
                }

                int op;
                do
                {
                    ConsoleUI.Line();
                    Console.WriteLine("ARREGLO ACTUAL:");
                    PrintArray(arr);
                    ConsoleUI.Line();

                    // 2) Menú de opciones
                    Console.WriteLine("1) Rotar K posiciones a la izquierda");
                    Console.WriteLine("2) Rotar K posiciones a la derecha");
                    Console.WriteLine("3) Invertir el arreglo");
                    Console.WriteLine("0) Salir del ejercicio");
                    ConsoleUI.Line();

                    op = Input.ReadInt("Elija una opción: ", 0, 3);

                    if (op == 0) break;

                    if (op == 1)
                    {
                        int k = Input.ReadInt("Ingrese K (>= 0): ", 0, 1_000_000_000);
                        RotateLeft(arr, k);
                    }
                    else if (op == 2)
                    {
                        int k = Input.ReadInt("Ingrese K (>= 0): ", 0, 1_000_000_000);
                        RotateRight(arr, k);
                    }
                    else if (op == 3)
                    {
                        Reverse(arr);
                    }

                } while (op != 0);
            });
        }

        private static void RotateLeft(int[] arr, int k)
        {
            // Rotar a la izquierda:
            // [1,2,3,4,5], k=2 -> [3,4,5,1,2]
            int n = arr.Length;
            if (n == 0) return;

            k = k % n; // por si K es mayor que N
            if (k == 0) return;

            int[] temp = new int[n];

            for (int i = 0; i < n; i++)
            {
                int newIndex = i - k;
                if (newIndex < 0) newIndex += n;
                temp[newIndex] = arr[i];
            }

            // Copiamos de temp a arr
            for (int i = 0; i < n; i++)
                arr[i] = temp[i];
        }

        private static void RotateRight(int[] arr, int k)
        {
            // Rotar a la derecha:
            // [1,2,3,4,5], k=2 -> [4,5,1,2,3]
            int n = arr.Length;
            if (n == 0) return;

            k = k % n;
            if (k == 0) return;

            int[] temp = new int[n];

            for (int i = 0; i < n; i++)
            {
                int newIndex = i + k;
                if (newIndex >= n) newIndex -= n;
                temp[newIndex] = arr[i];
            }

            for (int i = 0; i < n; i++)
                arr[i] = temp[i];
        }

        private static void Reverse(int[] arr)
        {
            // Invertir el arreglo:
            // [1,2,3] -> [3,2,1]
            int i = 0;
            int j = arr.Length - 1;

            while (i < j)
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;

                i++;
                j--;
            }
        }

        private static void PrintArray(int[] arr)
        {
            // Imprimir arreglo en una línea
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                if (i < arr.Length - 1) Console.Write(", ");
            }
            Console.WriteLine();
        }
    }
}
