using System;
using GuiaEjercicios.App;

namespace GuiaEjercicios.Ejercicios.Bloque1
{
    // Ejercicio 6: Menú para calcular área y perímetro
    // Figuras: círculo, triángulo, rectángulo y trapecio
    // Se valida que los valores ingresados sean positivos.
    public static class Ejercicio06_AreaPerimetro
    {
        public static void Run()
        {
            ExerciseRunner.Run("Ejercicio 6: Área y perímetro (menú)", () =>
            {
                Console.WriteLine("Seleccione una figura:");
                Console.WriteLine("1) Círculo");
                Console.WriteLine("2) Triángulo");
                Console.WriteLine("3) Rectángulo");
                Console.WriteLine("4) Trapecio");
                ConsoleUI.Line();

                int op = Input.ReadInt("Opción: ", 1, 4);
                ConsoleUI.Line();

                switch (op)
                {
                    case 1: Circulo(); break;
                    case 2: Triangulo(); break;
                    case 3: Rectangulo(); break;
                    case 4: Trapecio(); break;
                }
            });
        }

        private static double ReadPositive(string prompt)
        {
            // Reutilizamos Input.ReadDouble pero asegurando que sea positivo (>0)
            return Input.ReadDouble(prompt, 0.0000001, 1_000_000_000);
        }

        private static void Circulo()
        {
            // Círculo: área = PI*r^2, perímetro = 2*PI*r
            double r = ReadPositive("Ingrese el radio: ");

            double area = Math.PI * r * r;
            double perimetro = 2 * Math.PI * r;

            Console.WriteLine($"Área:      {area:0.00}");
            Console.WriteLine($"Perímetro: {perimetro:0.00}");
        }

        private static void Triangulo()
        {
            // Triángulo: pedimos 3 lados para perímetro y base+altura para área
            double a = ReadPositive("Lado 1: ");
            double b = ReadPositive("Lado 2: ");
            double c = ReadPositive("Lado 3: ");

            // Validación básica de triángulo (suma de dos lados > tercer lado)
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                ConsoleUI.Error("Estos lados no forman un triángulo válido.");
                return;
            }

            double baseT = ReadPositive("Base (para área): ");
            double altura = ReadPositive("Altura (para área): ");

            double area = (baseT * altura) / 2.0;
            double perimetro = a + b + c;

            Console.WriteLine($"Área:      {area:0.00}");
            Console.WriteLine($"Perímetro: {perimetro:0.00}");
        }

        private static void Rectangulo()
        {
            // Rectángulo: área = base*altura, perímetro = 2(base+altura)
            double baseR = ReadPositive("Ingrese la base: ");
            double altura = ReadPositive("Ingrese la altura: ");

            double area = baseR * altura;
            double perimetro = 2 * (baseR + altura);

            Console.WriteLine($"Área:      {area:0.00}");
            Console.WriteLine($"Perímetro: {perimetro:0.00}");
        }

        private static void Trapecio()
        {
            // Trapecio: área = ((B + b)/2) * h
            // Perímetro = suma de los 4 lados
            double baseMayor = ReadPositive("Base mayor (B): ");
            double baseMenor = ReadPositive("Base menor (b): ");
            double altura = ReadPositive("Altura (h): ");

            double lado1 = ReadPositive("Lado 1: ");
            double lado2 = ReadPositive("Lado 2: ");

            double area = ((baseMayor + baseMenor) / 2.0) * altura;
            double perimetro = baseMayor + baseMenor + lado1 + lado2;

            Console.WriteLine($"Área:      {area:0.00}");
            Console.WriteLine($"Perímetro: {perimetro:0.00}");
        }
    }
}

