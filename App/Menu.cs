using System;
using GuiaEjercicios.App;
using GuiaEjercicios.Ejercicios.Bloque1;

namespace GuiaEjercicios.App
{
    public static class Menu
    {
        public static void Run()
        {
            int option;
            do
            {
                ConsoleUI.Clear();
                ConsoleUI.Title("GUÍA DE EJERCICIOS - UNIDAD 1 (POO) - MENÚ PRINCIPAL");

                Console.WriteLine("1) Bloque 1: Variables y Operadores (1-8)");
                Console.WriteLine("2) Bloque 2: Condicionales (9-14)");
                Console.WriteLine("3) Bloque 3: Ciclos (15-22)");
                Console.WriteLine("4) Bloque 4: Arreglos 1D (23-27)");
                Console.WriteLine("5) Bloque 5: Arreglos 2D (28-30)");
                Console.WriteLine("0) Salir");
                ConsoleUI.Line();

                option = Input.ReadInt("Seleccione una opción: ", 0, 5);

                switch (option)
                {
                    case 1: RunBloque1(); break;
                    case 2: RunBloque2(); break;
                    case 3: RunBloque3(); break;
                    case 4: RunBloque4(); break;
                    case 5: RunBloque5(); break;
                    case 0:
                        ConsoleUI.Info("Saliendo... ¡Éxitos!");
                        break;
                }

            } while (option != 0);
        }

        private static void RunBloque1()
        {
            int op;
            do
            {
                ConsoleUI.Clear();
                ConsoleUI.Title("BLOQUE 1: Variables y Operadores (1-8)");

                Console.WriteLine("1) Ejercicio 1: Calculadora de IMC");
                Console.WriteLine("2) Ejercicio 2: Conversión de temperatura");
                Console.WriteLine("3) Ejercicio 3: Desglose de billetes");
                Console.WriteLine("4) Ejercicio 4: Préstamo simple");
                Console.WriteLine("5) Ejercicio 5: Tiempo transcurrido");
                Console.WriteLine("6) Ejercicio 6: Área y perímetro");
                Console.WriteLine("7) Ejercicio 7: Unidades de almacenamiento");
                Console.WriteLine("8) Ejercicio 8: Salario semanal");
                Console.WriteLine("0) Volver al menú principal");
                ConsoleUI.Line();

                op = Input.ReadInt("Elija ejercicio: ", 0, 8);

                switch (op)
                {
                    case 1: Ejercicio01_IMC.Run(); break;

                    // Por ahora, si aún no has creado estos archivos, déjalos así.
                    // Cuando creemos cada ejercicio, solo reemplazamos el mensaje por EjercicioXX.Run().
                    case 2: Ejercicio02_Temperatura.Run(); break;


                    case 3: Ejercicio03_Billetes.Run(); break;


                    case 4: Ejercicio04_PrestamoSimple.Run(); break;


                    case 5:
                        ConsoleUI.Clear();
                        ConsoleUI.Title("Ejercicio 5: Tiempo transcurrido");
                        ConsoleUI.Info("Pendiente de implementar.");
                        ConsoleUI.Pause();
                        break;

                    case 6:
                        ConsoleUI.Clear();
                        ConsoleUI.Title("Ejercicio 6: Área y perímetro");
                        ConsoleUI.Info("Pendiente de implementar.");
                        ConsoleUI.Pause();
                        break;

                    case 7:
                        ConsoleUI.Clear();
                        ConsoleUI.Title("Ejercicio 7: Unidades de almacenamiento");
                        ConsoleUI.Info("Pendiente de implementar.");
                        ConsoleUI.Pause();
                        break;

                    case 8:
                        ConsoleUI.Clear();
                        ConsoleUI.Title("Ejercicio 8: Salario semanal");
                        ConsoleUI.Info("Pendiente de implementar.");
                        ConsoleUI.Pause();
                        break;
                }

            } while (op != 0);
        }

        private static void RunBloque2()
        {
            ConsoleUI.Clear();
            ConsoleUI.Title("BLOQUE 2: Condicionales (9-14)");
            ConsoleUI.Info("Bloque 2 pendiente. Primero completaremos Bloque 1 ejercicio por ejercicio.");
            ConsoleUI.Pause();
        }

        private static void RunBloque3()
        {
            ConsoleUI.Clear();
            ConsoleUI.Title("BLOQUE 3: Ciclos (15-22)");
            ConsoleUI.Info("Bloque 3 pendiente. Primero completaremos Bloque 1.");
            ConsoleUI.Pause();
        }

        private static void RunBloque4()
        {
            ConsoleUI.Clear();
            ConsoleUI.Title("BLOQUE 4: Arreglos Unidimensionales (23-27)");
            ConsoleUI.Info("Bloque 4 pendiente. Primero completaremos Bloque 1.");
            ConsoleUI.Pause();
        }

        private static void RunBloque5()
        {
            ConsoleUI.Clear();
            ConsoleUI.Title("BLOQUE 5: Arreglos Bidimensionales (28-30)");
            ConsoleUI.Info("Bloque 5 pendiente. Primero completaremos Bloque 1.");
            ConsoleUI.Pause();
        }
    }
}

