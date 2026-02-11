using System;
using GuiaEjercicios.App;

namespace GuiaEjercicios.Ejercicios.Bloque1
{
    // Ejercicio 5: Tiempo transcurrido (24h con segundos)
    // Pedimos 2 horas en formato 24h (hora:minuto:segundo) y calculamos la diferencia.
    // Si la hora final es menor que la inicial, asumimos que es al día siguiente.
    public static class Ejercicio05_TiempoTranscurrido
    {
        public static void Run()
        {
            ExerciseRunner.Run("Ejercicio 5: Tiempo transcurrido (hh:mm:ss)", () =>
            {
                Console.WriteLine("Ingrese la hora de INICIO (24h)");
                int h1 = Input.ReadInt("Hora (0-23): ", 0, 23);
                int m1 = Input.ReadInt("Minutos (0-59): ", 0, 59);
                int s1 = Input.ReadInt("Segundos (0-59): ", 0, 59);

                ConsoleUI.Line();

                Console.WriteLine("Ingrese la hora de FIN (24h)");
                int h2 = Input.ReadInt("Hora (0-23): ", 0, 23);
                int m2 = Input.ReadInt("Minutos (0-59): ", 0, 59);
                int s2 = Input.ReadInt("Segundos (0-59): ", 0, 59);

                // Convertimos todo a segundos para calcular fácil
                int inicio = h1 * 3600 + m1 * 60 + s1;
                int fin = h2 * 3600 + m2 * 60 + s2;

                int diff = fin - inicio;

                // Si la hora final es menor, asumimos que pasó a la madrugada del día siguiente
                if (diff < 0)
                    diff += 24 * 3600;

                int horas = diff / 3600;
                diff %= 3600;
                int minutos = diff / 60;
                int segundos = diff % 60;

                ConsoleUI.Line();
                Console.WriteLine($"Inicio: {h1:00}:{m1:00}:{s1:00}");
                Console.WriteLine($"Fin:    {h2:00}:{m2:00}:{s2:00}");
                ConsoleUI.Line();
                Console.WriteLine($"Diferencia: {horas} hora(s), {minutos} minuto(s), {segundos} segundo(s)");
            });
        }
    }
}
