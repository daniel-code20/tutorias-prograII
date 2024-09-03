using System;
using static System.Console;

namespace MiNuevoPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            // Determinar si un número es par o impar: Escribe un programa que
            // pida un número al usuario y determine si es par o impar.
            WriteLine("ingrese un numero");
            int valor = int.Parse(ReadLine());

            if (valor % 2 == 0)
            {
                WriteLine("Es par");
            }
            else 
            {
                WriteLine("Es impar");
            }
        }
    }
}
