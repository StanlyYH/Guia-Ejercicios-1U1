using System;
using GuiaEjercicios.App;

namespace GuiaEjercicios.Ejercicios.Bloque4
{
    // Ejercicio 24:
    // Llenar arreglo de 10 enteros y hacer:
    // - Búsqueda lineal
    // - Segundo mayor
    // - Ordenar ascendente (burbuja)
    // - Mostrar elementos en posiciones pares
    public static class Ejercicio24_BusquedaOrdenamiento
    {
        public static void Run()
        {
            ExerciseRunner.Run("Ejercicio 24: Búsqueda y ordenamiento", () =>
            {
                // 1) Llenamos el arreglo
                int[] arr = new int[10];

                ConsoleUI.Line();
                Console.WriteLine("Ingrese 10 números enteros:");
                ConsoleUI.Line();

                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = Input.ReadInt($"Número #{i + 1}: ", -1_000_000_000, 1_000_000_000);
                }

                // Mostramos el arreglo original
                ConsoleUI.Line();
                Console.WriteLine("Arreglo original:");
                PrintArray(arr);

                // 2) Búsqueda lineal
                ConsoleUI.Line();
                int buscar = Input.ReadInt("Ingrese un número para buscar (búsqueda lineal): ", -1_000_000_000, 1_000_000_000);
                int pos = LinearSearch(arr, buscar);

                if (pos == -1)
                    Console.WriteLine("Resultado: NO se encontró en el arreglo.");
                else
                    Console.WriteLine($"Resultado: Se encontró en la posición (índice) {pos}.");

                // 3) Segundo mayor
                ConsoleUI.Line();
                bool okSegundo = TrySecondLargest(arr, out int segundoMayor);

                if (okSegundo)
                    Console.WriteLine($"Segundo mayor: {segundoMayor}");
                else
                    ConsoleUI.Error("No se puede obtener segundo mayor (todos son iguales o no hay suficientes valores distintos).");

                // 4) Ordenar ascendente con burbuja (sin modificar el original)
                ConsoleUI.Line();
                int[] ordenado = (int[])arr.Clone();
                BubbleSortAscending(ordenado);

                Console.WriteLine("Arreglo ordenado (ascendente):");
                PrintArray(ordenado);

                // 5) Elementos en posiciones pares (índices 0,2,4,6,8)
                ConsoleUI.Line();
                Console.WriteLine("Elementos en posiciones pares (índices 0,2,4,6,8):");
                for (int i = 0; i < ordenado.Length; i += 2)
                {
                    Console.WriteLine($"Índice {i}: {ordenado[i]}");
                }
            });
        }

        private static int LinearSearch(int[] arr, int value)
        {
            // Recorremos desde el inicio y devolvemos el primer índice donde aparece
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value)
                    return i;
            }
            return -1;
        }

        private static bool TrySecondLargest(int[] arr, out int secondLargest)
        {
            // Buscamos el mayor y el segundo mayor (distintos)
            int largest = int.MinValue;
            secondLargest = int.MinValue;

            foreach (int x in arr)
            {
                if (x > largest)
                {
                    secondLargest = largest;
                    largest = x;
                }
                else if (x > secondLargest && x != largest)
                {
                    secondLargest = x;
                }
            }

            // Si secondLargest quedó en MinValue, puede ser que no exista segundo distinto
            // Revisamos si realmente hay al menos 2 valores distintos
            bool hayDistintos = false;
            foreach (int x in arr)
            {
                if (x != largest)
                {
                    hayDistintos = true;
                    break;
                }
            }

            if (!hayDistintos) return false;

            // secondLargest podría seguir en MinValue si largest era MinValue y no se actualizó bien
            // (caso raro), pero con 10 números normalmente está bien.
            return true;
        }

        private static void BubbleSortAscending(int[] arr)
        {
            // Ordenamiento burbuja (ascendente)
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        private static void PrintArray(int[] arr)
        {
            // Imprime en una línea, separado por comas
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                if (i < arr.Length - 1) Console.Write(", ");
            }
            Console.WriteLine();
        }
    }
}
