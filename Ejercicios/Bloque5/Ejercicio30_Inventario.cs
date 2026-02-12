using System;
using GuiaEjercicios.App;

namespace GuiaEjercicios.Ejercicios.Bloque5
{
    // Ejercicio 30:
    // Inventario simple:
    // - Matriz para 5 productos con: código, cantidad y precio
    // - Nombre en arreglo paralelo de strings
    // - Menú: mostrar, buscar, actualizar cantidad, valor total del inventario
    public static class Ejercicio30_Inventario
    {
        public static void Run()
        {
            ExerciseRunner.Run("Ejercicio 30: Inventario simple (5 productos)", () =>
            {
                const int N = 5;

                // Matriz: [i,0]=código, [i,1]=cantidad, [i,2]=precioEnCentavos
                int[,] datos = new int[N, 3];

                // Arreglo paralelo para nombres
                string[] nombres = new string[N];

                // 1) Cargar datos iniciales (manual, como principiante)
                InicializarInventario(datos, nombres);

                int op;
                do
                {
                    ConsoleUI.Clear();
                    ConsoleUI.Title("INVENTARIO SIMPLE (5 productos)");

                    Console.WriteLine("1) Mostrar inventario");
                    Console.WriteLine("2) Buscar producto por código");
                    Console.WriteLine("3) Actualizar cantidad por código");
                    Console.WriteLine("4) Calcular valor total del inventario");
                    Console.WriteLine("0) Salir del ejercicio");
                    ConsoleUI.Line();

                    op = Input.ReadInt("Elija una opción: ", 0, 4);

                    switch (op)
                    {
                        case 1:
                            MostrarInventario(datos, nombres);
                            break;

                        case 2:
                            BuscarProducto(datos, nombres);
                            break;

                        case 3:
                            ActualizarCantidad(datos, nombres);
                            break;

                        case 4:
                            CalcularValorTotal(datos, nombres);
                            break;
                    }

                } while (op != 0);
            });
        }

        private static void InicializarInventario(int[,] datos, string[] nombres)
        {
            // Puedes cambiar estos valores si quieres.
            // Precio en centavos: L. 25.50 -> 2550
            nombres[0] = "Cuaderno";
            datos[0, 0] = 101;  // código
            datos[0, 1] = 20;   // cantidad
            datos[0, 2] = 2550; // precio centavos

            nombres[1] = "Lapiz";
            datos[1, 0] = 102;
            datos[1, 1] = 100;
            datos[1, 2] = 350;

            nombres[2] = "Borrador";
            datos[2, 0] = 103;
            datos[2, 1] = 50;
            datos[2, 2] = 500;

            nombres[3] = "Regla";
            datos[3, 0] = 104;
            datos[3, 1] = 30;
            datos[3, 2] = 1200;

            nombres[4] = "Marcador";
            datos[4, 0] = 105;
            datos[4, 1] = 15;
            datos[4, 2] = 1800;
        }

        private static void MostrarInventario(int[,] datos, string[] nombres)
        {
            ConsoleUI.Clear();
            ConsoleUI.Title("Inventario");

            Console.WriteLine("COD   NOMBRE        CANT   PRECIO");
            ConsoleUI.Line();

            for (int i = 0; i < nombres.Length; i++)
            {
                int codigo = datos[i, 0];
                int cant = datos[i, 1];
                int precioCent = datos[i, 2];

                Console.WriteLine($"{codigo,3}  {nombres[i],-12}  {cant,4}   L. {CentavosALempiras(precioCent),7:0.00}");
            }

            ConsoleUI.Line();
            ConsoleUI.Pause();
        }

        private static void BuscarProducto(int[,] datos, string[] nombres)
        {
            ConsoleUI.Clear();
            ConsoleUI.Title("Buscar producto");

            int codigo = Input.ReadInt("Ingrese el código: ", 1, 1_000_000);

            int idx = BuscarIndicePorCodigo(datos, codigo);

            ConsoleUI.Line();

            if (idx == -1)
            {
                ConsoleUI.Error("Producto no encontrado.");
                ConsoleUI.Pause();
                return;
            }

            Console.WriteLine($"Código:   {datos[idx, 0]}");
            Console.WriteLine($"Nombre:   {nombres[idx]}");
            Console.WriteLine($"Cantidad: {datos[idx, 1]}");
            Console.WriteLine($"Precio:   L. {CentavosALempiras(datos[idx, 2]):0.00}");

            ConsoleUI.Line();
            ConsoleUI.Pause();
        }

        private static void ActualizarCantidad(int[,] datos, string[] nombres)
        {
            ConsoleUI.Clear();
            ConsoleUI.Title("Actualizar cantidad");

            int codigo = Input.ReadInt("Ingrese el código: ", 1, 1_000_000);

            int idx = BuscarIndicePorCodigo(datos, codigo);

            if (idx == -1)
            {
                ConsoleUI.Line();
                ConsoleUI.Error("Producto no encontrado.");
                ConsoleUI.Pause();
                return;
            }

            ConsoleUI.Line();
            Console.WriteLine($"Producto: {nombres[idx]} (Código {datos[idx, 0]})");
            Console.WriteLine($"Cantidad actual: {datos[idx, 1]}");
            ConsoleUI.Line();

            int nuevaCant = Input.ReadInt("Ingrese la nueva cantidad (>=0): ", 0, 1_000_000);
            datos[idx, 1] = nuevaCant;

            ConsoleUI.Line();
            Console.WriteLine("Cantidad actualizada correctamente ✅");
            ConsoleUI.Pause();
        }

        private static void CalcularValorTotal(int[,] datos, string[] nombres)
        {
            ConsoleUI.Clear();
            ConsoleUI.Title("Valor total del inventario");

            long totalCentavos = 0;

            for (int i = 0; i < nombres.Length; i++)
            {
                int cant = datos[i, 1];
                int precioCent = datos[i, 2];

                totalCentavos += (long)cant * precioCent;
            }

            ConsoleUI.Line();
            Console.WriteLine($"Valor total del inventario: L. {CentavosALempiras(totalCentavos):0.00}");
            ConsoleUI.Line();
            ConsoleUI.Pause();
        }

        private static int BuscarIndicePorCodigo(int[,] datos, int codigo)
        {
            // Búsqueda simple (lineal)
            for (int i = 0; i < datos.GetLength(0); i++)
            {
                if (datos[i, 0] == codigo)
                    return i;
            }
            return -1;
        }

        private static double CentavosALempiras(long centavos)
        {
            return centavos / 100.0;
        }
    }
}
