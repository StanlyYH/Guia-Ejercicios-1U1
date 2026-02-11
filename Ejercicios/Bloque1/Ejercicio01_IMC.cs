using System;
using GuiaEjercicios.App;

namespace GuiaEjercicios.Ejercicios.Bloque1
{
    public static class Ejercicio01_IMC
    {
        public static void Run()
        {
            ExerciseRunner.Run("Ejercicio 1: Calculadora de IMC", () =>
            {
                double pesoKg = Input.ReadDouble("Ingrese su peso en kg: ", 1, 500);
                double estaturaM = Input.ReadDouble("Ingrese su estatura en metros (ej: 1.75): ", 0.5, 2.5);

                double imc = pesoKg / (estaturaM * estaturaM);
                string categoria = GetCategoriaIMC(imc);

                ConsoleUI.Line();
                Console.WriteLine($"Peso: {pesoKg:0.00} kg");
                Console.WriteLine($"Estatura: {estaturaM:0.00} m");
                Console.WriteLine($"IMC: {imc:0.00}");
                Console.WriteLine($"Categoría: {categoria}");
            });
        }

        private static string GetCategoriaIMC(double imc)
        {
            if (imc < 18.5) return "Bajo peso";
            if (imc < 25.0) return "Normal";
            if (imc < 30.0) return "Sobrepeso";
            if (imc < 35.0) return "Obesidad I";
            if (imc < 40.0) return "Obesidad II";
            return "Obesidad III";
        }
    }
}


