using System;
using GuiaEjercicios.App;

namespace GuiaEjercicios.Ejercicios.Bloque5
{
    // Ejercicio 29:
    // Juego de Gato (Tic-Tac-Toe) para 2 jugadores.
    // - Matriz 3x3
    // - Validar movimientos
    // - Detectar ganador o empate
    // - Permitir reiniciar
    public static class Ejercicio29_Gato
    {
        public static void Run()
        {
            ExerciseRunner.Run("Ejercicio 29: Juego de Gato (Tic-Tac-Toe)", () =>
            {
                bool jugarDeNuevo;

                do
                {
                    char[,] board = CrearTablero();
                    char jugador = 'X'; // X empieza

                    bool termino = false;

                    while (!termino)
                    {
                        ConsoleUI.Clear();
                        ConsoleUI.Title("JUEGO DE GATO (3x3)");
                        Console.WriteLine($"Turno del jugador: {jugador}");
                        ConsoleUI.Line();

                        DibujarTablero(board);
                        ConsoleUI.Line();

                        // Pedimos fila y columna (1-3) y las convertimos a índice (0-2)
                        int fila = Input.ReadInt("Ingrese fila (1-3): ", 1, 3) - 1;
                        int col = Input.ReadInt("Ingrese columna (1-3): ", 1, 3) - 1;

                        // Validamos si está libre
                        if (board[fila, col] != ' ')
                        {
                            ConsoleUI.Error("Esa casilla ya está ocupada. Intente otra.");
                            ConsoleUI.Pause();
                            continue;
                        }

                        // Colocamos la jugada
                        board[fila, col] = jugador;

                        // Revisamos si ganó
                        if (HayGanador(board, jugador))
                        {
                            ConsoleUI.Clear();
                            ConsoleUI.Title("JUEGO DE GATO (3x3)");
                            DibujarTablero(board);
                            ConsoleUI.Line();
                            Console.WriteLine($"¡Ganó el jugador {jugador}! 🎉");
                            termino = true;
                        }
                        // Si no ganó, revisamos empate
                        else if (TableroLleno(board))
                        {
                            ConsoleUI.Clear();
                            ConsoleUI.Title("JUEGO DE GATO (3x3)");
                            DibujarTablero(board);
                            ConsoleUI.Line();
                            Console.WriteLine("Empate 🤝 (no hay más movimientos).");
                            termino = true;
                        }
                        else
                        {
                            // Cambiamos de jugador
                            jugador = (jugador == 'X') ? 'O' : 'X';
                        }
                    }

                    ConsoleUI.Line();
                    Console.WriteLine("¿Desea reiniciar el juego?");
                    Console.WriteLine("1) Sí");
                    Console.WriteLine("2) No");
                    int op = Input.ReadInt("Opción: ", 1, 2);

                    jugarDeNuevo = (op == 1);

                } while (jugarDeNuevo);
            });
        }

        private static char[,] CrearTablero()
        {
            char[,] board = new char[3, 3];

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    board[i, j] = ' ';

            return board;
        }

        private static void DibujarTablero(char[,] board)
        {
            // Mostramos la cuadrícula con separadores
            Console.WriteLine("   1   2   3");
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"{i + 1}  ");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(board[i, j] == ' ' ? ' ' : board[i, j]);
                    if (j < 2) Console.Write(" | ");
                }
                Console.WriteLine();

                if (i < 2) Console.WriteLine("  ---+---+---");
            }
        }

        private static bool HayGanador(char[,] board, char jugador)
        {
            // Filas
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == jugador && board[i, 1] == jugador && board[i, 2] == jugador)
                    return true;
            }

            // Columnas
            for (int j = 0; j < 3; j++)
            {
                if (board[0, j] == jugador && board[1, j] == jugador && board[2, j] == jugador)
                    return true;
            }

            // Diagonal principal
            if (board[0, 0] == jugador && board[1, 1] == jugador && board[2, 2] == jugador)
                return true;

            // Diagonal secundaria
            if (board[0, 2] == jugador && board[1, 1] == jugador && board[2, 0] == jugador)
                return true;

            return false;
        }

        private static bool TableroLleno(char[,] board)
        {
            // Si hay algún espacio vacío, todavía no está lleno
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == ' ')
                        return false;
                }
            }
            return true;
        }
    }
}
