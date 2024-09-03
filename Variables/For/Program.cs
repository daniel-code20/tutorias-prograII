using System;
using static System.Console;

namespace MiNuevoPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tabla de multiplicar: Escribe un programa que pida al usuario un número y
            // luego muestre la tabla de multiplicar de ese número del 1 al 10.

            WriteLine("Escriba un valor");
            int valor = int.Parse(ReadLine());
            WriteLine("***TABLA***");

            for (int i = 1; i <= 10; i++)
            {
                int resultado = valor * i;
                WriteLine($"\n{valor} x {i} = {resultado}");

            }
        }
    }
}
