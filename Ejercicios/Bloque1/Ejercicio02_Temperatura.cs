using System;
using GuiaEjercicios.App;

namespace GuiaEjercicios.Ejercicios.Bloque1
{
    public static class Ejercicio02_Temperatura
    {
        public static void Run()
        {
            ExerciseRunner.Run("Ejercicio 2: Conversión de temperatura (C, F, K)", () =>
            {
                Console.WriteLine("Seleccione la conversión:");
                Console.WriteLine("1) Celsius -> Fahrenheit");
                Console.WriteLine("2) Fahrenheit -> Celsius");
                Console.WriteLine("3) Celsius -> Kelvin");
                Console.WriteLine("4) Kelvin -> Celsius");
                Console.WriteLine("5) Fahrenheit -> Kelvin");
                Console.WriteLine("6) Kelvin -> Fahrenheit");
                ConsoleUI.Line();

                int op = Input.ReadInt("Opción: ", 1, 6);

                double inputTemp;
                double result;
                string fromUnit = "";
                string toUnit = "";

                switch (op)
                {
                    case 1:
                        fromUnit = "°C"; toUnit = "°F";
                        inputTemp = Input.ReadDouble("Ingrese temperatura en Celsius: ", -273.15, 1_000_000);
                        result = (inputTemp * 9.0 / 5.0) + 32.0;
                        break;

                    case 2:
                        fromUnit = "°F"; toUnit = "°C";
                        inputTemp = Input.ReadDouble("Ingrese temperatura en Fahrenheit: ", -459.67, 1_000_000);
                        result = (inputTemp - 32.0) * 5.0 / 9.0;
                        break;

                    case 3:
                        fromUnit = "°C"; toUnit = "K";
                        inputTemp = Input.ReadDouble("Ingrese temperatura en Celsius: ", -273.15, 1_000_000);
                        result = inputTemp + 273.15;
                        break;

                    case 4:
                        fromUnit = "K"; toUnit = "°C";
                        inputTemp = Input.ReadDouble("Ingrese temperatura en Kelvin: ", 0, 1_000_000);
                        result = inputTemp - 273.15;
                        break;

                    case 5:
                        fromUnit = "°F"; toUnit = "K";
                        inputTemp = Input.ReadDouble("Ingrese temperatura en Fahrenheit: ", -459.67, 1_000_000);
                        result = (inputTemp - 32.0) * 5.0 / 9.0 + 273.15;
                        break;

                    default: // 6
                        fromUnit = "K"; toUnit = "°F";
                        inputTemp = Input.ReadDouble("Ingrese temperatura en Kelvin: ", 0, 1_000_000);
                        result = (inputTemp - 273.15) * 9.0 / 5.0 + 32.0;
                        break;
                }

                ConsoleUI.Line();
                Console.WriteLine($"Entrada:  {inputTemp:0.00} {fromUnit}");
                Console.WriteLine($"Resultado: {result:0.00} {toUnit}");
            });
        }
    }
}
