using System;
using GuiaEjercicios.Ejercicios.Bloque1;
using GuiaEjercicios.Ejercicios.Bloque2;
using GuiaEjercicios.Ejercicios.Bloque3;
using GuiaEjercicios.Ejercicios.Bloque4;
using GuiaEjercicios.Ejercicios.Bloque5;

namespace GuiaEjercicios.App
{
    // Menú principal y submenús por bloques.
    // La idea: el menú siempre está completo, pero solo llamamos (case) lo que ya existe.
    public static class Menu
    {
        public static void Run()
        {
            int option;

            // Menú principal en ciclo hasta que el usuario elija salir
            do
            {
                ConsoleUI.Clear();
                ConsoleUI.Title("GUÍA DE EJERCICIOS - UNIDAD 1 (POO)");

                Console.WriteLine("1) Bloque 1: Variables y Operadores (1-8)");
                Console.WriteLine("2) Bloque 2: Condicionales (9-14)");
                Console.WriteLine("3) Bloque 3: Ciclos (15-22)");
                Console.WriteLine("4) Bloque 4: Arreglos Unidimensionales (23-27)");
                Console.WriteLine("5) Bloque 5: Arreglos Bidimensionales (28-30)");
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
                }

            } while (option != 0);

            ConsoleUI.Clear();
            ConsoleUI.Info("Saliendo... ¡Éxitos!");
        }

        // -------------------------
        // BLOQUE 1 (1-8)
        // -------------------------
        private static void RunBloque1()
        {
            int op;

            do
            {
                ConsoleUI.Clear();
                ConsoleUI.Title("BLOQUE 1: Variables y Operadores (1-8)");

                Console.WriteLine("1) Calculadora de IMC");
                Console.WriteLine("2) Conversión de temperatura (C, F, K)");
                Console.WriteLine("3) Desglose de billetes (Lempiras)");
                Console.WriteLine("4) Calculadora de préstamo (cuota mensual fija)");
                Console.WriteLine("5) Tiempo transcurrido (hh:mm:ss)");
                Console.WriteLine("6) Área y perímetro (círculo, triángulo, rectángulo, trapecio)");
                Console.WriteLine("7) Conversión de almacenamiento (Bytes, KB, MB, GB, TB)");
                Console.WriteLine("8) Cálculo de salario semanal (extras +44 al 150%)");
                Console.WriteLine("0) Volver al menú principal");
                ConsoleUI.Line();

                op = Input.ReadInt("Elija ejercicio: ", 0, 8);

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

        // -------------------------
        // BLOQUE 2 (9-14)
        // -------------------------
        private static void RunBloque2()
        {
            int op;

            do
            {
                ConsoleUI.Clear();
                ConsoleUI.Title("BLOQUE 2: Condicionales (9-14)");

                Console.WriteLine("9)  Clasificación de triángulos (validez, por lados y por ángulos)");
                Console.WriteLine("10) Sistema de calificaciones UNAH (0-100, letra, descripción, aprobó/reprobó)");
                Console.WriteLine("11) Calculadora de descuentos (5%, 10%, 15% según monto)");
                Console.WriteLine("12) Año bisiesto y días del mes");
                Console.WriteLine("13) Validador de fecha (día/mes/año)");
                Console.WriteLine("14) Cajero automático (múltiplo de 20, no exceder saldo, desglose billetes)");
                Console.WriteLine("0) Volver al menú principal");
                ConsoleUI.Line();

                op = Input.ReadInt("Elija ejercicio: ", 0, 14);

                switch (op)
                {
                    case 9: Ejercicio09_Triangulos.Run(); break;
                    case 10: Ejercicio10_CalificacionesUNAH.Run(); break;
                    case 11: Ejercicio11_Descuentos.Run(); break;
                    case 12: Ejercicio12_BisiestoDiasMes.Run(); break;
                    case 13: Ejercicio13_ValidadorFecha.Run(); break;
                    case 14: Ejercicio14_Cajero.Run(); break;
                }

            } while (op != 0);
        }

        // -------------------------
        // BLOQUE 3 (15-22)
        // -------------------------
        private static void RunBloque3()
        {
            int op;

            do
            {
                ConsoleUI.Clear();
                ConsoleUI.Title("BLOQUE 3: Ciclos (15-22)");

                Console.WriteLine("15) Tabla de multiplicar extendida (1 al 12, formato alineado)");
                Console.WriteLine("16) Números primos en rango (mostrar y contar)");
                Console.WriteLine("17) Serie Fibonacci (N términos, suma y promedio)");
                Console.WriteLine("18) Factorial y combinaciones C(n,r)");
                Console.WriteLine("19) Juego de adivinanza (1-100, 7 intentos, pistas y estadísticas)");
                Console.WriteLine("20) Validación de contraseña (reglas y feedback)");
                Console.WriteLine("21) Patrón de asteriscos (menú: triángulos, rombo, cuadrado hueco)");
                Console.WriteLine("22) Calculadora con menú (básicas, potencia, raíz, % y resultado encadenado)");
                Console.WriteLine("0) Volver al menú principal");
                ConsoleUI.Line();

                op = Input.ReadInt("Elija ejercicio: ", 0, 22);

                switch (op)
                {
                    case 15: Ejercicio15_TablaMultiplicar.Run(); break;
                    case 16: Ejercicio16_PrimosRango.Run(); break;
                    case 17: Ejercicio17_Fibonacci.Run(); break;
                    case 18: Ejercicio18_FactorialCombinaciones.Run(); break;
                    case 19: Ejercicio19_Adivinanza.Run(); break;
                    case 20: Ejercicio20_Contrasena.Run(); break;
                    case 21: Ejercicio21_PatronesAsteriscos.Run(); break;
                    case 22: Ejercicio22_CalculadoraEncadenada.Run(); break;
                }

            } while (op != 0);
        }

        // -------------------------
        // BLOQUE 4 (23-27)
        // -------------------------
        private static void RunBloque4()
        {
            int op;

            do
            {
                ConsoleUI.Clear();
                ConsoleUI.Title("BLOQUE 4: Arreglos Unidimensionales (23-27)");

                Console.WriteLine("23) Estadísticas de calificaciones (prom, max, min, aprob/reprob, desv std)");
                Console.WriteLine("24) Búsqueda y ordenamiento (lineal, 2do mayor, burbuja, posiciones pares)");
                Console.WriteLine("25) Rotación de arreglo (izq, der, invertir)");
                Console.WriteLine("26) Frecuencia de elementos (20 aleatorios 1-10, más/menos frecuente)");
                Console.WriteLine("27) Arreglo de temperaturas (7 días, promedio, extremos, variación)");
                Console.WriteLine("0) Volver al menú principal");
                ConsoleUI.Line();

                op = Input.ReadInt("Elija ejercicio: ", 0, 27);

                switch (op)
                {
                    case 23: Ejercicio23_EstadisticasCalificaciones.Run(); break;
                    case 24: Ejercicio24_BusquedaOrdenamiento.Run(); break;
                    case 25: Ejercicio25_RotacionArreglo.Run(); break;
                    case 26: Ejercicio26_FrecuenciaElementos.Run(); break;
                    case 27: Ejercicio27_Temperaturas.Run(); break;
                }

            } while (op != 0);
        }

        // -------------------------
        // BLOQUE 5 (28-30)
        // -------------------------
        private static void RunBloque5()
        {
            int op;

            do
            {
                ConsoleUI.Clear();
                ConsoleUI.Title("BLOQUE 5: Arreglos Bidimensionales (28-30)");

                Console.WriteLine("28) Matriz de notas por parcial (N x 3, promedios y mejor estudiante)");
                Console.WriteLine("29) Juego de Gato (Tic-Tac-Toe) 3x3 (validar, ganador/empate, reiniciar)");
                Console.WriteLine("30) Inventario simple (5 productos: código, nombre, cant, precio y menú)");
                Console.WriteLine("0) Volver al menú principal");
                ConsoleUI.Line();

                op = Input.ReadInt("Elija ejercicio: ", 0, 30);

                switch (op)
                {
                    case 28: Ejercicio28_MatrizNotas.Run(); break;
                    case 29: Ejercicio29_Gato.Run(); break;
                    case 30: Ejercicio30_Inventario.Run(); break;
                }

            } while (op != 0);
        }
    }
}



