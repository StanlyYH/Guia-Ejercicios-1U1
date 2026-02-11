using System;
using GuiaEjercicios.Ejercicios.Bloque1;

namespace GuiaEjercicios.App
{
    // Menú principal del programa.
    // Aquí el usuario elige el bloque y luego el ejercicio.
    // El menú está en ciclo y termina cuando el usuario elige "Salir".
    public static class Menu
    {
        public static void Run()
        {
            int option;

            // Ciclo principal: se repite hasta que el usuario decida salir
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

                // Leemos opción y validamos rango
                option = Input.ReadInt("Seleccione una opción: ", 0, 5);

                // Mandamos al bloque correspondiente
                switch (option)
                {
                    case 1: RunBloque1(); break;
                    case 2: RunBloque2(); break;
                    case 3: RunBloque3(); break;
                    case 4: RunBloque4(); break;
                    case 5: RunBloque5(); break;
                }

            } while (option != 0);

            ConsoleUI.Clear();
            ConsoleUI.Info("Saliendo... ¡Éxitos!");
        }

        private static void RunBloque1()
        {
            int op;

            // Submenú del Bloque 1
            do
            {
                ConsoleUI.Clear();
                ConsoleUI.Title("BLOQUE 1: Variables y Operadores (1-8)");

                Console.WriteLine("1) Ejercicio 1: Calculadora de IMC");
                Console.WriteLine("2) Ejercicio 2: Conversión de temperatura");
                Console.WriteLine("3) Ejercicio 3: Desglose de billetes");
                Console.WriteLine("4) Ejercicio 4: Préstamo (cuota mensual fija)");
                Console.WriteLine("5) Ejercicio 5: Tiempo transcurrido (hh:mm:ss)");
                Console.WriteLine("6) Ejercicio 6: Área y perímetro (menú)");
                Console.WriteLine("7) Ejercicio 7: Unidades de almacenamiento");
                Console.WriteLine("8) Ejercicio 8: Salario semanal (horas extra)");
                Console.WriteLine("0) Volver al menú principal");
                ConsoleUI.Line();

                op = Input.ReadInt("Elija ejercicio: ", 0, 8);

                // Ejecutamos el ejercicio seleccionado
                switch (op)
                {
                    case 1: Ejercicio01_IMC.Run(); break;
                    case 2: Ejercicio02_Temperatura.Run(); break;
                    case 3: Ejercicio03_Billetes.Run(); break;
                    case 4: Ejercicio04_PrestamoSimple.Run(); break;
                    case 5: Ejercicio05_TiempoTranscurrido.Run(); break;
                    case 6: Ejercicio06_AreaPerimetro.Run(); break;
                    case 7: Ejercicio07_Almacenamiento.Run(); break;
                    case 8: Ejercicio08_SalarioSemanal.Run(); break;
                }

            } while (op != 0);
        }

        // Por ahora estos bloques quedan como "pendiente".
        // Mañana, cuando hagamos el Bloque 2, iremos activando y conectando ejercicios.

        private static void RunBloque2()
        {
            ConsoleUI.Clear();
            ConsoleUI.Title("BLOQUE 2: Condicionales (9-14)");
            ConsoleUI.Info("Pendiente. Mañana iniciamos este bloque.");
            ConsoleUI.Pause();
        }

        private static void RunBloque3()
        {
            ConsoleUI.Clear();
            ConsoleUI.Title("BLOQUE 3: Ciclos (15-22)");
            ConsoleUI.Info("Pendiente. Mañana iniciamos este bloque.");
            ConsoleUI.Pause();
        }

        private static void RunBloque4()
        {
            ConsoleUI.Clear();
            ConsoleUI.Title("BLOQUE 4: Arreglos Unidimensionales (23-27)");
            ConsoleUI.Info("Pendiente. Mañana iniciamos este bloque.");
            ConsoleUI.Pause();
        }

        private static void RunBloque5()
        {
            ConsoleUI.Clear();
            ConsoleUI.Title("BLOQUE 5: Arreglos Bidimensionales (28-30)");
            ConsoleUI.Info("Pendiente. Mañana iniciamos este bloque.");
            ConsoleUI.Pause();
        }
    }
}


