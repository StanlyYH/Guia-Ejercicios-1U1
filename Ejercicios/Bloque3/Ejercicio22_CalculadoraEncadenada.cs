using System;
using GuiaEjercicios.App;

namespace GuiaEjercicios.Ejercicios.Bloque3
{
    // Ejercicio 22:
    // Calculadora con menú que opera hasta que el usuario elija salir.
    // Incluye: +, -, *, /, potencia, raíz cuadrada y porcentaje.
    // Mantiene el último resultado para operaciones encadenadas.
    public static class Ejercicio22_CalculadoraEncadenada
    {
        public static void Run()
        {
            ExerciseRunner.Run("Ejercicio 22: Calculadora con menú (resultado encadenado)", () =>
            {
                double ultimoResultado = 0;
                bool tieneResultado = false;

                int op;
                do
                {
                    ConsoleUI.Clear();
                    ConsoleUI.Title("Calculadora (menú) - Resultado encadenado");

                    // Mostramos el estado actual
                    Console.WriteLine($"Último resultado: {(tieneResultado ? ultimoResultado.ToString("0.00") : "No hay")}");
                    ConsoleUI.Line();

                    // Menú de operaciones
                    Console.WriteLine("1) Sumar (+)");
                    Console.WriteLine("2) Restar (-)");
                    Console.WriteLine("3) Multiplicar (*)");
                    Console.WriteLine("4) Dividir (/)");
                    Console.WriteLine("5) Potencia (a^b)");
                    Console.WriteLine("6) Raíz cuadrada (√a)");
                    Console.WriteLine("7) Porcentaje (a * p / 100)");
                    Console.WriteLine("8) Reiniciar resultado (poner en 0)");
                    Console.WriteLine("0) Salir de la calculadora");
                    ConsoleUI.Line();

                    op = Input.ReadInt("Elija una opción: ", 0, 8);

                    if (op == 0) break;

                    // Para la mayoría de operaciones necesitamos un número base "a"
                    // Si ya hay resultado, preguntamos si quiere usarlo o ingresar uno nuevo.
                    double a = 0;

                    if (op != 8) // si no es reiniciar, necesitamos 'a'
                    {
                        a = GetBaseNumber(tieneResultado, ultimoResultado);
                    }

                    switch (op)
                    {
                        case 1: // suma
                        {
                            double b = Input.ReadDouble("Ingrese el segundo número: ", -1e12, 1e12);
                            ultimoResultado = a + b;
                            tieneResultado = true;
                            break;
                        }

                        case 2: // resta
                        {
                            double b = Input.ReadDouble("Ingrese el segundo número: ", -1e12, 1e12);
                            ultimoResultado = a - b;
                            tieneResultado = true;
                            break;
                        }

                        case 3: // multiplicación
                        {
                            double b = Input.ReadDouble("Ingrese el segundo número: ", -1e12, 1e12);
                            ultimoResultado = a * b;
                            tieneResultado = true;
                            break;
                        }

                        case 4: // división
                        {
                            double b = Input.ReadDouble("Ingrese el segundo número (no 0): ", -1e12, 1e12);
                            if (b == 0)
                            {
                                ConsoleUI.Error("No se puede dividir entre 0.");
                                ConsoleUI.Pause();
                                break;
                            }

                            ultimoResultado = a / b;
                            tieneResultado = true;
                            break;
                        }

                        case 5: // potencia
                        {
                            double b = Input.ReadDouble("Ingrese el exponente: ", -1e6, 1e6);
                            ultimoResultado = Math.Pow(a, b);
                            tieneResultado = true;
                            break;
                        }

                        case 6: // raíz cuadrada
                        {
                            if (a < 0)
                            {
                                ConsoleUI.Error("No se puede sacar raíz cuadrada de un número negativo.");
                                ConsoleUI.Pause();
                                break;
                            }

                            ultimoResultado = Math.Sqrt(a);
                            tieneResultado = true;
                            break;
                        }

                        case 7: // porcentaje
                        {
                            // Ej: a=200, p=10 => 20
                            double p = Input.ReadDouble("Ingrese el porcentaje (%): ", -1e6, 1e6);
                            ultimoResultado = a * (p / 100.0);
                            tieneResultado = true;
                            break;
                        }

                        case 8: // reiniciar
                        {
                            ultimoResultado = 0;
                            tieneResultado = true;
                            break;
                        }
                    }

                    // Mostramos resultado si se calculó algo (o se reinició)
                    ConsoleUI.Line();
                    Console.WriteLine($"Resultado: {ultimoResultado:0.00}");
                    ConsoleUI.Pause();

                } while (op != 0);
            });
        }

        private static double GetBaseNumber(bool tieneResultado, double ultimoResultado)
        {
            // Si no hay resultado previo, pedimos el número base directo.
            if (!tieneResultado)
                return Input.ReadDouble("Ingrese el primer número: ", -1e12, 1e12);

            // Si ya hay resultado, preguntamos si quiere usarlo.
            Console.WriteLine("¿Desea usar el último resultado como primer número?");
            Console.WriteLine("1) Sí");
            Console.WriteLine("2) No (ingresar uno nuevo)");
            int choice = Input.ReadInt("Opción: ", 1, 2);

            if (choice == 1) return ultimoResultado;

            return Input.ReadDouble("Ingrese el primer número: ", -1e12, 1e12);
        }
    }
}
