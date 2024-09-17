
using System;

namespace MiNuevoPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crea un programa que defina un arreglo de enteros con 5 números,
            //luego suma todos los elementos del arreglo e imprime el resultado en pantalla

            int[] numeros = { 2, 4, 6, 8, 10 };
            int suma = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                suma += numeros[i];
            }

            Console.WriteLine("La suma de los elementos es: " + suma);

        }
    }
}
