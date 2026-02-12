using System;
using GuiaEjercicios.App;

namespace GuiaEjercicios.Ejercicios.Bloque3
{
    // Ejercicio 20:
    // Solicitar contraseña hasta que cumpla:
    // - mínimo 8 caracteres
    // - al menos una mayúscula
    // - al menos una minúscula
    // - al menos un número
    // - al menos un carácter especial
    // Indicar qué falta en cada intento.
    public static class Ejercicio20_Contrasena
    {
        public static void Run()
        {
            ExerciseRunner.Run("Ejercicio 20: Validación de contraseña", () =>
            {
                while (true)
                {
                    string pass = Input.ReadString("Ingrese una contraseña: ");

                    bool tieneLargo = pass.Length >= 8;
                    bool tieneMayus = false;
                    bool tieneMinus = false;
                    bool tieneNumero = false;
                    bool tieneEspecial = false;

                    // Revisamos caracter por caracter
                    foreach (char c in pass)
                    {
                        if (char.IsUpper(c)) tieneMayus = true;
                        else if (char.IsLower(c)) tieneMinus = true;
                        else if (char.IsDigit(c)) tieneNumero = true;
                        else tieneEspecial = true; // todo lo demás lo tomamos como especial
                    }

                    // Si cumple todo, salimos
                    if (tieneLargo && tieneMayus && tieneMinus && tieneNumero && tieneEspecial)
                    {
                        ConsoleUI.Line();
                        Console.WriteLine("Contraseña válida ✅");
                        break;
                    }

                    // Si no cumple, mostramos qué falta
                    ConsoleUI.Line();
                    ConsoleUI.Error("Contraseña NO válida. Te falta:");

                    if (!tieneLargo)   Console.WriteLine("- Mínimo 8 caracteres");
                    if (!tieneMayus)   Console.WriteLine("- Al menos una MAYÚSCULA");
                    if (!tieneMinus)   Console.WriteLine("- Al menos una minúscula");
                    if (!tieneNumero)  Console.WriteLine("- Al menos un número");
                    if (!tieneEspecial)Console.WriteLine("- Al menos un carácter especial (ej: !@#$%)");

                    ConsoleUI.Line();
                }
            });
        }
    }
}
